using System;
using System.IO;

// Token: 0x0200002B RID: 43
public class GClass7
{
	// Token: 0x0600019B RID: 411 RVA: 0x0000E274 File Offset: 0x0000C474
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000E2CC File Offset: 0x0000C4CC
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002797 File Offset: 0x00000997
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000E320 File Offset: 0x0000C520
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000E48C File Offset: 0x0000C68C
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x04000331 RID: 817
	private byte[] byte_0;

	// Token: 0x04000332 RID: 818
	private uint uint_0;

	// Token: 0x04000333 RID: 819
	private uint uint_1;

	// Token: 0x04000334 RID: 820
	private uint uint_2;

	// Token: 0x04000335 RID: 821
	private Stream stream_0;

	// Token: 0x04000336 RID: 822
	private uint uint_3 = 1U;

	// Token: 0x04000337 RID: 823
	public uint uint_4;
}
