using System;

// Token: 0x02000026 RID: 38
internal abstract class Class32
{
	// Token: 0x06000187 RID: 391 RVA: 0x00002710 File Offset: 0x00000910
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x04000304 RID: 772
	public const uint uint_0 = 12U;

	// Token: 0x04000305 RID: 773
	public const int int_0 = 6;

	// Token: 0x04000306 RID: 774
	private const int int_1 = 2;

	// Token: 0x04000307 RID: 775
	public const uint uint_1 = 4U;

	// Token: 0x04000308 RID: 776
	public const uint uint_2 = 2U;

	// Token: 0x04000309 RID: 777
	public const int int_2 = 4;

	// Token: 0x0400030A RID: 778
	public const uint uint_3 = 4U;

	// Token: 0x0400030B RID: 779
	public const uint uint_4 = 14U;

	// Token: 0x0400030C RID: 780
	public const uint uint_5 = 128U;

	// Token: 0x0400030D RID: 781
	public const int int_3 = 4;

	// Token: 0x0400030E RID: 782
	public const uint uint_6 = 16U;

	// Token: 0x0400030F RID: 783
	public const int int_4 = 3;

	// Token: 0x04000310 RID: 784
	public const int int_5 = 3;

	// Token: 0x04000311 RID: 785
	public const int int_6 = 8;

	// Token: 0x04000312 RID: 786
	public const uint uint_7 = 8U;

	// Token: 0x04000313 RID: 787
	public const uint uint_8 = 8U;

	// Token: 0x0200004E RID: 78
	public struct Struct3
	{
		// Token: 0x06000321 RID: 801 RVA: 0x000027C5 File Offset: 0x000009C5
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001121C File Offset: 0x0000F41C
		public void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000027D5 File Offset: 0x000009D5
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000027FC File Offset: 0x000009FC
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002823 File Offset: 0x00000A23
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000284A File Offset: 0x00000A4A
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x0400036F RID: 879
		public uint uint_0;
	}
}
