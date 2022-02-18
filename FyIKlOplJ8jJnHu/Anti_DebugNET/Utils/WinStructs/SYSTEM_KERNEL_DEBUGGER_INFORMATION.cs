using System;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000010 RID: 16
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x040002C3 RID: 707
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x040002C4 RID: 708
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
