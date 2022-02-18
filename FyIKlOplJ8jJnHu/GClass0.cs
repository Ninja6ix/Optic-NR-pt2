using System;
using System.Runtime.InteropServices;

// Token: 0x0200001F RID: 31
public class GClass0
{
	// Token: 0x06000101 RID: 257 RVA: 0x00008990 File Offset: 0x00006B90
	public GClass0()
	{
		if (GClass0.uint_0 == null)
		{
			GClass0.uint_0 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				GClass0.uint_0[i] = num;
			}
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00008A58 File Offset: 0x00006C58
	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)uint_1))
		{
			num = (GClass0.uint_0[(int)(((uint)Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x040002E9 RID: 745
	private static uint[] uint_0;
}
