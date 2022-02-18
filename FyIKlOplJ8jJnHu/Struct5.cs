using System;

// Token: 0x02000029 RID: 41
internal struct Struct5
{
	// Token: 0x06000194 RID: 404 RVA: 0x0000275A File Offset: 0x0000095A
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000E024 File Offset: 0x0000C224
	public uint method_1(Class35 class35_0)
	{
		uint num = (class35_0.uint_2 >> 11) * this.uint_1;
		if (class35_0.uint_3 < num)
		{
			class35_0.uint_2 = num;
			this.uint_1 += 2048U - this.uint_1 >> 5;
			if (class35_0.uint_2 < 16777216U)
			{
				class35_0.uint_3 = (class35_0.uint_3 << 8 | (uint)((byte)class35_0.stream_0.ReadByte()));
				class35_0.uint_2 <<= 8;
			}
			return 0U;
		}
		class35_0.uint_2 -= num;
		class35_0.uint_3 -= num;
		this.uint_1 -= this.uint_1 >> 5;
		if (class35_0.uint_2 < 16777216U)
		{
			class35_0.uint_3 = (class35_0.uint_3 << 8 | (uint)((byte)class35_0.stream_0.ReadByte()));
			class35_0.uint_2 <<= 8;
		}
		return 1U;
	}

	// Token: 0x0400032B RID: 811
	private const int int_0 = 11;

	// Token: 0x0400032C RID: 812
	private const uint uint_0 = 2048U;

	// Token: 0x0400032D RID: 813
	private const int int_1 = 5;

	// Token: 0x0400032E RID: 814
	private uint uint_1;
}
