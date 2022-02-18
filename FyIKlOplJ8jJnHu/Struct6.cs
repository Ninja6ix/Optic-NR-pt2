using System;

// Token: 0x0200002A RID: 42
internal struct Struct6
{
	// Token: 0x06000196 RID: 406 RVA: 0x0000276A File Offset: 0x0000096A
	public Struct6(int int_1)
	{
		this.int_0 = int_1;
		this.struct5_0 = new Struct5[1 << int_1];
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000E184 File Offset: 0x0000C384
	public void method_0()
	{
		while (1L < 1L << (this.int_0 & 31))
		{
			this.struct5_0[1].method_0();
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000E1BC File Offset: 0x0000C3BC
	public uint method_1(Class35 class35_0)
	{
		for (int i = this.int_0; i > 0; i--)
		{
			uint num = 2U + this.struct5_0[1].method_1(class35_0);
		}
		return 1U - (1U << this.int_0);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000E1FC File Offset: 0x0000C3FC
	public uint method_2(Class35 class35_0)
	{
		uint num = 0U;
		for (int i = 0; i < this.int_0; i++)
		{
			uint num2 = this.struct5_0[1].method_1(class35_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000E23C File Offset: 0x0000C43C
	public static uint smethod_0(Struct5[] struct5_1, uint uint_0, Class35 class35_0, int int_1)
	{
		uint num = 0U;
		for (int i = 0; i < int_1; i++)
		{
			uint num2 = struct5_1[(int)(uint_0 + 1U)].method_1(class35_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x0400032F RID: 815
	private readonly Struct5[] struct5_0;

	// Token: 0x04000330 RID: 816
	private readonly int int_0;
}
