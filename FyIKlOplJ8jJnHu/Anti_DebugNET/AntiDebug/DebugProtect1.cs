using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000012 RID: 18
	internal class DebugProtect1
	{
		// Token: 0x060000A9 RID: 169
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x060000AA RID: 170
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060000AB RID: 171 RVA: 0x000080F4 File Offset: 0x000062F4
		public static int PerformChecks()
		{
			if (DebugProtect1.CheckDebuggerManagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				return 1;
			}
			if (DebugProtect1.CheckDebuggerUnmanagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
				return 1;
			}
			if (DebugProtect1.CheckRemoteDebugger() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckRemoteDebugger: HIT");
				return 1;
			}
			return 0;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000023A3 File Offset: 0x000005A3
		private static int CheckDebuggerManagedPresent()
		{
			if (Debugger.IsAttached)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000023B7 File Offset: 0x000005B7
		private static int CheckDebuggerUnmanagedPresent()
		{
			if (DebugProtect1.IsDebuggerPresent())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008178 File Offset: 0x00006378
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			if (DebugProtect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				return 1;
			}
			return 0;
		}
	}
}
