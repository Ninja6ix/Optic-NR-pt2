using System;

// Token: 0x02000021 RID: 33
public class GClass2
{
	// Token: 0x06000105 RID: 261 RVA: 0x00008AE4 File Offset: 0x00006CE4
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x040002EB RID: 747
	public const int int_0 = 32;
}
