using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000013 RID: 19
	internal class DebugProtect2
	{
		// Token: 0x060000B0 RID: 176
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000B1 RID: 177
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtClose([In] IntPtr Handle);

		// Token: 0x060000B2 RID: 178
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

		// Token: 0x060000B3 RID: 179
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtSetInformationDebugObject([In] IntPtr DebugObjectHandle, [In] DebugObjectInformationClass DebugObjectInformationClass, [In] IntPtr DebugObjectInformation, [In] int DebugObjectInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000B4 RID: 180
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQuerySystemInformation([In] SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, [In] int SystemInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000B5 RID: 181 RVA: 0x000081B4 File Offset: 0x000063B4
		public static int PerformChecks()
		{
			if (DebugProtect2.CheckDebugPort() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebugPort: HIT");
				return 1;
			}
			if (DebugProtect2.CheckKernelDebugInformation())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckKernelDebugInformation: HIT");
				return 1;
			}
			if (DebugProtect2.DetachFromDebuggerProcess())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("DetachFromDebuggerProcess: HIT");
				return 1;
			}
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008230 File Offset: 0x00006430
		private static int CheckDebugPort()
		{
			IntPtr intPtr = new IntPtr(0);
			int num;
			if (DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugPort, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num) == NtStatus.Success && intPtr == new IntPtr(-1))
			{
				Console.WriteLine("DebugPort : {0:X}", intPtr);
				return 1;
			}
			return 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000082B0 File Offset: 0x000064B0
		private unsafe static bool DetachFromDebuggerProcess()
		{
			IntPtr invalid_HANDLE_VALUE = DebugProtect2.INVALID_HANDLE_VALUE;
			uint structure = 0U;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugObjectHandle, out invalid_HANDLE_VALUE, IntPtr.Size, out num);
			if (ntStatus != NtStatus.Success)
			{
				return false;
			}
			int num2;
			ntStatus = DebugProtect2.NtSetInformationDebugObject(invalid_HANDLE_VALUE, DebugObjectInformationClass.DebugObjectFlags, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2);
			if (ntStatus != NtStatus.Success)
			{
				return false;
			}
			ntStatus = DebugProtect2.NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, invalid_HANDLE_VALUE);
			if (ntStatus != NtStatus.Success)
			{
				return false;
			}
			ntStatus = DebugProtect2.NtClose(invalid_HANDLE_VALUE);
			return ntStatus == NtStatus.Success;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008378 File Offset: 0x00006578
		private unsafe static bool CheckKernelDebugInformation()
		{
			SYSTEM_KERNEL_DEBUGGER_INFORMATION system_KERNEL_DEBUGGER_INFORMATION;
			int num;
			return DebugProtect2.NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr((void*)(&system_KERNEL_DEBUGGER_INFORMATION)), Marshal.SizeOf<SYSTEM_KERNEL_DEBUGGER_INFORMATION>(system_KERNEL_DEBUGGER_INFORMATION), out num) == NtStatus.Success && system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerEnabled && !system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerNotPresent;
		}

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
	}
}
