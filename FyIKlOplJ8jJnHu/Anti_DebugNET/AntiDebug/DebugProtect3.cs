using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000014 RID: 20
	internal class DebugProtect3
	{
		// Token: 0x060000BB RID: 187
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x060000BC RID: 188
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x060000BD RID: 189
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x060000BE RID: 190
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x060000BF RID: 191
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060000C0 RID: 192 RVA: 0x000083D4 File Offset: 0x000065D4
		public static void HideOSThreads()
		{
			ProcessThreadCollection threads = Process.GetCurrentProcess().Threads;
			foreach (object obj in threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", processThread.Id);
				IntPtr intPtr = DebugProtect3.OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
				if (intPtr == IntPtr.Zero)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", processThread.Id);
				}
				else
				{
					if (DebugProtect3.HideFromDebugger(intPtr))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", processThread.Id);
					}
					DebugProtect3.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000084FC File Offset: 0x000066FC
		public static bool HideFromDebugger(IntPtr Handle)
		{
			return DebugProtect3.NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0) == NtStatus.Success;
		}
	}
}
