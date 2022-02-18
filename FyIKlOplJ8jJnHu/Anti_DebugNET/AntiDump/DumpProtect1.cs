using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDump
{
	// Token: 0x02000011 RID: 17
	internal class DumpProtect1
	{
		// Token: 0x060000A3 RID: 163
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x060000A4 RID: 164
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x060000A5 RID: 165 RVA: 0x00007DD8 File Offset: 0x00005FD8
		private static void EraseSection(IntPtr address, int size)
		{
			IntPtr intPtr = (IntPtr)size;
			IntPtr flNewProtect = 0;
			DumpProtect1.VirtualProtect(address, intPtr, (IntPtr)64, ref flNewProtect);
			DumpProtect1.ZeroMemory(address, intPtr);
			IntPtr intPtr2 = 0;
			DumpProtect1.VirtualProtect(address, intPtr, flNewProtect, ref intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007E48 File Offset: 0x00006048
		public static void AntiDump()
		{
			Process currentProcess = Process.GetCurrentProcess();
			IntPtr baseAddress = currentProcess.MainModule.BaseAddress;
			int num = Marshal.ReadInt32((IntPtr)(baseAddress.ToInt32() + 60));
			short num2 = Marshal.ReadInt16((IntPtr)(baseAddress.ToInt32() + num + 6));
			DumpProtect1.EraseSection(baseAddress, 30);
			for (int i = 0; i < DumpProtect1.peheaderdwords.Length; i++)
			{
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + DumpProtect1.peheaderdwords[i]), 4);
			}
			for (int j = 0; j < DumpProtect1.peheaderwords.Length; j++)
			{
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + DumpProtect1.peheaderwords[j]), 2);
			}
			for (int k = 0; k < DumpProtect1.peheaderbytes.Length; k++)
			{
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + DumpProtect1.peheaderbytes[k]), 1);
			}
			int l = 0;
			int num3 = 0;
			while (l <= (int)num2)
			{
				if (num3 == 0)
				{
					DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + 32), 2);
				}
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + DumpProtect1.sectiontabledwords[num3]), 4);
				num3++;
				if (num3 == DumpProtect1.sectiontabledwords.Length)
				{
					l++;
					num3 = 0;
				}
			}
		}

		// Token: 0x040002C5 RID: 709
		private static int[] sectiontabledwords = new int[]
		{
			8,
			12,
			16,
			20,
			24,
			28,
			36
		};

		// Token: 0x040002C6 RID: 710
		private static int[] peheaderbytes = new int[]
		{
			26,
			27
		};

		// Token: 0x040002C7 RID: 711
		private static int[] peheaderwords = new int[]
		{
			4,
			22,
			24,
			64,
			66,
			68,
			70,
			72,
			74,
			76,
			92,
			94
		};

		// Token: 0x040002C8 RID: 712
		private static int[] peheaderdwords = new int[]
		{
			0,
			8,
			12,
			16,
			22,
			28,
			32,
			40,
			44,
			52,
			60,
			76,
			80,
			84,
			88,
			96,
			100,
			104,
			108,
			112,
			116,
			260,
			264,
			268,
			272,
			276,
			284
		};
	}
}
