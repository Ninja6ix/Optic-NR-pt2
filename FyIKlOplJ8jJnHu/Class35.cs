using System;
using System.IO;

// Token: 0x02000028 RID: 40
internal class Class35
{
	// Token: 0x06000190 RID: 400 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
	public void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.uint_3 = 0U;
		this.uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.uint_3 = (this.uint_3 << 8 | (uint)((byte)this.stream_0.ReadByte()));
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002735 File Offset: 0x00000935
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0000DF24 File Offset: 0x0000C124
	public uint method_2(int int_0)
	{
		uint num = this.uint_2;
		uint num2 = this.uint_3;
		uint num3 = 0U;
		for (int i = int_0; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				num <<= 8;
			}
		}
		this.uint_2 = num;
		this.uint_3 = num2;
		return num3;
	}

	// Token: 0x04000326 RID: 806
	private uint uint_0 = 1U;

	// Token: 0x04000327 RID: 807
	public const uint uint_1 = 16777216U;

	// Token: 0x04000328 RID: 808
	public uint uint_2;

	// Token: 0x04000329 RID: 809
	public uint uint_3;

	// Token: 0x0400032A RID: 810
	public Stream stream_0;
}
