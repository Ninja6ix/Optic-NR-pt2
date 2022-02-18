using System;
using System.Runtime.InteropServices;

// Token: 0x02000025 RID: 37
internal static class Class31
{
	// Token: 0x0600017C RID: 380
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	// Token: 0x0600017D RID: 381
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Class31.Enum0 enum0_0, int int_5, int int_6, string string_0);

	// Token: 0x0600017E RID: 382
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Class31.Enum1 enum1_0, int int_5, int int_6, IntPtr intptr_4);

	// Token: 0x0600017F RID: 383
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	// Token: 0x06000180 RID: 384
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	// Token: 0x06000181 RID: 385
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x06000182 RID: 386
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Class31.Enum0 enum0_0, out Class31.Enum0 enum0_1);

	// Token: 0x06000183 RID: 387
	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	// Token: 0x06000184 RID: 388
	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	// Token: 0x06000185 RID: 389
	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, byte[] byte_0, uint uint_0, out uint uint_1);

	// Token: 0x040002FC RID: 764
	public const int int_0 = -2147483648;

	// Token: 0x040002FD RID: 765
	public const int int_1 = 3;

	// Token: 0x040002FE RID: 766
	public const int int_2 = 128;

	// Token: 0x040002FF RID: 767
	public const int int_3 = 1;

	// Token: 0x04000300 RID: 768
	public const int int_4 = 2;

	// Token: 0x04000301 RID: 769
	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x04000302 RID: 770
	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x04000303 RID: 771
	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	// Token: 0x0200004C RID: 76
	public enum Enum0 : uint
	{
		// Token: 0x04000362 RID: 866
		const_0 = 1U,
		// Token: 0x04000363 RID: 867
		const_1,
		// Token: 0x04000364 RID: 868
		const_2 = 4U,
		// Token: 0x04000365 RID: 869
		const_3 = 8U,
		// Token: 0x04000366 RID: 870
		const_4 = 16U,
		// Token: 0x04000367 RID: 871
		const_5 = 32U,
		// Token: 0x04000368 RID: 872
		const_6 = 64U,
		// Token: 0x04000369 RID: 873
		const_7 = 256U
	}

	// Token: 0x0200004D RID: 77
	public enum Enum1 : uint
	{
		// Token: 0x0400036B RID: 875
		const_0 = 1U,
		// Token: 0x0400036C RID: 876
		const_1,
		// Token: 0x0400036D RID: 877
		const_2 = 4U,
		// Token: 0x0400036E RID: 878
		const_3 = 31U
	}
}
