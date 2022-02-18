using System;

// Token: 0x02000020 RID: 32
public class GClass1
{
	// Token: 0x06000103 RID: 259 RVA: 0x000026A3 File Offset: 0x000008A3
	public GClass1()
	{
		this.uint_0 = 244857800U;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00008AA0 File Offset: 0x00006CA0
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass2.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x040002EA RID: 746
	private uint uint_0;
}
