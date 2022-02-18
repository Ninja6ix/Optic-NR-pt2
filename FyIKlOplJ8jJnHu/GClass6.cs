using System;
using System.IO;

// Token: 0x02000027 RID: 39
public class GClass6
{
	// Token: 0x06000189 RID: 393 RVA: 0x0000DA6C File Offset: 0x0000BC6C
	public GClass6()
	{
		this.uint_1 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.struct6_0[num] = new Struct6(6);
			num++;
		}
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
	private void method_0(uint uint_4)
	{
		if (this.uint_1 != uint_4)
		{
			this.uint_1 = uint_4;
			this.uint_2 = Math.Max(this.uint_1, 1U);
			uint uint_5 = Math.Max(this.uint_2, 4096U);
			this.gclass7_0.method_0(uint_5);
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000DC44 File Offset: 0x0000BE44
	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.class34_0.method_0(int_0, int_1);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000DC94 File Offset: 0x0000BE94
	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << int_0;
		this.class33_0.method_0(num);
		this.class33_1.method_0(num);
		this.uint_3 = num - 1U;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000DD04 File Offset: 0x0000BF04
	private void method_3(Stream stream_0, Stream stream_1)
	{
		this.class35_0.method_0(stream_0);
		this.gclass7_0.method_1(stream_1, false);
		for (;;)
		{
			for (uint num = 0U; num <= this.uint_3; num += 1U)
			{
				uint num2 = 0U + num;
				this.struct5_0[(int)num2].method_0();
				this.struct5_5[(int)num2].method_0();
			}
			this.struct5_1[0].method_0();
			this.struct5_2[0].method_0();
			this.struct5_3[0].method_0();
			this.struct5_4[0].method_0();
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002348 File Offset: 0x00000548
	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000DDA8 File Offset: 0x0000BFA8
	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)(byte_0[0] % 9);
		byte b = byte_0[0] / 9;
		int int_2 = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)byte_0[1 + i] << i * 8);
		}
		this.method_0(num2);
		this.method_1(int_2, int_);
		this.method_2(num);
	}

	// Token: 0x04000314 RID: 788
	private uint uint_0 = 1U;

	// Token: 0x04000315 RID: 789
	private readonly GClass7 gclass7_0 = new GClass7();

	// Token: 0x04000316 RID: 790
	private readonly Class35 class35_0 = new Class35();

	// Token: 0x04000317 RID: 791
	private readonly Struct5[] struct5_0 = new Struct5[192];

	// Token: 0x04000318 RID: 792
	private readonly Struct5[] struct5_1 = new Struct5[12];

	// Token: 0x04000319 RID: 793
	private readonly Struct5[] struct5_2 = new Struct5[12];

	// Token: 0x0400031A RID: 794
	private readonly Struct5[] struct5_3 = new Struct5[12];

	// Token: 0x0400031B RID: 795
	private readonly Struct5[] struct5_4 = new Struct5[12];

	// Token: 0x0400031C RID: 796
	private readonly Struct5[] struct5_5 = new Struct5[192];

	// Token: 0x0400031D RID: 797
	private readonly Struct6[] struct6_0 = new Struct6[4];

	// Token: 0x0400031E RID: 798
	private readonly Struct5[] struct5_6 = new Struct5[114];

	// Token: 0x0400031F RID: 799
	private Struct6 struct6_1 = new Struct6(4);

	// Token: 0x04000320 RID: 800
	private readonly GClass6.Class33 class33_0 = new GClass6.Class33();

	// Token: 0x04000321 RID: 801
	private readonly GClass6.Class33 class33_1 = new GClass6.Class33();

	// Token: 0x04000322 RID: 802
	private readonly GClass6.Class34 class34_0 = new GClass6.Class34();

	// Token: 0x04000323 RID: 803
	private uint uint_1;

	// Token: 0x04000324 RID: 804
	private uint uint_2;

	// Token: 0x04000325 RID: 805
	private uint uint_3;

	// Token: 0x0200004F RID: 79
	private class Class33
	{
		// Token: 0x06000327 RID: 807 RVA: 0x0001128C File Offset: 0x0000F48C
		public void method_0(uint uint_1)
		{
			for (uint num = this.uint_0; num < uint_1; num += 1U)
			{
				this.struct6_0[(int)num] = new Struct6(3);
				this.struct6_1[(int)num] = new Struct6(3);
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00011308 File Offset: 0x0000F508
		public void method_1()
		{
			this.struct5_0.method_0();
			while (0U < this.uint_0)
			{
				this.struct6_0[0].method_0();
				this.struct6_1[0].method_0();
			}
			this.struct5_1.method_0();
			this.struct6_2.method_0();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00011364 File Offset: 0x0000F564
		public uint method_2(Class35 class35_0, uint uint_1)
		{
			if (this.struct5_0.method_1(class35_0) == 0U)
			{
				return this.struct6_0[(int)uint_1].method_1(class35_0);
			}
			uint num = 8U;
			if (this.struct5_1.method_1(class35_0) == 0U)
			{
				num += this.struct6_1[(int)uint_1].method_1(class35_0);
			}
			else
			{
				num += 8U;
				num += this.struct6_2.method_1(class35_0);
			}
			return num;
		}

		// Token: 0x04000370 RID: 880
		private Struct5 struct5_0;

		// Token: 0x04000371 RID: 881
		private Struct5 struct5_1;

		// Token: 0x04000372 RID: 882
		private readonly Struct6[] struct6_0 = new Struct6[16];

		// Token: 0x04000373 RID: 883
		private readonly Struct6[] struct6_1 = new Struct6[16];

		// Token: 0x04000374 RID: 884
		private Struct6 struct6_2 = new Struct6(8);

		// Token: 0x04000375 RID: 885
		private uint uint_0;
	}

	// Token: 0x02000050 RID: 80
	private class Class34
	{
		// Token: 0x0600032B RID: 811 RVA: 0x00011464 File Offset: 0x0000F664
		public void method_0(int int_2, int int_3)
		{
			if (this.struct4_0 != null && this.int_0 == int_3 && this.int_1 == int_2)
			{
				return;
			}
			this.int_1 = int_2;
			this.uint_1 = (1U << int_2) - 1U;
			this.int_0 = int_3;
			uint num = 1U << this.int_0 + this.int_1;
			this.struct4_0 = new GClass6.Class34.Struct4[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.struct4_0[(int)num2].method_0();
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000114E4 File Offset: 0x0000F6E4
		public void method_1()
		{
			uint num = 1U << this.int_0 + this.int_1;
			while (0U < num)
			{
				this.struct4_0[0].method_1();
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000285C File Offset: 0x00000A5C
		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & this.uint_1) << this.int_0) + (uint)(byte_0 >> 8 - this.int_0);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002897 File Offset: 0x00000A97
		public byte method_3(Class35 class35_0, uint uint_2, byte byte_0)
		{
			return this.struct4_0[(int)this.method_2(uint_2, byte_0)].method_2(class35_0);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000028C1 File Offset: 0x00000AC1
		public byte method_4(Class35 class35_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return this.struct4_0[(int)this.method_2(uint_2, byte_0)].method_3(class35_0, byte_1);
		}

		// Token: 0x04000376 RID: 886
		private uint uint_0 = 1U;

		// Token: 0x04000377 RID: 887
		private GClass6.Class34.Struct4[] struct4_0;

		// Token: 0x04000378 RID: 888
		private int int_0;

		// Token: 0x04000379 RID: 889
		private int int_1;

		// Token: 0x0400037A RID: 890
		private uint uint_1;

		// Token: 0x02000051 RID: 81
		private struct Struct4
		{
			// Token: 0x06000331 RID: 817 RVA: 0x00002908 File Offset: 0x00000B08
			public void method_0()
			{
				this.struct5_0 = new Struct5[768];
			}

			// Token: 0x06000332 RID: 818 RVA: 0x0001151C File Offset: 0x0000F71C
			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					this.struct5_0[i].method_0();
				}
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00011564 File Offset: 0x0000F764
			public byte method_2(Class35 class35_0)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.struct5_0[(int)num].method_1(class35_0));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x06000334 RID: 820 RVA: 0x000115B4 File Offset: 0x0000F7B4
			public byte method_3(Class35 class35_0, byte byte_0)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(byte_0 >> 7 & 1);
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = this.struct5_0[(int)((1U + num2 << 8) + num)].method_1(class35_0);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_C0;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.struct5_0[(int)num].method_1(class35_0));
				}
				IL_C0:
				return (byte)num;
			}

			// Token: 0x0400037B RID: 891
			private Struct5[] struct5_0;
		}
	}
}
