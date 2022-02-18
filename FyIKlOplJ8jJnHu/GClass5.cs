using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

// Token: 0x02000024 RID: 36
public class GClass5
{
	// Token: 0x06000109 RID: 265 RVA: 0x00008B38 File Offset: 0x00006D38
	public GClass5()
	{
		this.long_0 = Marshal.GetHINSTANCE(this.module_0).ToInt64();
		this.dictionary_0[0U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[1U] = new GClass5.Delegate0(this.method_49);
		this.dictionary_0[2U] = new GClass5.Delegate0(this.method_109);
		this.dictionary_0[3U] = new GClass5.Delegate0(this.method_89);
		this.dictionary_0[4U] = new GClass5.Delegate0(this.method_50);
		this.dictionary_0[5U] = new GClass5.Delegate0(this.method_59);
		this.dictionary_0[6U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[7U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[8U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[9U] = new GClass5.Delegate0(this.method_84);
		this.dictionary_0[10U] = new GClass5.Delegate0(this.method_57);
		this.dictionary_0[11U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[12U] = new GClass5.Delegate0(this.method_110);
		this.dictionary_0[13U] = new GClass5.Delegate0(this.method_86);
		this.dictionary_0[14U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[15U] = new GClass5.Delegate0(this.method_9);
		this.dictionary_0[16U] = new GClass5.Delegate0(this.method_52);
		this.dictionary_0[17U] = new GClass5.Delegate0(this.method_48);
		this.dictionary_0[18U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[19U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[20U] = new GClass5.Delegate0(this.method_104);
		this.dictionary_0[21U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[22U] = new GClass5.Delegate0(this.method_75);
		this.dictionary_0[23U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[24U] = new GClass5.Delegate0(this.method_38);
		this.dictionary_0[25U] = new GClass5.Delegate0(this.method_62);
		this.dictionary_0[26U] = new GClass5.Delegate0(this.method_88);
		this.dictionary_0[27U] = new GClass5.Delegate0(this.method_64);
		this.dictionary_0[28U] = new GClass5.Delegate0(this.method_67);
		this.dictionary_0[29U] = new GClass5.Delegate0(this.method_53);
		this.dictionary_0[30U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[31U] = new GClass5.Delegate0(this.method_72);
		this.dictionary_0[32U] = new GClass5.Delegate0(this.method_80);
		this.dictionary_0[33U] = new GClass5.Delegate0(this.method_83);
		this.dictionary_0[34U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[35U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[36U] = new GClass5.Delegate0(this.method_100);
		this.dictionary_0[37U] = new GClass5.Delegate0(this.method_98);
		this.dictionary_0[38U] = new GClass5.Delegate0(this.method_90);
		this.dictionary_0[39U] = new GClass5.Delegate0(this.method_106);
		this.dictionary_0[40U] = new GClass5.Delegate0(this.method_85);
		this.dictionary_0[41U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[42U] = new GClass5.Delegate0(this.method_99);
		this.dictionary_0[43U] = new GClass5.Delegate0(this.method_94);
		this.dictionary_0[44U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[45U] = new GClass5.Delegate0(this.method_91);
		this.dictionary_0[46U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[47U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[48U] = new GClass5.Delegate0(this.method_96);
		this.dictionary_0[49U] = new GClass5.Delegate0(this.method_35);
		this.dictionary_0[50U] = new GClass5.Delegate0(this.method_77);
		this.dictionary_0[51U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[52U] = new GClass5.Delegate0(this.method_102);
		this.dictionary_0[53U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[54U] = new GClass5.Delegate0(this.method_65);
		this.dictionary_0[55U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[56U] = new GClass5.Delegate0(this.method_105);
		this.dictionary_0[57U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[58U] = new GClass5.Delegate0(this.method_92);
		this.dictionary_0[59U] = new GClass5.Delegate0(this.method_40);
		this.dictionary_0[60U] = new GClass5.Delegate0(this.method_47);
		this.dictionary_0[61U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[62U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[63U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[64U] = new GClass5.Delegate0(this.method_54);
		this.dictionary_0[65U] = new GClass5.Delegate0(this.method_60);
		this.dictionary_0[66U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[67U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[68U] = new GClass5.Delegate0(this.method_61);
		this.dictionary_0[69U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[70U] = new GClass5.Delegate0(this.method_36);
		this.dictionary_0[71U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[72U] = new GClass5.Delegate0(this.method_51);
		this.dictionary_0[73U] = new GClass5.Delegate0(this.method_58);
		this.dictionary_0[74U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[75U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[76U] = new GClass5.Delegate0(this.method_82);
		this.dictionary_0[77U] = new GClass5.Delegate0(this.method_88);
		this.dictionary_0[78U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[79U] = new GClass5.Delegate0(this.method_99);
		this.dictionary_0[80U] = new GClass5.Delegate0(this.method_90);
		this.dictionary_0[81U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[82U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[83U] = new GClass5.Delegate0(this.method_83);
		this.dictionary_0[84U] = new GClass5.Delegate0(this.method_64);
		this.dictionary_0[85U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[86U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[87U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[88U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[89U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[90U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[91U] = new GClass5.Delegate0(this.method_57);
		this.dictionary_0[92U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[93U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[94U] = new GClass5.Delegate0(this.method_105);
		this.dictionary_0[95U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[96U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[97U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[98U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[99U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[100U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[101U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[102U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[103U] = new GClass5.Delegate0(this.method_61);
		this.dictionary_0[104U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[105U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[106U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[107U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[108U] = new GClass5.Delegate0(this.method_94);
		this.dictionary_0[109U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[110U] = new GClass5.Delegate0(this.method_75);
		this.dictionary_0[111U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[112U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[113U] = new GClass5.Delegate0(this.method_49);
		this.dictionary_0[114U] = new GClass5.Delegate0(this.method_85);
		this.dictionary_0[115U] = new GClass5.Delegate0(this.method_54);
		this.dictionary_0[116U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[117U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[118U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[119U] = new GClass5.Delegate0(this.method_100);
		this.dictionary_0[120U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[121U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[122U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[123U] = new GClass5.Delegate0(this.method_59);
		this.dictionary_0[124U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[125U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[126U] = new GClass5.Delegate0(this.method_36);
		this.dictionary_0[127U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[128U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[129U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[130U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[131U] = new GClass5.Delegate0(this.method_105);
		this.dictionary_0[132U] = new GClass5.Delegate0(this.method_52);
		this.dictionary_0[133U] = new GClass5.Delegate0(this.method_50);
		this.dictionary_0[134U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[135U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[136U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[137U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[138U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[139U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[140U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[141U] = new GClass5.Delegate0(this.method_50);
		this.dictionary_0[142U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[143U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[144U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[145U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[146U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[147U] = new GClass5.Delegate0(this.method_36);
		this.dictionary_0[148U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[149U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[150U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[151U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[152U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[153U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[154U] = new GClass5.Delegate0(this.method_98);
		this.dictionary_0[155U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[156U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[157U] = new GClass5.Delegate0(this.method_98);
		this.dictionary_0[158U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[159U] = new GClass5.Delegate0(this.method_53);
		this.dictionary_0[160U] = new GClass5.Delegate0(this.method_54);
		this.dictionary_0[161U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[162U] = new GClass5.Delegate0(this.method_75);
		this.dictionary_0[163U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[164U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[165U] = new GClass5.Delegate0(this.method_90);
		this.dictionary_0[166U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[167U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[168U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[169U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[170U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[171U] = new GClass5.Delegate0(this.method_57);
		this.dictionary_0[172U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[173U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[174U] = new GClass5.Delegate0(this.method_83);
		this.dictionary_0[175U] = new GClass5.Delegate0(this.method_77);
		this.dictionary_0[176U] = new GClass5.Delegate0(this.method_85);
		this.dictionary_0[177U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[178U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[179U] = new GClass5.Delegate0(this.method_54);
		this.dictionary_0[180U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[181U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[182U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[183U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[184U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[185U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[186U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[187U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[188U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[189U] = new GClass5.Delegate0(this.method_104);
		this.dictionary_0[190U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[191U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[192U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[193U] = new GClass5.Delegate0(this.method_82);
		this.dictionary_0[194U] = new GClass5.Delegate0(this.method_60);
		this.dictionary_0[195U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[196U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[197U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[198U] = new GClass5.Delegate0(this.method_105);
		this.dictionary_0[199U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[200U] = new GClass5.Delegate0(this.method_100);
		this.dictionary_0[201U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[202U] = new GClass5.Delegate0(this.method_82);
		this.dictionary_0[203U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[204U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[205U] = new GClass5.Delegate0(this.method_105);
		this.dictionary_0[206U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[207U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[208U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[209U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[210U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[211U] = new GClass5.Delegate0(this.method_100);
		this.dictionary_0[212U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[213U] = new GClass5.Delegate0(this.method_53);
		this.dictionary_0[214U] = new GClass5.Delegate0(this.method_49);
		this.dictionary_0[215U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[216U] = new GClass5.Delegate0(this.method_65);
		this.dictionary_0[217U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[218U] = new GClass5.Delegate0(this.method_85);
		this.dictionary_0[219U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[220U] = new GClass5.Delegate0(this.method_61);
		this.dictionary_0[221U] = new GClass5.Delegate0(this.method_65);
		this.dictionary_0[222U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[223U] = new GClass5.Delegate0(this.method_57);
		this.dictionary_0[224U] = new GClass5.Delegate0(this.method_60);
		this.dictionary_0[225U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[226U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[227U] = new GClass5.Delegate0(this.method_60);
		this.dictionary_0[228U] = new GClass5.Delegate0(this.method_67);
		this.dictionary_0[229U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[230U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[231U] = new GClass5.Delegate0(this.method_110);
		this.dictionary_0[232U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[233U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[234U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[235U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[236U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[237U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[238U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[239U] = new GClass5.Delegate0(this.method_98);
		this.dictionary_0[240U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[241U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[242U] = new GClass5.Delegate0(this.method_72);
		this.dictionary_0[243U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[244U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[245U] = new GClass5.Delegate0(this.method_38);
		this.dictionary_0[246U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[247U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[248U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[249U] = new GClass5.Delegate0(this.method_52);
		this.dictionary_0[250U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[251U] = new GClass5.Delegate0(this.method_54);
		this.dictionary_0[252U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[253U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[254U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[255U] = new GClass5.Delegate0(this.method_67);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000A640 File Offset: 0x00008840
	private void method_0(GClass5.Class0 class0_0)
	{
		this.stack_0.Push(class0_0.vmethod_4());
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000A660 File Offset: 0x00008860
	private GClass5.Class0 method_1()
	{
		return this.stack_0.Pop();
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000A67C File Offset: 0x0000887C
	private GClass5.Class0 method_2()
	{
		return this.stack_0.Peek();
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000A698 File Offset: 0x00008898
	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0++;
		return result;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0000A6DC File Offset: 0x000088DC
	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 2;
		return result;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0000A720 File Offset: 0x00008920
	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 4;
		return result;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000A764 File Offset: 0x00008964
	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 8;
		return result;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000A7A8 File Offset: 0x000089A8
	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(this.method_5()), 0);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000A7D0 File Offset: 0x000089D0
	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(this.method_6()), 0);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000A7F8 File Offset: 0x000089F8
	private void method_9()
	{
		byte byte_ = this.method_3();
		int num = this.method_5();
		int num2 = this.method_5();
		int int_ = this.method_5();
		int int_2 = this.method_5();
		GClass5.Class30 @class = null;
		for (int i = 0; i < this.list_1.Count; i++)
		{
			GClass5.Class30 class2 = this.list_1[i];
			if (class2.method_0() == num && class2.method_1() == num2)
			{
				@class = class2;
				break;
			}
		}
		if (@class == null)
		{
			bool flag = false;
			@class = new GClass5.Class30(num, num2);
			int j = 0;
			while (j < this.list_1.Count)
			{
				GClass5.Class30 class30_ = this.list_1[j];
				if (@class.method_2(class30_) >= 0)
				{
					j++;
				}
				else
				{
					this.list_1.Insert(j, @class);
					flag = true;
					IL_C6:
					if (!flag)
					{
						this.list_1.Add(@class);
						goto IL_D7;
					}
					goto IL_D7;
				}
			}
			goto IL_C6;
		}
		IL_D7:
		@class.method_3(byte_, int_, int_2);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000A8E8 File Offset: 0x00008AE8
	private TypeCode method_10(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		TypeCode typeCode2 = class0_1.vmethod_7();
		if (typeCode != TypeCode.Empty && typeCode != TypeCode.Object && typeCode2 != TypeCode.Empty)
		{
			if (typeCode2 != TypeCode.Object)
			{
				if (typeCode == TypeCode.UInt32)
				{
					if (typeCode2 != TypeCode.Int32)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
				else if (typeCode2 == TypeCode.UInt32)
				{
					if (typeCode != TypeCode.Int32)
					{
						return TypeCode.Empty;
					}
					return typeCode2;
				}
				else if (typeCode == TypeCode.UInt64)
				{
					if (typeCode2 != TypeCode.Int32 && typeCode2 != TypeCode.Int64)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
				else
				{
					if (typeCode2 != TypeCode.UInt64)
					{
						if (typeCode != TypeCode.Double)
						{
							if (typeCode2 != TypeCode.Double)
							{
								if (typeCode != TypeCode.Single)
								{
									if (typeCode2 != TypeCode.Single)
									{
										if (typeCode != TypeCode.Int64)
										{
											if (typeCode2 != TypeCode.Int64)
											{
												return TypeCode.Int32;
											}
										}
										return TypeCode.Int64;
									}
								}
								return TypeCode.Single;
							}
						}
						return TypeCode.Double;
					}
					if (typeCode != TypeCode.Int32 && typeCode != TypeCode.Int64)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
			}
		}
		return TypeCode.Empty;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000A988 File Offset: 0x00008B88
	private GClass5.Class0 method_11(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = this.method_10(class0_0, class0_1);
		switch (typeCode)
		{
		case TypeCode.Int32:
		{
			int int_;
			if (!bool_1)
			{
				int num = class0_0.E5B28EFF();
				int num2 = class0_1.E5B28EFF();
				int_ = (bool_0 ? checked(num + num2) : (num + num2));
			}
			else
			{
				uint num3 = class0_0.vmethod_11();
				uint num4 = class0_1.vmethod_11();
				int_ = (int)(bool_0 ? checked(num3 + num4) : (num3 + num4));
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.UInt32:
		{
			int value;
			if (bool_1)
			{
				uint num5 = class0_0.vmethod_11();
				uint num6 = class0_1.vmethod_11();
				value = (int)(bool_0 ? checked(num5 + num6) : (num5 + num6));
			}
			else
			{
				int num7 = class0_0.E5B28EFF();
				int num8 = class0_1.E5B28EFF();
				value = (bool_0 ? checked(num7 + num8) : (num7 + num8));
			}
			GClass5.Class8 @class = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value).ToPointer(), @class.method_0()), @class.method_0());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num9 = class0_0.vmethod_12();
				ulong num10 = class0_1.vmethod_12();
				long_ = (long)(bool_0 ? checked(num9 + num10) : (num9 + num10));
			}
			else
			{
				long num11 = class0_0.D264B6CE();
				long num12 = class0_1.D264B6CE();
				long_ = (bool_0 ? checked(num11 + num12) : (num11 + num12));
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.UInt64:
		{
			long value2;
			if (bool_1)
			{
				ulong num13 = class0_0.vmethod_12();
				ulong num14 = class0_1.vmethod_12();
				value2 = (long)(bool_0 ? checked(num13 + num14) : (num13 + num14));
			}
			else
			{
				long num15 = class0_0.D264B6CE();
				long num16 = class0_1.D264B6CE();
				value2 = (bool_0 ? checked(num15 + num16) : (num15 + num16));
			}
			GClass5.Class8 class2 = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value2).ToPointer(), class2.method_0()), class2.method_0());
		}
		case TypeCode.Single:
		{
			float num17 = (bool_1 ? class0_0.vmethod_5() : class0_0).BD4D4126();
			float num18 = (bool_1 ? class0_1.vmethod_5() : class0_1).BD4D4126();
			return new GClass5.Class4((!bool_0) ? (num17 + num18) : (num17 + num18));
		}
		case TypeCode.Double:
		{
			double num19 = (bool_1 ? class0_0.vmethod_5() : class0_0).vmethod_13();
			double num20 = ((!bool_1) ? class0_1 : class0_1.vmethod_5()).vmethod_13();
			return new GClass5.Class5(bool_0 ? (num19 + num20) : (num19 + num20));
		}
		default:
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000ABEC File Offset: 0x00008DEC
	private GClass5.Class0 method_12(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = this.method_10(class0_0, class0_1);
		switch (typeCode)
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class0_0.vmethod_11();
				uint num2 = class0_1.vmethod_11();
				int_ = (int)(bool_0 ? checked(num - num2) : (num - num2));
			}
			else
			{
				int num3 = class0_0.E5B28EFF();
				int num4 = class0_1.E5B28EFF();
				int_ = (bool_0 ? checked(num3 - num4) : (num3 - num4));
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.UInt32:
		{
			int value;
			if (!bool_1)
			{
				int num5 = class0_0.E5B28EFF();
				int num6 = class0_1.E5B28EFF();
				value = ((!bool_0) ? (num5 - num6) : checked(num5 - num6));
			}
			else
			{
				uint num7 = class0_0.vmethod_11();
				uint num8 = class0_1.vmethod_11();
				value = (int)(bool_0 ? checked(num7 - num8) : (num7 - num8));
			}
			GClass5.Class8 @class = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value).ToPointer(), @class.method_0()), @class.method_0());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (!bool_1)
			{
				long num9 = class0_0.D264B6CE();
				long num10 = class0_1.D264B6CE();
				long_ = (bool_0 ? checked(num9 - num10) : (num9 - num10));
			}
			else
			{
				ulong num11 = class0_0.vmethod_12();
				ulong num12 = class0_1.vmethod_12();
				long_ = (long)((!bool_0) ? (num11 - num12) : checked(num11 - num12));
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.UInt64:
		{
			long value2;
			if (bool_1)
			{
				ulong num13 = class0_0.vmethod_12();
				ulong num14 = class0_1.vmethod_12();
				value2 = (long)((!bool_0) ? (num13 - num14) : checked(num13 - num14));
			}
			else
			{
				long num15 = class0_0.D264B6CE();
				long num16 = class0_1.D264B6CE();
				value2 = (bool_0 ? checked(num15 - num16) : (num15 - num16));
			}
			GClass5.Class8 class2 = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value2).ToPointer(), class2.method_0()), class2.method_0());
		}
		case TypeCode.Single:
		{
			float num17 = (bool_1 ? class0_0.vmethod_5() : class0_0).BD4D4126();
			float num18 = (bool_1 ? class0_1.vmethod_5() : class0_1).BD4D4126();
			return new GClass5.Class4((!bool_0) ? (num17 - num18) : (num17 - num18));
		}
		case TypeCode.Double:
		{
			double num19 = (bool_1 ? class0_0.vmethod_5() : class0_0).vmethod_13();
			double num20 = (bool_1 ? class0_1.vmethod_5() : class0_1).vmethod_13();
			return new GClass5.Class5((!bool_0) ? (num19 - num20) : (num19 - num20));
		}
		default:
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000AE50 File Offset: 0x00009050
	private GClass5.Class0 method_13(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, bool bool_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class0_0.vmethod_11();
				uint num2 = class0_1.vmethod_11();
				int_ = (int)((!bool_0) ? (num * num2) : checked(num * num2));
			}
			else
			{
				int num3 = class0_0.E5B28EFF();
				int num4 = class0_1.E5B28EFF();
				int_ = ((!bool_0) ? (num3 * num4) : checked(num3 * num4));
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num5 = class0_0.vmethod_12();
				ulong num6 = class0_1.vmethod_12();
				long_ = (long)(bool_0 ? checked(num5 * num6) : (num5 * num6));
			}
			else
			{
				long num7 = class0_0.D264B6CE();
				long num8 = class0_1.D264B6CE();
				long_ = (bool_0 ? checked(num7 * num8) : (num7 * num8));
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.Single:
		{
			float num9 = (bool_1 ? class0_0.vmethod_5() : class0_0).BD4D4126();
			float num10 = (bool_1 ? class0_1.vmethod_5() : class0_1).BD4D4126();
			return new GClass5.Class5((double)(bool_0 ? (num9 * num10) : (num9 * num10)));
		}
		case TypeCode.Double:
		{
			double num11 = (bool_1 ? class0_0.vmethod_5() : class0_0).vmethod_13();
			double num12 = (bool_1 ? class0_1.vmethod_5() : class0_1).vmethod_13();
			return new GClass5.Class5(bool_0 ? (num11 * num12) : (num11 * num12));
		}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000AFA8 File Offset: 0x000091A8
	private GClass5.Class0 method_14(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_0)
			{
				int num = (int)class0_0.vmethod_11();
				uint num2 = class0_1.vmethod_11();
				int_ = num / (int)num2;
			}
			else
			{
				int num3 = class0_0.E5B28EFF();
				int num4 = class0_1.E5B28EFF();
				int_ = num3 / num4;
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_0)
			{
				long num5 = (long)class0_0.vmethod_12();
				ulong num6 = class0_1.vmethod_12();
				long_ = num5 / (long)num6;
			}
			else
			{
				long num7 = class0_0.D264B6CE();
				long num8 = class0_1.D264B6CE();
				long_ = num7 / num8;
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.Single:
		{
			float num9 = (bool_0 ? class0_0.vmethod_5() : class0_0).BD4D4126();
			float num10 = (bool_0 ? class0_1.vmethod_5() : class0_1).BD4D4126();
			return new GClass5.Class4(num9 / num10);
		}
		case TypeCode.Double:
		{
			double num11 = (bool_0 ? class0_0.vmethod_5() : class0_0).vmethod_13();
			double num12 = (bool_0 ? class0_1.vmethod_5() : class0_1).vmethod_13();
			return new GClass5.Class5(num11 / num12);
		}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0000B0A4 File Offset: 0x000092A4
	private GClass5.Class0 method_15(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode != TypeCode.Int32)
		{
			if (typeCode != TypeCode.Int64)
			{
				throw new InvalidOperationException();
			}
			if (!bool_0)
			{
				long num = class0_0.D264B6CE();
				long num2 = class0_1.D264B6CE();
				return new GClass5.Class3(num % num2);
			}
			long num3 = (long)class0_0.vmethod_12();
			ulong num4 = class0_1.vmethod_12();
			return new GClass5.Class3(num3 % (long)num4);
		}
		else
		{
			if (bool_0)
			{
				int num5 = (int)class0_0.vmethod_11();
				uint num6 = class0_1.vmethod_11();
				return new GClass5.Class2(num5 % (int)num6);
			}
			int num7 = class0_0.E5B28EFF();
			int num8 = class0_1.E5B28EFF();
			return new GClass5.Class2(num7 % num8);
		}
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0000B128 File Offset: 0x00009328
	private GClass5.Class0 method_16(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int num = class0_0.E5B28EFF();
			int num2 = class0_1.E5B28EFF();
			return new GClass5.Class2(num ^ num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class0_0.D264B6CE();
			long num4 = class0_1.D264B6CE();
			return new GClass5.Class3(num3 ^ num4);
		}
		case TypeCode.Single:
			return new GClass5.Class4((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass5.Class5((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000B1CC File Offset: 0x000093CC
	private GClass5.Class0 method_17(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int num = class0_0.E5B28EFF();
			int num2 = class0_1.E5B28EFF();
			return new GClass5.Class2(num | num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class0_0.D264B6CE();
			long num4 = class0_1.D264B6CE();
			return new GClass5.Class3(num3 | num4);
		}
		case TypeCode.Single:
			return new GClass5.Class4((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass5.Class5((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000B270 File Offset: 0x00009470
	private GClass5.Class0 method_18(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int num = class0_0.E5B28EFF();
			int num2 = class0_1.E5B28EFF();
			return new GClass5.Class2(num & num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class0_0.D264B6CE();
			long num4 = class0_1.D264B6CE();
			return new GClass5.Class3(num3 & num4);
		}
		case TypeCode.Single:
			return new GClass5.Class4((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass5.Class5((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0000B314 File Offset: 0x00009514
	private int method_19(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, int int_1)
	{
		int num = int_1;
		TypeCode typeCode = class0_0.vmethod_7();
		TypeCode typeCode2 = class0_1.vmethod_7();
		if (typeCode != TypeCode.Object)
		{
			if (typeCode2 != TypeCode.Object)
			{
				if (typeCode != TypeCode.Double)
				{
					if (typeCode2 != TypeCode.Double)
					{
						if (typeCode != TypeCode.Single)
						{
							if (typeCode2 != TypeCode.Single)
							{
								if (typeCode != TypeCode.Int64)
								{
									if (typeCode2 != TypeCode.Int64)
									{
										if (typeCode == TypeCode.Int32 || typeCode2 == TypeCode.Int32)
										{
											num = (bool_0 ? class0_0.vmethod_11().CompareTo(class0_1.vmethod_11()) : class0_0.E5B28EFF().CompareTo(class0_1.E5B28EFF()));
											goto IL_115;
										}
										goto IL_115;
									}
								}
								num = (bool_0 ? class0_0.vmethod_12().CompareTo(class0_1.vmethod_12()) : class0_0.D264B6CE().CompareTo(class0_1.D264B6CE()));
								goto IL_115;
							}
						}
						num = class0_0.BD4D4126().CompareTo(class0_1.BD4D4126());
						goto IL_115;
					}
				}
				num = class0_0.vmethod_13().CompareTo(class0_1.vmethod_13());
				goto IL_115;
			}
		}
		object obj = class0_0.vmethod_1();
		object obj2 = class0_1.vmethod_1();
		if (obj == obj2)
		{
			return 0;
		}
		if (obj2 == null)
		{
			return 1;
		}
		if (obj == null)
		{
			return -1;
		}
		IL_115:
		if (num >= 0)
		{
			if (num > 0)
			{
				num = 1;
			}
		}
		else
		{
			num = -1;
		}
		return num;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000B44C File Offset: 0x0000964C
	private GClass5.Class0 method_20(GClass5.Class0 class0_0)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode == TypeCode.Int32)
		{
			return new GClass5.Class2(~class0_0.E5B28EFF());
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		return new GClass5.Class3(~class0_0.D264B6CE());
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0000B48C File Offset: 0x0000968C
	private GClass5.Class0 method_21(GClass5.Class0 class0_0)
	{
		switch (class0_0.vmethod_7())
		{
		case TypeCode.Int32:
			return new GClass5.Class2(-class0_0.E5B28EFF());
		case TypeCode.Int64:
			return new GClass5.Class3(-class0_0.D264B6CE());
		case TypeCode.Single:
			return new GClass5.Class4(-class0_0.BD4D4126());
		case TypeCode.Double:
			return new GClass5.Class5(-class0_0.vmethod_13());
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000B4FC File Offset: 0x000096FC
	private GClass5.Class0 method_22(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode != TypeCode.Int32)
		{
			if (typeCode != TypeCode.Int64)
			{
				throw new InvalidOperationException();
			}
			if (bool_0)
			{
				ulong num = class0_0.vmethod_12();
				int num2 = class0_1.E5B28EFF();
				return new GClass5.Class3(num >> (num2 & 63));
			}
			long num3 = class0_0.D264B6CE();
			int num4 = class0_1.E5B28EFF();
			return new GClass5.Class3(num3 >> (num4 & 63));
		}
		else
		{
			if (bool_0)
			{
				uint num5 = class0_0.vmethod_11();
				int num6 = class0_1.E5B28EFF();
				return new GClass5.Class2(num5 >> (num6 & 31));
			}
			int num7 = class0_0.E5B28EFF();
			int num8 = class0_1.E5B28EFF();
			return new GClass5.Class2(num7 >> (num8 & 31));
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x0000B58C File Offset: 0x0000978C
	private GClass5.Class0 method_23(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode == TypeCode.Int32)
		{
			int num = class0_0.E5B28EFF();
			int num2 = class0_1.E5B28EFF();
			return new GClass5.Class2(num << num2);
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		long num3 = class0_0.D264B6CE();
		int num4 = class0_1.E5B28EFF();
		return new GClass5.Class3(num3 << num4);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000B5E0 File Offset: 0x000097E0
	private GClass5.Class0 method_24(object object_0, Type type_1)
	{
		GClass5.Class0 @class = object_0 as GClass5.Class0;
		if (type_1.IsEnum)
		{
			if (@class != null)
			{
				object_0 = @class.vmethod_1();
			}
			if (object_0 != null && !(object_0 is Enum))
			{
				object_0 = Enum.ToObject(type_1, object_0);
			}
			return new GClass5.Class20((object_0 == null) ? ((Enum)Activator.CreateInstance(type_1)) : ((Enum)object_0));
		}
		switch (Type.GetTypeCode(type_1))
		{
		case TypeCode.Boolean:
			return new GClass5.Class23((@class != null) ? @class.vmethod_8() : Convert.ToBoolean(object_0));
		case TypeCode.Char:
			return new GClass5.Class24((@class == null) ? Convert.ToChar(object_0) : @class.FBD6E971());
		case TypeCode.SByte:
			return new GClass5.Class26((@class == null) ? Convert.ToSByte(object_0) : @class.vmethod_9());
		case TypeCode.Byte:
			return new GClass5.Class25((@class == null) ? Convert.ToByte(object_0) : @class.vmethod_10());
		case TypeCode.Int16:
			return new GClass5.Class21((@class != null) ? @class.E1099AD6() : Convert.ToInt16(object_0));
		case TypeCode.UInt16:
			return new GClass5.Class22((@class != null) ? @class.DA16486C() : Convert.ToUInt16(object_0));
		case TypeCode.Int32:
			return new GClass5.Class2((@class == null) ? Convert.ToInt32(object_0) : @class.E5B28EFF());
		case TypeCode.UInt32:
			return new GClass5.Class27((@class == null) ? Convert.ToUInt32(object_0) : @class.vmethod_11());
		case TypeCode.Int64:
			return new GClass5.Class3((@class == null) ? Convert.ToInt64(object_0) : @class.D264B6CE());
		case TypeCode.UInt64:
			return new GClass5.Class28((@class != null) ? @class.vmethod_12() : Convert.ToUInt64(object_0));
		case TypeCode.Single:
			return new GClass5.Class4((@class != null) ? @class.BD4D4126() : Convert.ToSingle(object_0));
		case TypeCode.Double:
			return new GClass5.Class5((@class == null) ? Convert.ToDouble(object_0) : @class.vmethod_13());
		case TypeCode.String:
			return new GClass5.Class6((@class == null) ? ((string)object_0) : @class.ToString());
		}
		if (type_1 == typeof(IntPtr))
		{
			if (@class == null)
			{
				return new GClass5.Class18((object_0 == null) ? IntPtr.Zero : ((IntPtr)object_0));
			}
			return new GClass5.Class18(@class.BF5057B5());
		}
		else if (type_1 == typeof(UIntPtr))
		{
			if (@class != null)
			{
				return new GClass5.Class19(@class.vmethod_14());
			}
			return new GClass5.Class19((object_0 != null) ? ((UIntPtr)object_0) : UIntPtr.Zero);
		}
		else if (!type_1.IsValueType)
		{
			if (type_1.IsArray)
			{
				return new GClass5.Class10((@class != null) ? ((Array)@class.vmethod_1()) : ((Array)object_0));
			}
			if (!type_1.IsPointer)
			{
				return new GClass5.Class7((@class == null) ? object_0 : @class.vmethod_1());
			}
			if (@class != null)
			{
				return new GClass5.Class8(Pointer.Box(Pointer.Unbox(@class.vmethod_1()), type_1), type_1);
			}
			return new GClass5.Class8(Pointer.Box((object_0 == null) ? null : Pointer.Unbox(object_0), type_1), type_1);
		}
		else
		{
			if (@class != null)
			{
				return new GClass5.Class9(@class.vmethod_1());
			}
			return new GClass5.Class9((object_0 == null) ? Activator.CreateInstance(type_1) : object_0);
		}
	}

	// Token: 0x06000123 RID: 291 RVA: 0x0000B8B8 File Offset: 0x00009AB8
	private string method_25(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		string result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				string text = this.module_0.ResolveString(int_1);
				GClass5.dictionary_1.Add(int_1, text);
				result = text;
			}
		}
		return result;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0000B924 File Offset: 0x00009B24
	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		Type result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (Type)obj2;
			}
			else
			{
				Type type = this.module_0.ResolveType(int_1);
				GClass5.dictionary_1.Add(int_1, type);
				result = type;
			}
		}
		return result;
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0000B990 File Offset: 0x00009B90
	private MethodBase method_27(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		MethodBase result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else
			{
				MethodBase methodBase = this.module_0.ResolveMethod(int_1);
				GClass5.dictionary_1.Add(int_1, methodBase);
				result = methodBase;
			}
		}
		return result;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0000B9FC File Offset: 0x00009BFC
	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		FieldInfo result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (FieldInfo)obj2;
			}
			else
			{
				FieldInfo fieldInfo = this.module_0.ResolveField(int_1);
				GClass5.dictionary_1.Add(int_1, fieldInfo);
				result = fieldInfo;
			}
		}
		return result;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0000BA68 File Offset: 0x00009C68
	private GClass5.Class0 method_29(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, GClass5.Class0> dictionary = new Dictionary<int, GClass5.Class0>();
		object[] array = new object[parameters.Length];
		for (int i = parameters.Length - 1; i >= 0; i--)
		{
			GClass5.Class0 @class = this.method_1();
			if (@class.vmethod_3())
			{
				dictionary[i] = @class;
			}
			array[i] = this.method_24(@class, parameters[i].ParameterType).vmethod_1();
		}
		object object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
		foreach (KeyValuePair<int, GClass5.Class0> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
		}
		return this.method_24(object_, methodBase_0.DeclaringType);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x0000BB44 File Offset: 0x00009D44
	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType.IsGenericType && declaringType.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
			{
				object_1 = (object_0 != null);
			}
			else if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					throw new InvalidOperationException();
				}
				object_1 = object_0;
			}
			else if (methodBase_0.Name.Equals("GetValueOrDefault", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_1 = object_0;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0000BBEC File Offset: 0x00009DEC
	private GClass5.Class0 method_31(MethodBase methodBase_0, bool bool_0)
	{
		/*
An exception occurred when decompiling this method (06000129)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GClass5/Class0 GClass5::method_31(System.Reflection.MethodBase,System.Boolean)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0000C040 File Offset: 0x0000A240
	private GClass5.Class0 method_32(int int_1, bool bool_0)
	{
		int num = this.int_0;
		this.int_0 = int_1;
		ushort num2 = (ushort)this.method_4();
		Dictionary<int, GClass5.Class0> dictionary = new Dictionary<int, GClass5.Class0>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[(int)num2];
			for (int i = (int)(num2 - 1); i >= 0; i--)
			{
				GClass5.Class0 @class = this.method_1();
				if (@class.vmethod_3())
				{
					dictionary[i] = @class;
				}
				array[i] = this.method_24(@class, this.method_26(this.method_5())).vmethod_1();
			}
		}
		int num3 = this.method_5();
		int_1 = this.int_0;
		this.int_0 = num;
		if (bool_0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		object object_ = new GClass5().method_112(array, int_1);
		foreach (KeyValuePair<int, GClass5.Class0> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
		}
		if (num3 != 0)
		{
			Type type = this.method_26(num3);
			if (type != typeof(void))
			{
				return this.method_24(object_, type);
			}
		}
		return null;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0000C178 File Offset: 0x0000A378
	private bool method_33(object object_0, Type type_1)
	{
		if (object_0 == null)
		{
			return true;
		}
		Type type = object_0.GetType();
		return type == type_1 || type_1.IsAssignableFrom(type);
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
	private void method_34(Exception exception_1)
	{
		this.stack_0.Clear();
		this.stack_2.Clear();
		if (this.class29_0 == null)
		{
			this.exception_0 = exception_1;
		}
		while (this.stack_1.Count != 0)
		{
			List<GClass5.Class29> list = this.stack_1.Peek().method_4();
			int num = (this.class29_0 == null) ? 0 : (list.IndexOf(this.class29_0) + 1);
			this.class29_0 = null;
			for (int i = num; i < list.Count; i++)
			{
				GClass5.Class29 @class = list[i];
				byte b = @class.method_0();
				if (b != 0)
				{
					if (b == 1)
					{
						this.class29_0 = @class;
						this.stack_0.Push(new GClass5.Class7(this.exception_0));
						this.int_0 = @class.method_2();
						return;
					}
				}
				else
				{
					Type type = exception_1.GetType();
					Type type2 = this.method_26(@class.method_2());
					if (type == type2 || type.IsSubclassOf(type2))
					{
						this.stack_1.Pop();
						this.stack_0.Push(new GClass5.Class7(this.exception_0));
						this.int_0 = @class.method_1();
						return;
					}
				}
			}
			this.stack_1.Pop();
			for (int j = list.Count; j > 0; j--)
			{
				GClass5.Class29 class2 = list[j - 1];
				if (class2.method_0() == 2 || class2.method_0() == 4)
				{
					this.stack_2.Push(class2.method_1());
				}
			}
			if (this.stack_2.Count != 0)
			{
				this.int_0 = this.stack_2.Pop();
				return;
			}
		}
		throw exception_1;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000C348 File Offset: 0x0000A548
	private void method_35()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		GClass5.Class0 class2 = this.method_24(this.method_1().vmethod_1(), type_);
		if (@class.vmethod_3())
		{
			class2 = new GClass5.Class13(class2, @class);
		}
		this.list_0.Add(class2);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
	private void method_36()
	{
		int num = this.method_1().E5B28EFF();
		foreach (GClass5.Class30 @class in this.list_1)
		{
			if (@class.method_0() == num)
			{
				this.stack_1.Push(@class);
			}
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0000C410 File Offset: 0x0000A610
	private void method_37()
	{
		this.method_0(new GClass5.Class2(this.method_5()));
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000C430 File Offset: 0x0000A630
	private void method_38()
	{
		this.method_0(new GClass5.Class3(this.method_6()));
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000C454 File Offset: 0x0000A654
	private void method_39()
	{
		this.method_0(new GClass5.Class4(this.method_7()));
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000C478 File Offset: 0x0000A678
	private void method_40()
	{
		this.method_0(new GClass5.Class5(this.method_8()));
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0000C49C File Offset: 0x0000A69C
	private void method_41()
	{
		this.method_0(new GClass5.Class7(null));
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
	private void method_42()
	{
		this.method_0(new GClass5.Class6(this.method_25(this.method_1().E5B28EFF())));
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
	private void method_43()
	{
		this.method_0(this.method_2().vmethod_0());
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000C508 File Offset: 0x0000A708
	private void method_44()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_11(class0_, class0_2, false, false));
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000C534 File Offset: 0x0000A734
	private void method_45()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_11(class0_, class0_2, true, false));
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0000C580 File Offset: 0x0000A780
	private void method_46()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_11(class0_, class0_2, true, true));
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000C5AC File Offset: 0x0000A7AC
	private void method_47()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_12(class0_2, class0_, false, false));
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
	private void method_48()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_12(class0_2, class0_, true, false));
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000C604 File Offset: 0x0000A804
	private void method_49()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_12(class0_2, class0_, true, true));
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0000C650 File Offset: 0x0000A850
	private void method_50()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_13(class0_2, class0_, false, false));
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0000C69C File Offset: 0x0000A89C
	private void method_51()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_13(class0_2, class0_, true, false));
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
	private void method_52()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_13(class0_2, class0_, true, true));
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
	private void method_53()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_14(class0_2, class0_, false));
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000C720 File Offset: 0x0000A920
	private void method_54()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_14(class0_2, class0_, true));
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0000C74C File Offset: 0x0000A94C
	private void method_55()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_15(class0_2, class0_, false));
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000C794 File Offset: 0x0000A994
	private void method_56()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_15(class0_2, class0_, true));
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0000C7DC File Offset: 0x0000A9DC
	private void method_57()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_18(class0_2, class0_));
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000C808 File Offset: 0x0000AA08
	private void method_58()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_17(class0_2, class0_));
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0000C834 File Offset: 0x0000AA34
	private void method_59()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_16(class0_2, class0_));
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0000C878 File Offset: 0x0000AA78
	private void method_60()
	{
		GClass5.Class0 class0_ = this.method_1();
		this.method_0(this.method_20(class0_));
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0000C89C File Offset: 0x0000AA9C
	private void method_61()
	{
		GClass5.Class0 class0_ = this.method_1();
		this.method_0(this.method_21(class0_));
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000C8CC File Offset: 0x0000AACC
	private void method_62()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_22(class0_2, class0_, false));
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
	private void method_63()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_22(class0_2, class0_, true));
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0000C924 File Offset: 0x0000AB24
	private void method_64()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_23(class0_2, class0_));
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000C968 File Offset: 0x0000AB68
	private void method_65()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		this.method_0(this.method_24(this.method_1(), type_));
	}

	// Token: 0x0600014C RID: 332 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
	private void method_66()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		this.method_0(this.method_24(this.method_1().C28A04F7(type_, false), type_));
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0000CA08 File Offset: 0x0000AC08
	private void method_67()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		this.method_0(this.method_24(this.method_1().C28A04F7(type_, true), type_));
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0000CA44 File Offset: 0x0000AC44
	private void method_68()
	{
		this.method_0(new GClass5.Class2(Marshal.SizeOf(this.method_26(this.method_5()))));
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0000CA78 File Offset: 0x0000AC78
	private void method_69()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		if (!@class.vmethod_3())
		{
			if (!(@class.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			@class = new GClass5.Class16(new IntPtr(Pointer.Unbox(@class.vmethod_1())), type_);
		}
		this.method_0(this.method_24(@class, type_));
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
	private void method_70()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().E5B28EFF());
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_0(this.method_24(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0000CB38 File Offset: 0x0000AD38
	private void method_71()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().E5B28EFF());
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_0(new GClass5.Class14(fieldInfo, obj));
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000CB84 File Offset: 0x0000AD84
	private void method_72()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().E5B28EFF());
		GClass5.Class0 object_ = this.method_1();
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		fieldInfo.SetValue(obj, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
	private void method_73()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().E5B28EFF());
		GClass5.Class0 object_ = this.method_1();
		fieldInfo.SetValue(null, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0000CC20 File Offset: 0x0000AE20
	private void method_74()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 object_ = this.method_1();
		GClass5.Class0 @class = this.method_1();
		if (!@class.vmethod_3())
		{
			if (!(@class.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			@class = new GClass5.Class16(new IntPtr(Pointer.Unbox(@class.vmethod_1())), type_);
		}
		@class.vmethod_2(this.method_24(object_, type_).vmethod_1());
	}

	// Token: 0x06000155 RID: 341 RVA: 0x0000CC94 File Offset: 0x0000AE94
	private void method_75()
	{
		this.method_0(this.list_0[(int)((ushort)this.method_4())].vmethod_0());
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
	private void method_76()
	{
		this.method_0(new GClass5.Class12(this.list_0[(int)((ushort)this.method_4())]));
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
	private void method_77()
	{
		GClass5.Class0 object_ = this.method_1();
		GClass5.Class0 @class = this.list_0[(int)((ushort)this.method_4())];
		@class.vmethod_2(this.method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000CD50 File Offset: 0x0000AF50
	private void method_78()
	{
		this.type_0 = this.method_26(this.method_1().E5B28EFF());
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0000CD80 File Offset: 0x0000AF80
	private void method_79()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_31(methodBase_, false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0000CDB4 File Offset: 0x0000AFB4
	private void method_80()
	{
		MethodBase methodBase = this.method_27(this.method_1().E5B28EFF());
		if (this.type_0 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.type_0.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.type_0 = null;
		}
		GClass5.Class0 @class = this.method_31(methodBase, true);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000CE58 File Offset: 0x0000B058
	private void method_81()
	{
		MethodBase methodBase = this.method_1().vmethod_1() as MethodBase;
		if (methodBase == null)
		{
			throw new ArgumentException();
		}
		GClass5.Class0 @class = this.method_31(methodBase, false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0000CE94 File Offset: 0x0000B094
	private void method_82()
	{
		GClass5.Class0 @class = this.method_32(this.method_1().E5B28EFF(), false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x0600015D RID: 349 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
	private void method_83()
	{
		GClass5.Class0 @class = this.method_32(this.method_1().E5B28EFF(), true);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0000CEEC File Offset: 0x0000B0EC
	private void method_84()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_29(methodBase_);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0000CF20 File Offset: 0x0000B120
	private void method_85()
	{
		Type type = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			@class.vmethod_2(null);
			return;
		}
		if (type.IsValueType)
		{
			foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
			{
				fieldInfo.SetValue(@class.vmethod_1(), fieldInfo.FieldType.IsValueType ? Activator.CreateInstance(fieldInfo.FieldType) : null);
			}
			return;
		}
		@class.vmethod_2(null);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
	private void method_86()
	{
		int int_ = this.method_1().E5B28EFF();
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(new GClass5.Class2(this.method_19(class0_2, class0_, false, int_)));
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0000D028 File Offset: 0x0000B228
	private void method_87()
	{
		int int_ = this.method_1().E5B28EFF();
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(new GClass5.Class2(this.method_19(class0_2, class0_, true, int_)));
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0000D064 File Offset: 0x0000B264
	private void method_88()
	{
		Type elementType = this.method_26(this.method_1().E5B28EFF());
		this.method_0(new GClass5.Class10(Array.CreateInstance(elementType, this.method_1().E5B28EFF())));
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
	private void method_89()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 object_ = this.method_1();
		GClass5.Class0 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		array.SetValue(this.method_24(this.method_24(object_, type_), array.GetType().GetElementType()).vmethod_1(), @class.E5B28EFF());
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0000D12C File Offset: 0x0000B32C
	private void method_90()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(this.method_24(array.GetValue(@class.E5B28EFF()), type_));
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0000D188 File Offset: 0x0000B388
	private void method_91()
	{
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(new GClass5.Class2(array.Length));
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0000D1C0 File Offset: 0x0000B3C0
	private void method_92()
	{
		GClass5.Class0 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(new GClass5.Class15(array, @class.E5B28EFF()));
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000D200 File Offset: 0x0000B400
	private void method_93()
	{
		this.method_0(new GClass5.Class17(this.method_27(this.method_1().E5B28EFF())));
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000D234 File Offset: 0x0000B434
	private void method_94()
	{
		MethodBase methodBase = this.method_27(this.method_1().E5B28EFF());
		Type type = this.method_1().vmethod_1().GetType();
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		int num = 0;
		foreach (ParameterInfo parameterInfo in parameters)
		{
			array[num++] = parameterInfo.ParameterType;
		}
		while (type != null)
		{
			if (type == declaringType)
			{
				break;
			}
			MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase = method;
				break;
			}
			type = type.BaseType;
		}
		this.method_0(new GClass5.Class17(methodBase));
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
	private void method_95()
	{
		this.int_0 = this.method_1().E5B28EFF();
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0000D31C File Offset: 0x0000B51C
	private void method_96()
	{
		this.method_1();
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0000D330 File Offset: 0x0000B530
	private void method_97()
	{
		this.stack_2.Push(this.method_1().E5B28EFF());
		int num = this.method_1().E5B28EFF();
		while (this.stack_1.Count != 0 && num > this.stack_1.Peek().method_1())
		{
			List<GClass5.Class29> list = this.stack_1.Pop().method_4();
			for (int i = list.Count; i > 0; i--)
			{
				GClass5.Class29 @class = list[i - 1];
				if (@class.method_0() == 2)
				{
					this.stack_2.Push(@class.method_1());
				}
			}
		}
		this.exception_0 = null;
		this.stack_0.Clear();
		this.int_0 = this.stack_2.Pop();
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0000D3F0 File Offset: 0x0000B5F0
	private void method_98()
	{
		if (this.exception_0 == null)
		{
			this.int_0 = this.stack_2.Pop();
			return;
		}
		this.method_34(this.exception_0);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0000D424 File Offset: 0x0000B624
	private void method_99()
	{
		if (this.method_1().E5B28EFF() != 0)
		{
			this.stack_1.Pop();
			this.stack_0.Push(new GClass5.Class7(this.exception_0));
			this.int_0 = this.class29_0.method_1();
			this.class29_0 = null;
			return;
		}
		this.method_34(this.exception_0);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0000D488 File Offset: 0x0000B688
	private void method_100()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		this.method_0(new GClass5.Class7(this.method_24(this.method_1(), type_).vmethod_1()));
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
	private void method_101()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		this.method_0(this.method_24(this.method_1().vmethod_1(), type_));
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0000D510 File Offset: 0x0000B710
	private void method_102()
	{
		Type type = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		object obj = @class.vmethod_1();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		if (!type.IsValueType)
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				this.method_0(new GClass5.Class23((bool)obj));
				return;
			case TypeCode.Char:
				this.method_0(new GClass5.Class24((char)obj));
				return;
			case TypeCode.SByte:
				this.method_0(new GClass5.Class26((sbyte)obj));
				return;
			case TypeCode.Byte:
				this.method_0(new GClass5.Class25((byte)obj));
				return;
			case TypeCode.Int16:
				this.method_0(new GClass5.Class21((short)obj));
				return;
			case TypeCode.UInt16:
				this.method_0(new GClass5.Class22((ushort)obj));
				return;
			case TypeCode.Int32:
				this.method_0(new GClass5.Class2((int)obj));
				return;
			case TypeCode.UInt32:
				this.method_0(new GClass5.Class27((uint)obj));
				return;
			case TypeCode.Int64:
				this.method_0(new GClass5.Class3((long)obj));
				return;
			case TypeCode.UInt64:
				this.method_0(new GClass5.Class28((ulong)obj));
				return;
			case TypeCode.Single:
				this.method_0(new GClass5.Class4((float)obj));
				return;
			case TypeCode.Double:
				this.method_0(new GClass5.Class5((double)obj));
				return;
			default:
				throw new InvalidCastException();
			}
		}
		else
		{
			if (type != obj.GetType())
			{
				throw new InvalidCastException();
			}
			this.method_0(@class);
			return;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000D688 File Offset: 0x0000B888
	private void method_103()
	{
		this.method_0(new GClass5.Class2(Marshal.ReadInt32(new IntPtr(this.long_0 + (long)((ulong)this.method_1().vmethod_11())))));
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
	private void method_104()
	{
		int num = this.method_1().E5B28EFF();
		int num2 = num >> 24;
		if (num2 <= 10)
		{
			switch (num2)
			{
			case 1:
			case 2:
				goto IL_E9;
			case 3:
			case 5:
				break;
			case 4:
				this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveFieldHandle(num)));
				return;
			case 6:
				goto IL_C4;
			default:
				if (num2 == 10)
				{
					try
					{
						this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveFieldHandle(num)));
					}
					catch
					{
						this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
					}
					return;
				}
				break;
			}
		}
		else
		{
			if (num2 == 27)
			{
				goto IL_E9;
			}
			if (num2 == 43)
			{
				goto IL_C4;
			}
		}
		throw new InvalidOperationException();
		IL_C4:
		this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
		return;
		IL_E9:
		this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveTypeHandle(num)));
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
	private void method_105()
	{
		Exception ex = this.method_1().vmethod_1() as Exception;
		if (ex == null)
		{
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000D81C File Offset: 0x0000BA1C
	private void method_106()
	{
		if (this.exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw this.exception_0;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0000D840 File Offset: 0x0000BA40
	private void method_107()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		if (!this.method_33(@class.vmethod_1(), type_))
		{
			throw new InvalidCastException();
		}
		this.method_0(@class);
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0000D884 File Offset: 0x0000BA84
	private void method_108()
	{
		Type type_ = this.method_26(this.method_1().E5B28EFF());
		GClass5.Class0 @class = this.method_1();
		if (!this.method_33(@class.vmethod_1(), type_))
		{
			@class = new GClass5.Class7(null);
		}
		this.method_0(@class);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
	private void method_109()
	{
		GClass5.Class0 @class = this.method_1();
		if (@class.vmethod_1() is IConvertible)
		{
			double d = @class.vmethod_13();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new OverflowException();
			}
		}
		else
		{
			@class = new GClass5.Class5(double.NaN);
		}
		this.method_0(@class);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000D91C File Offset: 0x0000BB1C
	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(this.method_1().BF5057B5());
		this.list_2.Add(item);
		this.method_0(new GClass5.Class7(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000D978 File Offset: 0x0000BB78
	private void method_111()
	{
		using (List<IntPtr>.Enumerator enumerator = this.list_2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Marshal.FreeHGlobal(enumerator.Current);
			}
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
	public object method_112(object[] object_0, int int_1)
	{
		this.int_0 = int_1;
		this.method_0(new GClass5.Class10(object_0));
		object result;
		try
		{
			for (;;)
			{
				try
				{
					this.dictionary_0[(uint)this.method_3()]();
					if (this.int_0 != 0)
					{
						continue;
					}
				}
				catch (Exception exception_)
				{
					this.method_34(exception_);
					continue;
				}
				break;
			}
			result = this.method_1().vmethod_1();
		}
		finally
		{
			this.method_111();
		}
		return result;
	}

	// Token: 0x040002ED RID: 749
	private readonly Dictionary<uint, GClass5.Delegate0> dictionary_0 = new Dictionary<uint, GClass5.Delegate0>();

	// Token: 0x040002EE RID: 750
	private readonly Module module_0 = typeof(GClass5).Module;

	// Token: 0x040002EF RID: 751
	private readonly long long_0;

	// Token: 0x040002F0 RID: 752
	private int int_0;

	// Token: 0x040002F1 RID: 753
	private Type type_0;

	// Token: 0x040002F2 RID: 754
	private Stack<GClass5.Class1> stack_0 = new Stack<GClass5.Class1>();

	// Token: 0x040002F3 RID: 755
	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	// Token: 0x040002F4 RID: 756
	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	// Token: 0x040002F5 RID: 757
	private List<GClass5.Class0> list_0 = new List<GClass5.Class0>();

	// Token: 0x040002F6 RID: 758
	private List<GClass5.Class30> list_1 = new List<GClass5.Class30>();

	// Token: 0x040002F7 RID: 759
	private Stack<GClass5.Class30> stack_1 = new Stack<GClass5.Class30>();

	// Token: 0x040002F8 RID: 760
	private Stack<int> stack_2 = new Stack<int>();

	// Token: 0x040002F9 RID: 761
	private Exception exception_0;

	// Token: 0x040002FA RID: 762
	private GClass5.Class29 class29_0;

	// Token: 0x040002FB RID: 763
	private List<IntPtr> list_2 = new List<IntPtr>();

	// Token: 0x0200002C RID: 44
	private abstract class Class0
	{
		// Token: 0x060001A3 RID: 419
		public abstract GClass5.Class0 vmethod_0();

		// Token: 0x060001A4 RID: 420
		public abstract object vmethod_1();

		// Token: 0x060001A5 RID: 421
		public abstract void vmethod_2(object object_0);

		// Token: 0x060001A6 RID: 422 RVA: 0x0000E53C File Offset: 0x0000C73C
		public virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000E550 File Offset: 0x0000C750
		public virtual GClass5.Class1 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000E564 File Offset: 0x0000C764
		public virtual GClass5.Class0 vmethod_5()
		{
			return this;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000E550 File Offset: 0x0000C750
		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000E550 File Offset: 0x0000C750
		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000E578 File Offset: 0x0000C778
		public virtual bool vmethod_8()
		{
			return Convert.ToBoolean(this.vmethod_1());
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000E594 File Offset: 0x0000C794
		public virtual sbyte vmethod_9()
		{
			return Convert.ToSByte(this.vmethod_1());
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		public virtual short E1099AD6()
		{
			return Convert.ToInt16(this.vmethod_1());
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		public virtual int E5B28EFF()
		{
			return Convert.ToInt32(this.vmethod_1());
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public virtual long D264B6CE()
		{
			return Convert.ToInt64(this.vmethod_1());
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000E604 File Offset: 0x0000C804
		public virtual char FBD6E971()
		{
			return Convert.ToChar(this.vmethod_1());
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000E620 File Offset: 0x0000C820
		public virtual byte vmethod_10()
		{
			return Convert.ToByte(this.vmethod_1());
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000E63C File Offset: 0x0000C83C
		public virtual ushort DA16486C()
		{
			return Convert.ToUInt16(this.vmethod_1());
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000E658 File Offset: 0x0000C858
		public virtual uint vmethod_11()
		{
			return Convert.ToUInt32(this.vmethod_1());
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000E674 File Offset: 0x0000C874
		public virtual ulong vmethod_12()
		{
			return Convert.ToUInt64(this.vmethod_1());
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000E690 File Offset: 0x0000C890
		public virtual float BD4D4126()
		{
			return Convert.ToSingle(this.vmethod_1());
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000E6AC File Offset: 0x0000C8AC
		public virtual double vmethod_13()
		{
			return Convert.ToDouble(this.vmethod_1());
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public override string ToString()
		{
			object obj = this.vmethod_1();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000E550 File Offset: 0x0000C750
		public virtual IntPtr BF5057B5()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000E550 File Offset: 0x0000C750
		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000E550 File Offset: 0x0000C750
		public virtual object C28A04F7(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x0200002D RID: 45
	private abstract class Class1 : GClass5.Class0
	{
		// Token: 0x060001BC RID: 444 RVA: 0x0000E564 File Offset: 0x0000C764
		public override GClass5.Class1 vmethod_4()
		{
			return this;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000E53C File Offset: 0x0000C73C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	// Token: 0x0200002E RID: 46
	private sealed class Class2 : GClass5.Class1
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public Class2(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000E718 File Offset: 0x0000C918
		public override Type vmethod_6()
		{
			return typeof(int);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000E730 File Offset: 0x0000C930
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000E744 File Offset: 0x0000C944
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class2(this.int_0);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000E760 File Offset: 0x0000C960
		public override object vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000E77C File Offset: 0x0000C97C
		public override void vmethod_2(object object_0)
		{
			this.int_0 = Convert.ToInt32(object_0);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000E79C File Offset: 0x0000C99C
		public override bool vmethod_8()
		{
			return this.int_0 != 0;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.int_0;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		public override short E1099AD6()
		{
			return (short)this.int_0;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		public override int E5B28EFF()
		{
			return this.int_0;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000E804 File Offset: 0x0000CA04
		public override long D264B6CE()
		{
			return (long)this.int_0;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000E81C File Offset: 0x0000CA1C
		public override char FBD6E971()
		{
			return (char)this.int_0;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000E834 File Offset: 0x0000CA34
		public override byte vmethod_10()
		{
			return (byte)this.int_0;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000E81C File Offset: 0x0000CA1C
		public override ushort DA16486C()
		{
			return (ushort)this.int_0;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		public override uint vmethod_11()
		{
			return (uint)this.int_0;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000E84C File Offset: 0x0000CA4C
		public override ulong vmethod_12()
		{
			return (ulong)this.int_0;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000E864 File Offset: 0x0000CA64
		public override float BD4D4126()
		{
			return (float)this.int_0;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000E87C File Offset: 0x0000CA7C
		public override double vmethod_13()
		{
			return (double)this.int_0;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000E894 File Offset: 0x0000CA94
		public override IntPtr BF5057B5()
		{
			return new IntPtr(this.int_0);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)this.int_0);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000E8CC File Offset: 0x0000CACC
		public override GClass5.Class0 vmethod_5()
		{
			return new GClass5.Class27((uint)this.int_0);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					if (IntPtr.Size == 4)
					{
						return new IntPtr((!bool_0) ? this.int_0 : ((int)((uint)this.int_0)));
					}
					return new IntPtr((long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0)))));
				}
				else
				{
					if (type_0 == typeof(UIntPtr))
					{
						return new UIntPtr((!bool_0) ? ((uint)this.int_0) : ((uint)this.int_0));
					}
					switch (Type.GetTypeCode(type_0))
					{
					case TypeCode.SByte:
						return bool_0 ? ((sbyte)((uint)this.int_0)) : ((sbyte)this.int_0);
					case TypeCode.Byte:
						return bool_0 ? ((byte)((uint)this.int_0)) : ((byte)this.int_0);
					case TypeCode.Int16:
						return bool_0 ? ((short)((uint)this.int_0)) : ((short)this.int_0);
					case TypeCode.UInt16:
						return bool_0 ? ((ushort)((uint)this.int_0)) : ((ushort)this.int_0);
					case TypeCode.Int32:
						return bool_0 ? ((int)((uint)this.int_0)) : this.int_0;
					case TypeCode.UInt32:
						return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
					case TypeCode.Int64:
						return unchecked((!bool_0) ? ((long)this.int_0) : ((long)((ulong)this.int_0)));
					case TypeCode.UInt64:
						return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
					case TypeCode.Double:
						return bool_0 ? this.int_0 : ((double)this.int_0);
					}
					throw new ArgumentException();
				}
			}
		}

		// Token: 0x04000338 RID: 824
		private int int_0;
	}

	// Token: 0x0200002F RID: 47
	private sealed class Class3 : GClass5.Class1
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x0000EA98 File Offset: 0x0000CC98
		public Class3(long long_1)
		{
			this.long_0 = long_1;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000EABC File Offset: 0x0000CCBC
		public override Type vmethod_6()
		{
			return typeof(long);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public override GClass5.Class0 vmethod_5()
		{
			return new GClass5.Class28((ulong)this.long_0);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000EB04 File Offset: 0x0000CD04
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class3(this.long_0);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public override object vmethod_1()
		{
			return this.long_0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		public override void vmethod_2(object object_0)
		{
			this.long_0 = Convert.ToInt64(object_0);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000EB58 File Offset: 0x0000CD58
		public override bool vmethod_8()
		{
			return this.long_0 != 0L;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		public override char FBD6E971()
		{
			return (char)this.long_0;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000EB94 File Offset: 0x0000CD94
		public override byte vmethod_10()
		{
			return (byte)this.long_0;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.long_0;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		public override short E1099AD6()
		{
			return (short)this.long_0;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		public override int E5B28EFF()
		{
			return (int)this.long_0;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		public override long D264B6CE()
		{
			return this.long_0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		public override ushort DA16486C()
		{
			return (ushort)this.long_0;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		public override uint vmethod_11()
		{
			return (uint)this.long_0;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		public override ulong vmethod_12()
		{
			return (ulong)this.long_0;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000EC24 File Offset: 0x0000CE24
		public override float BD4D4126()
		{
			return (float)this.long_0;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		public override double vmethod_13()
		{
			return (double)this.long_0;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000EC54 File Offset: 0x0000CE54
		public override IntPtr BF5057B5()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.long_0)) : this.long_0);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000EC80 File Offset: 0x0000CE80
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((UIntPtr.Size == 4) ? ((ulong)((uint)this.long_0)) : ((ulong)this.long_0));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000ECAC File Offset: 0x0000CEAC
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((!bool_0) ? this.long_0 : ((long)((ulong)this.long_0)));
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((!bool_0) ? ((ulong)this.long_0) : ((ulong)this.long_0));
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return (!bool_0) ? ((sbyte)this.long_0) : ((sbyte)((ulong)this.long_0));
				case TypeCode.Byte:
					return bool_0 ? ((byte)((ulong)this.long_0)) : ((byte)this.long_0);
				case TypeCode.Int16:
					return bool_0 ? ((short)((ulong)this.long_0)) : ((short)this.long_0);
				case TypeCode.UInt16:
					return (!bool_0) ? ((ushort)this.long_0) : ((ushort)((uint)this.long_0));
				case TypeCode.Int32:
					return bool_0 ? ((int)((ulong)this.long_0)) : ((int)this.long_0);
				case TypeCode.UInt32:
					return bool_0 ? ((uint)((ulong)this.long_0)) : ((uint)this.long_0);
				case TypeCode.Int64:
					return bool_0 ? ((long)((ulong)this.long_0)) : this.long_0;
				case TypeCode.UInt64:
					return (ulong)(bool_0 ? this.long_0 : ((long)((ulong)this.long_0)));
				case TypeCode.Double:
					return bool_0 ? this.long_0 : ((double)this.long_0);
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x04000339 RID: 825
		private long long_0;
	}

	// Token: 0x02000030 RID: 48
	private sealed class Class4 : GClass5.Class1
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000EE38 File Offset: 0x0000D038
		public Class4(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000EE5C File Offset: 0x0000D05C
		public override Type vmethod_6()
		{
			return typeof(float);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000EE74 File Offset: 0x0000D074
		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000EE88 File Offset: 0x0000D088
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class4(this.float_0);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		public override object vmethod_1()
		{
			return this.float_0;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		public override void vmethod_2(object object_0)
		{
			this.float_0 = Convert.ToSingle(object_0);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000EEDC File Offset: 0x0000D0DC
		public override bool vmethod_8()
		{
			return Convert.ToBoolean(this.float_0);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		public override sbyte vmethod_9()
		{
			return (sbyte)this.float_0;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000EF10 File Offset: 0x0000D110
		public override short E1099AD6()
		{
			return (short)this.float_0;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000EF28 File Offset: 0x0000D128
		public override int E5B28EFF()
		{
			return (int)this.float_0;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000EF40 File Offset: 0x0000D140
		public override long D264B6CE()
		{
			return (long)this.float_0;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000EF58 File Offset: 0x0000D158
		public override char FBD6E971()
		{
			return (char)this.float_0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000EF70 File Offset: 0x0000D170
		public override byte vmethod_10()
		{
			return (byte)this.float_0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000EF58 File Offset: 0x0000D158
		public override ushort DA16486C()
		{
			return (ushort)this.float_0;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000EF88 File Offset: 0x0000D188
		public override uint vmethod_11()
		{
			return (uint)this.float_0;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		public override ulong vmethod_12()
		{
			return (ulong)this.float_0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		public override float BD4D4126()
		{
			return this.float_0;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public override double vmethod_13()
		{
			return (double)this.float_0;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		public override IntPtr BF5057B5()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.float_0)) : ((long)this.float_0));
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000F014 File Offset: 0x0000D214
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.float_0)) : ((ulong)this.float_0));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000F040 File Offset: 0x0000D240
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.float_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.float_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return (!bool_0) ? ((sbyte)this.float_0) : ((sbyte)((uint)this.float_0));
				case TypeCode.Byte:
					return (byte)this.float_0;
				case TypeCode.Int16:
					return bool_0 ? ((short)((uint)this.float_0)) : ((short)this.float_0);
				case TypeCode.UInt16:
					return (ushort)this.float_0;
				case TypeCode.Int32:
					return (int)this.float_0;
				case TypeCode.UInt32:
					return (uint)this.float_0;
				case TypeCode.UInt64:
					return (ulong)this.float_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x0400033A RID: 826
		private float float_0;
	}

	// Token: 0x02000031 RID: 49
	private sealed class Class5 : GClass5.Class1
	{
		// Token: 0x06000200 RID: 512 RVA: 0x0000F138 File Offset: 0x0000D338
		public Class5(double double_1)
		{
			this.double_0 = double_1;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000F154 File Offset: 0x0000D354
		public override Type vmethod_6()
		{
			return typeof(double);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000F16C File Offset: 0x0000D36C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000F180 File Offset: 0x0000D380
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class5(this.double_0);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000F19C File Offset: 0x0000D39C
		public override object vmethod_1()
		{
			return this.double_0;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		public override void vmethod_2(object object_0)
		{
			this.double_0 = (double)object_0;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		public override bool vmethod_8()
		{
			return Convert.ToBoolean(this.double_0);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		public override sbyte vmethod_9()
		{
			return (sbyte)this.double_0;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override short E1099AD6()
		{
			return (short)this.double_0;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000F224 File Offset: 0x0000D424
		public override int E5B28EFF()
		{
			return (int)this.double_0;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000F23C File Offset: 0x0000D43C
		public override long D264B6CE()
		{
			return (long)this.double_0;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000F254 File Offset: 0x0000D454
		public override char FBD6E971()
		{
			return (char)this.double_0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000F26C File Offset: 0x0000D46C
		public override byte vmethod_10()
		{
			return (byte)this.double_0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000F254 File Offset: 0x0000D454
		public override ushort DA16486C()
		{
			return (ushort)this.double_0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000F284 File Offset: 0x0000D484
		public override uint vmethod_11()
		{
			return (uint)this.double_0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000F29C File Offset: 0x0000D49C
		public override ulong vmethod_12()
		{
			return (ulong)this.double_0;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		public override float BD4D4126()
		{
			return (float)this.double_0;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		public override double vmethod_13()
		{
			return this.double_0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		public override IntPtr BF5057B5()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.double_0)) : ((long)this.double_0));
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000F310 File Offset: 0x0000D510
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.double_0)) : ((ulong)this.double_0));
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000F33C File Offset: 0x0000D53C
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.double_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.double_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((uint)this.double_0)) : ((sbyte)this.double_0);
				case TypeCode.Byte:
					return (byte)this.double_0;
				case TypeCode.Int16:
					return bool_0 ? ((short)((uint)this.double_0)) : ((short)this.double_0);
				case TypeCode.UInt16:
					return (ushort)this.double_0;
				case TypeCode.Int32:
					return (int)this.double_0;
				case TypeCode.UInt32:
					return (uint)this.double_0;
				case TypeCode.Int64:
					return (long)this.double_0;
				case TypeCode.UInt64:
					return (ulong)this.double_0;
				case TypeCode.Double:
					return this.double_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x0400033B RID: 827
		private double double_0;
	}

	// Token: 0x02000032 RID: 50
	private sealed class Class6 : GClass5.Class1
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000F458 File Offset: 0x0000D658
		public Class6(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000F47C File Offset: 0x0000D67C
		public override Type vmethod_6()
		{
			return typeof(string);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000F494 File Offset: 0x0000D694
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class6(this.string_0);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public override object vmethod_1()
		{
			return this.string_0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public override void vmethod_2(object object_0)
		{
			this.string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000F504 File Offset: 0x0000D704
		public override bool vmethod_8()
		{
			return this.string_0 != null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x0400033C RID: 828
		private string string_0;
	}

	// Token: 0x02000033 RID: 51
	private sealed class Class21 : GClass5.Class0
	{
		// Token: 0x0600021D RID: 541 RVA: 0x0000F520 File Offset: 0x0000D720
		public Class21(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000F53C File Offset: 0x0000D73C
		public override Type vmethod_6()
		{
			return typeof(short);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000F554 File Offset: 0x0000D754
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class21(this.short_0);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000F570 File Offset: 0x0000D770
		public override object vmethod_1()
		{
			return this.short_0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000F58C File Offset: 0x0000D78C
		public override void vmethod_2(object object_0)
		{
			this.short_0 = Convert.ToInt16(object_0);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		public override sbyte vmethod_9()
		{
			return (sbyte)this.short_0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		public override byte vmethod_10()
		{
			return (byte)this.short_0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		public override short E1099AD6()
		{
			return this.short_0;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000F610 File Offset: 0x0000D810
		public override ushort DA16486C()
		{
			return (ushort)this.short_0;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		public override int E5B28EFF()
		{
			return (int)this.short_0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		public override uint vmethod_11()
		{
			return (uint)this.short_0;
		}

		// Token: 0x0400033D RID: 829
		private short short_0;
	}

	// Token: 0x02000034 RID: 52
	private sealed class Class22 : GClass5.Class0
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0000F628 File Offset: 0x0000D828
		public Class22(ushort ushort_1)
		{
			this.ushort_0 = ushort_1;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000F64C File Offset: 0x0000D84C
		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000F664 File Offset: 0x0000D864
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class22(this.ushort_0);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000F680 File Offset: 0x0000D880
		public override object vmethod_1()
		{
			return this.ushort_0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000F69C File Offset: 0x0000D89C
		public override void vmethod_2(object object_0)
		{
			this.ushort_0 = Convert.ToUInt16(object_0);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.ushort_0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public override byte vmethod_10()
		{
			return (byte)this.ushort_0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		public override short E1099AD6()
		{
			return (short)this.ushort_0;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000F704 File Offset: 0x0000D904
		public override ushort DA16486C()
		{
			return this.ushort_0;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000F704 File Offset: 0x0000D904
		public override int E5B28EFF()
		{
			return (int)this.ushort_0;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000F704 File Offset: 0x0000D904
		public override uint vmethod_11()
		{
			return (uint)this.ushort_0;
		}

		// Token: 0x0400033E RID: 830
		private ushort ushort_0;
	}

	// Token: 0x02000035 RID: 53
	private sealed class Class23 : GClass5.Class0
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0000F71C File Offset: 0x0000D91C
		public Class23(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000F740 File Offset: 0x0000D940
		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000F758 File Offset: 0x0000D958
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class23(this.bool_0);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000F774 File Offset: 0x0000D974
		public override object vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000F790 File Offset: 0x0000D990
		public override void vmethod_2(object object_0)
		{
			this.bool_0 = Convert.ToBoolean(object_0);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		public override int E5B28EFF()
		{
			if (!this.bool_0)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0400033F RID: 831
		private bool bool_0;
	}

	// Token: 0x02000036 RID: 54
	private sealed class Class24 : GClass5.Class0
	{
		// Token: 0x0600023C RID: 572 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		public Class24(char char_1)
		{
			this.char_0 = char_1;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000F7EC File Offset: 0x0000D9EC
		public override Type vmethod_6()
		{
			return typeof(char);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000F804 File Offset: 0x0000DA04
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class24(this.char_0);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000F820 File Offset: 0x0000DA20
		public override object vmethod_1()
		{
			return this.char_0;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000F83C File Offset: 0x0000DA3C
		public override void vmethod_2(object object_0)
		{
			this.char_0 = Convert.ToChar(object_0);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000F85C File Offset: 0x0000DA5C
		public override sbyte vmethod_9()
		{
			return (sbyte)this.char_0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000F874 File Offset: 0x0000DA74
		public override byte vmethod_10()
		{
			return (byte)this.char_0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000F88C File Offset: 0x0000DA8C
		public override short E1099AD6()
		{
			return (short)this.char_0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public override ushort DA16486C()
		{
			return (ushort)this.char_0;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public override int E5B28EFF()
		{
			return (int)this.char_0;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public override uint vmethod_11()
		{
			return (uint)this.char_0;
		}

		// Token: 0x04000340 RID: 832
		private char char_0;
	}

	// Token: 0x02000037 RID: 55
	private sealed class Class25 : GClass5.Class0
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0000F8BC File Offset: 0x0000DABC
		public Class25(byte byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class25(this.byte_0);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000F90C File Offset: 0x0000DB0C
		public override object vmethod_1()
		{
			return this.byte_0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000F928 File Offset: 0x0000DB28
		public override void vmethod_2(object object_0)
		{
			this.byte_0 = Convert.ToByte(object_0);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000F948 File Offset: 0x0000DB48
		public override sbyte vmethod_9()
		{
			return (sbyte)this.byte_0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000F960 File Offset: 0x0000DB60
		public override byte vmethod_10()
		{
			return this.byte_0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000F960 File Offset: 0x0000DB60
		public override short E1099AD6()
		{
			return (short)this.byte_0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000F960 File Offset: 0x0000DB60
		public override ushort DA16486C()
		{
			return (ushort)this.byte_0;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000F960 File Offset: 0x0000DB60
		public override int E5B28EFF()
		{
			return (int)this.byte_0;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000F960 File Offset: 0x0000DB60
		public override uint vmethod_11()
		{
			return (uint)this.byte_0;
		}

		// Token: 0x04000341 RID: 833
		private byte byte_0;
	}

	// Token: 0x02000038 RID: 56
	private sealed class Class26 : GClass5.Class0
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0000F978 File Offset: 0x0000DB78
		public Class26(sbyte sbyte_1)
		{
			this.sbyte_0 = sbyte_1;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000F99C File Offset: 0x0000DB9C
		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class26(this.sbyte_0);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		public override object vmethod_1()
		{
			return this.sbyte_0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		public override void vmethod_2(object object_0)
		{
			this.sbyte_0 = Convert.ToSByte(object_0);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public override sbyte vmethod_9()
		{
			return this.sbyte_0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000FA24 File Offset: 0x0000DC24
		public override byte vmethod_10()
		{
			return (byte)this.sbyte_0;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public override short E1099AD6()
		{
			return (short)this.sbyte_0;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000FA3C File Offset: 0x0000DC3C
		public override ushort DA16486C()
		{
			return (ushort)this.sbyte_0;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public override int E5B28EFF()
		{
			return (int)this.sbyte_0;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		public override uint vmethod_11()
		{
			return (uint)this.sbyte_0;
		}

		// Token: 0x04000342 RID: 834
		private sbyte sbyte_0;
	}

	// Token: 0x02000039 RID: 57
	private sealed class Class27 : GClass5.Class0
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0000FA54 File Offset: 0x0000DC54
		public Class27(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000FA70 File Offset: 0x0000DC70
		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000FA88 File Offset: 0x0000DC88
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class27(this.uint_0);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
		public override object vmethod_1()
		{
			return this.uint_0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
		public override void vmethod_2(object object_0)
		{
			this.uint_0 = Convert.ToUInt32(object_0);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000F5AC File Offset: 0x0000D7AC
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.E5B28EFF());
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000FADC File Offset: 0x0000DCDC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.uint_0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public override byte vmethod_10()
		{
			return (byte)this.uint_0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		public override short E1099AD6()
		{
			return (short)this.uint_0;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000FB24 File Offset: 0x0000DD24
		public override ushort DA16486C()
		{
			return (ushort)this.uint_0;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		public override int E5B28EFF()
		{
			return (int)this.uint_0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		public override uint vmethod_11()
		{
			return this.uint_0;
		}

		// Token: 0x04000343 RID: 835
		private uint uint_0;
	}

	// Token: 0x0200003A RID: 58
	private sealed class Class28 : GClass5.Class0
	{
		// Token: 0x0600026C RID: 620 RVA: 0x0000FB54 File Offset: 0x0000DD54
		public Class28(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000FB78 File Offset: 0x0000DD78
		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000FB90 File Offset: 0x0000DD90
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class28(this.ulong_0);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		public override object vmethod_1()
		{
			return this.ulong_0;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		public override void vmethod_2(object object_0)
		{
			this.ulong_0 = Convert.ToUInt64(object_0);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class3(this.D264B6CE());
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public override sbyte vmethod_9()
		{
			return (sbyte)this.ulong_0;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000FC1C File Offset: 0x0000DE1C
		public override byte vmethod_10()
		{
			return (byte)this.ulong_0;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000FC34 File Offset: 0x0000DE34
		public override short E1099AD6()
		{
			return (short)this.ulong_0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000FC4C File Offset: 0x0000DE4C
		public override ushort DA16486C()
		{
			return (ushort)this.ulong_0;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000FC64 File Offset: 0x0000DE64
		public override int E5B28EFF()
		{
			return (int)this.ulong_0;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000FC7C File Offset: 0x0000DE7C
		public override uint vmethod_11()
		{
			return (uint)this.ulong_0;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public override long D264B6CE()
		{
			return (long)this.ulong_0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public override ulong vmethod_12()
		{
			return this.ulong_0;
		}

		// Token: 0x04000344 RID: 836
		private ulong ulong_0;
	}

	// Token: 0x0200003B RID: 59
	private sealed class Class7 : GClass5.Class1
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		public Class7(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000F494 File Offset: 0x0000D694
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000FCE8 File Offset: 0x0000DEE8
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class7(this.object_0);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000FD38 File Offset: 0x0000DF38
		public override bool vmethod_8()
		{
			return this.object_0 != null;
		}

		// Token: 0x04000345 RID: 837
		private object object_0;
	}

	// Token: 0x0200003C RID: 60
	private sealed class Class8 : GClass5.Class1
	{
		// Token: 0x06000281 RID: 641 RVA: 0x0000FD54 File Offset: 0x0000DF54
		public Class8(object object_1, Type type_1)
		{
			this.object_0 = object_1;
			this.type_0 = type_1;
			this.class0_0 = GClass5.Class8.smethod_0(object_1);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000FD84 File Offset: 0x0000DF84
		private static GClass5.Class0 smethod_0(object object_1)
		{
			IntPtr intPtr = (object_1 != null) ? new IntPtr(Pointer.Unbox(object_1)) : IntPtr.Zero;
			if (IntPtr.Size == 4)
			{
				return new GClass5.Class2(intPtr.ToInt32());
			}
			return new GClass5.Class3(intPtr.ToInt64());
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		public override TypeCode vmethod_7()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class8(this.object_0, this.type_0);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000FE20 File Offset: 0x0000E020
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000FE38 File Offset: 0x0000E038
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
			this.class0_0 = GClass5.Class8.smethod_0(object_1);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000FE64 File Offset: 0x0000E064
		public override bool vmethod_8()
		{
			return this.object_0 != null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000FE80 File Offset: 0x0000E080
		public override sbyte vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000FE9C File Offset: 0x0000E09C
		public override short E1099AD6()
		{
			return this.class0_0.E1099AD6();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		public override int E5B28EFF()
		{
			return this.class0_0.E5B28EFF();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		public override long D264B6CE()
		{
			return this.class0_0.D264B6CE();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		public override byte vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000FF0C File Offset: 0x0000E10C
		public override ushort DA16486C()
		{
			return this.class0_0.DA16486C();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000FF28 File Offset: 0x0000E128
		public override uint vmethod_11()
		{
			return this.class0_0.vmethod_11();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000FF44 File Offset: 0x0000E144
		public override ulong vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000FF60 File Offset: 0x0000E160
		public override float BD4D4126()
		{
			return this.class0_0.BD4D4126();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000FF7C File Offset: 0x0000E17C
		public override double vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000FF98 File Offset: 0x0000E198
		public override IntPtr BF5057B5()
		{
			return this.class0_0.BF5057B5();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public override UIntPtr vmethod_14()
		{
			return this.class0_0.vmethod_14();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		public override object C28A04F7(Type type_1, bool bool_0)
		{
			return this.class0_0.C28A04F7(type_1, bool_0);
		}

		// Token: 0x04000346 RID: 838
		private object object_0;

		// Token: 0x04000347 RID: 839
		private Type type_0;

		// Token: 0x04000348 RID: 840
		private GClass5.Class0 class0_0;
	}

	// Token: 0x0200003D RID: 61
	private sealed class Class9 : GClass5.Class1
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		public Class9(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00010020 File Offset: 0x0000E220
		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00010038 File Offset: 0x0000E238
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class9(this.object_0);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00010054 File Offset: 0x0000E254
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001006C File Offset: 0x0000E26C
		public override void vmethod_2(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x04000349 RID: 841
		private object object_0;
	}

	// Token: 0x0200003E RID: 62
	private sealed class Class10 : GClass5.Class1
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00010094 File Offset: 0x0000E294
		public Class10(Array array_1)
		{
			this.array_0 = array_1;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000100B8 File Offset: 0x0000E2B8
		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000100D0 File Offset: 0x0000E2D0
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class10(this.array_0);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000100EC File Offset: 0x0000E2EC
		public override object vmethod_1()
		{
			return this.array_0;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00010104 File Offset: 0x0000E304
		public override void vmethod_2(object object_0)
		{
			this.array_0 = (Array)object_0;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00010124 File Offset: 0x0000E324
		public override bool vmethod_8()
		{
			return this.array_0 != null;
		}

		// Token: 0x0400034A RID: 842
		private Array array_0;
	}

	// Token: 0x0200003F RID: 63
	private abstract class Class11 : GClass5.Class1
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x0000F494 File Offset: 0x0000D694
		public override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x02000040 RID: 64
	private sealed class Class12 : GClass5.Class11
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00010158 File Offset: 0x0000E358
		public Class12(GClass5.Class0 class0_1)
		{
			this.class0_0 = class0_1;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001017C File Offset: 0x0000E37C
		public override Type vmethod_6()
		{
			return this.class0_0.vmethod_6();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00010198 File Offset: 0x0000E398
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class12(this.class0_0);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000101B4 File Offset: 0x0000E3B4
		public override object vmethod_1()
		{
			return this.class0_0.vmethod_1();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000101D0 File Offset: 0x0000E3D0
		public override void vmethod_2(object object_0)
		{
			this.class0_0.vmethod_2(object_0);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000101F0 File Offset: 0x0000E3F0
		public override bool vmethod_8()
		{
			return this.class0_0 != null;
		}

		// Token: 0x0400034B RID: 843
		private GClass5.Class0 class0_0;
	}

	// Token: 0x02000041 RID: 65
	private sealed class Class13 : GClass5.Class11
	{
		// Token: 0x060002AA RID: 682 RVA: 0x0001020C File Offset: 0x0000E40C
		public Class13(GClass5.Class0 class0_2, GClass5.Class0 class0_3)
		{
			this.class0_0 = class0_2;
			this.class0_1 = class0_3;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00010230 File Offset: 0x0000E430
		public override Type vmethod_6()
		{
			return this.class0_0.vmethod_6();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001024C File Offset: 0x0000E44C
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class13(this.class0_0, this.class0_1);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00010270 File Offset: 0x0000E470
		public override object vmethod_1()
		{
			return this.class0_0.vmethod_1();
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001028C File Offset: 0x0000E48C
		public override void vmethod_2(object object_0)
		{
			this.class0_0.vmethod_2(object_0);
			this.class0_1.vmethod_2(this.class0_0.vmethod_1());
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000102C8 File Offset: 0x0000E4C8
		public override bool vmethod_8()
		{
			return this.class0_0 != null;
		}

		// Token: 0x0400034C RID: 844
		private GClass5.Class0 class0_0;

		// Token: 0x0400034D RID: 845
		private GClass5.Class0 class0_1;
	}

	// Token: 0x02000042 RID: 66
	private sealed class Class14 : GClass5.Class11
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x000102E4 File Offset: 0x0000E4E4
		public Class14(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00010314 File Offset: 0x0000E514
		public override Type vmethod_6()
		{
			return this.fieldInfo_0.FieldType;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00010330 File Offset: 0x0000E530
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class14(this.fieldInfo_0, this.object_0);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00010354 File Offset: 0x0000E554
		public override object vmethod_1()
		{
			return this.fieldInfo_0.GetValue(this.object_0);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00010378 File Offset: 0x0000E578
		public override void vmethod_2(object object_1)
		{
			this.fieldInfo_0.SetValue(this.object_0, object_1);
		}

		// Token: 0x0400034E RID: 846
		private FieldInfo fieldInfo_0;

		// Token: 0x0400034F RID: 847
		private object object_0;
	}

	// Token: 0x02000043 RID: 67
	private sealed class Class15 : GClass5.Class11
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x000103A0 File Offset: 0x0000E5A0
		public Class15(Array array_1, int int_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000103D0 File Offset: 0x0000E5D0
		public override Type vmethod_6()
		{
			return this.array_0.GetType().GetElementType();
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class15(this.array_0, this.int_0);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00010414 File Offset: 0x0000E614
		public override object vmethod_1()
		{
			return this.array_0.GetValue(this.int_0);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00010438 File Offset: 0x0000E638
		public override void vmethod_2(object object_0)
		{
			this.array_0.SetValue(object_0, this.int_0);
		}

		// Token: 0x04000350 RID: 848
		private Array array_0;

		// Token: 0x04000351 RID: 849
		private int int_0;
	}

	// Token: 0x02000044 RID: 68
	private sealed class Class17 : GClass5.Class1
	{
		// Token: 0x060002BA RID: 698 RVA: 0x00010460 File Offset: 0x0000E660
		public Class17(MethodBase methodBase_1)
		{
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00010484 File Offset: 0x0000E684
		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001049C File Offset: 0x0000E69C
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class17(this.methodBase_0);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000104B8 File Offset: 0x0000E6B8
		public override object vmethod_1()
		{
			return this.methodBase_0;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000104D0 File Offset: 0x0000E6D0
		public override void vmethod_2(object object_0)
		{
			this.methodBase_0 = (MethodBase)object_0;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000104F0 File Offset: 0x0000E6F0
		public override bool vmethod_8()
		{
			return this.methodBase_0 != null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001050C File Offset: 0x0000E70C
		public override IntPtr BF5057B5()
		{
			return this.methodBase_0.MethodHandle.GetFunctionPointer();
		}

		// Token: 0x04000352 RID: 850
		private MethodBase methodBase_0;
	}

	// Token: 0x02000045 RID: 69
	private sealed class Class18 : GClass5.Class1
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00010534 File Offset: 0x0000E734
		public Class18(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
			this.class0_0 = GClass5.Class18.smethod_0(this.intptr_0);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00010560 File Offset: 0x0000E760
		private static GClass5.Class0 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass5.Class2(intptr_1.ToInt32());
			}
			return new GClass5.Class3(intptr_1.ToInt64());
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00010590 File Offset: 0x0000E790
		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000105A8 File Offset: 0x0000E7A8
		public override TypeCode vmethod_7()
		{
			return this.class0_0.vmethod_7();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000105C4 File Offset: 0x0000E7C4
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class18(this.intptr_0);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000105E0 File Offset: 0x0000E7E0
		public override object vmethod_1()
		{
			return this.intptr_0;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000105FC File Offset: 0x0000E7FC
		public override void vmethod_2(object object_0)
		{
			this.intptr_0 = (IntPtr)object_0;
			this.class0_0 = GClass5.Class18.smethod_0(this.intptr_0);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00010634 File Offset: 0x0000E834
		public override bool vmethod_8()
		{
			return this.intptr_0 != IntPtr.Zero;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00010654 File Offset: 0x0000E854
		public override sbyte vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00010670 File Offset: 0x0000E870
		public override short E1099AD6()
		{
			return this.class0_0.E1099AD6();
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001068C File Offset: 0x0000E88C
		public override int E5B28EFF()
		{
			return this.class0_0.E5B28EFF();
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000106A8 File Offset: 0x0000E8A8
		public override long D264B6CE()
		{
			return this.class0_0.D264B6CE();
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000106C4 File Offset: 0x0000E8C4
		public override byte vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000106E0 File Offset: 0x0000E8E0
		public override ushort DA16486C()
		{
			return this.class0_0.DA16486C();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000106FC File Offset: 0x0000E8FC
		public override uint vmethod_11()
		{
			return this.class0_0.vmethod_11();
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00010718 File Offset: 0x0000E918
		public override ulong vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00010734 File Offset: 0x0000E934
		public override float BD4D4126()
		{
			return this.class0_0.BD4D4126();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00010750 File Offset: 0x0000E950
		public override double vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001076C File Offset: 0x0000E96C
		public override IntPtr BF5057B5()
		{
			return this.intptr_0;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00010784 File Offset: 0x0000E984
		public override UIntPtr vmethod_14()
		{
			return this.class0_0.vmethod_14();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			return this.class0_0.C28A04F7(type_0, bool_0);
		}

		// Token: 0x04000353 RID: 851
		private IntPtr intptr_0;

		// Token: 0x04000354 RID: 852
		private GClass5.Class0 class0_0;
	}

	// Token: 0x02000046 RID: 70
	private sealed class Class19 : GClass5.Class1
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x000107C4 File Offset: 0x0000E9C4
		public Class19(UIntPtr uintptr_1)
		{
			this.uintptr_0 = uintptr_1;
			this.class0_0 = GClass5.Class19.smethod_0(this.uintptr_0);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00010800 File Offset: 0x0000EA00
		private static GClass5.Class0 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass5.Class2((int)uintptr_1.ToUInt32());
			}
			return new GClass5.Class3((long)uintptr_1.ToUInt64());
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00010830 File Offset: 0x0000EA30
		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00010848 File Offset: 0x0000EA48
		public override TypeCode vmethod_7()
		{
			return this.class0_0.vmethod_7();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00010864 File Offset: 0x0000EA64
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class19(this.uintptr_0);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00010880 File Offset: 0x0000EA80
		public override object vmethod_1()
		{
			return this.uintptr_0;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001089C File Offset: 0x0000EA9C
		public override void vmethod_2(object object_0)
		{
			this.uintptr_0 = (UIntPtr)object_0;
			this.class0_0 = GClass5.Class19.smethod_0(this.uintptr_0);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000108D4 File Offset: 0x0000EAD4
		public override bool vmethod_8()
		{
			return this.uintptr_0 != UIntPtr.Zero;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000108F4 File Offset: 0x0000EAF4
		public override sbyte vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00010910 File Offset: 0x0000EB10
		public override short E1099AD6()
		{
			return this.class0_0.E1099AD6();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001092C File Offset: 0x0000EB2C
		public override int E5B28EFF()
		{
			return this.class0_0.E5B28EFF();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00010948 File Offset: 0x0000EB48
		public override long D264B6CE()
		{
			return this.class0_0.D264B6CE();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00010964 File Offset: 0x0000EB64
		public override byte vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00010980 File Offset: 0x0000EB80
		public override ushort DA16486C()
		{
			return this.class0_0.DA16486C();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001099C File Offset: 0x0000EB9C
		public override uint vmethod_11()
		{
			return this.class0_0.vmethod_11();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000109B8 File Offset: 0x0000EBB8
		public override ulong vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000109D4 File Offset: 0x0000EBD4
		public override float BD4D4126()
		{
			return this.class0_0.BD4D4126();
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000109F0 File Offset: 0x0000EBF0
		public override double vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00010A0C File Offset: 0x0000EC0C
		public override IntPtr BF5057B5()
		{
			return this.class0_0.BF5057B5();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00010A28 File Offset: 0x0000EC28
		public override UIntPtr vmethod_14()
		{
			return this.uintptr_0;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00010A40 File Offset: 0x0000EC40
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			return this.class0_0.C28A04F7(type_0, bool_0);
		}

		// Token: 0x04000355 RID: 853
		private UIntPtr uintptr_0;

		// Token: 0x04000356 RID: 854
		private GClass5.Class0 class0_0;
	}

	// Token: 0x02000047 RID: 71
	private sealed class Class20 : GClass5.Class1
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00010A64 File Offset: 0x0000EC64
		public Class20(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = enum_1;
			this.class0_0 = GClass5.Class20.smethod_0(this.enum_0);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00010A98 File Offset: 0x0000EC98
		private static GClass5.Class0 smethod_0(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new GClass5.Class2(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new GClass5.Class2((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new GClass5.Class3(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new GClass5.Class3((long)Convert.ToUInt64(enum_1));
			default:
				throw new InvalidOperationException();
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00010B0C File Offset: 0x0000ED0C
		public override GClass5.Class0 vmethod_5()
		{
			return this.class0_0.vmethod_5();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00010B28 File Offset: 0x0000ED28
		public override Type vmethod_6()
		{
			return this.enum_0.GetType();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00010B44 File Offset: 0x0000ED44
		public override TypeCode vmethod_7()
		{
			return this.class0_0.vmethod_7();
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00010B60 File Offset: 0x0000ED60
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class20(this.enum_0);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00010B7C File Offset: 0x0000ED7C
		public override object vmethod_1()
		{
			return this.enum_0;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00010B94 File Offset: 0x0000ED94
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = (Enum)object_0;
			this.class0_0 = GClass5.Class20.smethod_0(this.enum_0);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		public override byte vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		public override sbyte vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00010C00 File Offset: 0x0000EE00
		public override short E1099AD6()
		{
			return this.class0_0.E1099AD6();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public override ushort DA16486C()
		{
			return this.class0_0.DA16486C();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00010C38 File Offset: 0x0000EE38
		public override int E5B28EFF()
		{
			return this.class0_0.E5B28EFF();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00010C54 File Offset: 0x0000EE54
		public override uint vmethod_11()
		{
			return this.class0_0.vmethod_11();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00010C70 File Offset: 0x0000EE70
		public override long D264B6CE()
		{
			return this.class0_0.D264B6CE();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public override ulong vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		public override float BD4D4126()
		{
			return this.class0_0.BD4D4126();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		public override double vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		public override IntPtr BF5057B5()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)this.E5B28EFF()) : this.D264B6CE());
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00010D0C File Offset: 0x0000EF0C
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)this.vmethod_11()) : this.vmethod_12());
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00010D38 File Offset: 0x0000EF38
		public override object C28A04F7(Type type_0, bool bool_0)
		{
			return this.class0_0.C28A04F7(type_0, bool_0);
		}

		// Token: 0x04000357 RID: 855
		private Enum enum_0;

		// Token: 0x04000358 RID: 856
		private GClass5.Class0 class0_0;
	}

	// Token: 0x02000048 RID: 72
	private sealed class Class16 : GClass5.Class11
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00010D5C File Offset: 0x0000EF5C
		public Class16(IntPtr intptr_1, Type type_1)
		{
			this.intptr_0 = intptr_1;
			this.type_0 = type_1;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010D8C File Offset: 0x0000EF8C
		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000E53C File Offset: 0x0000C73C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class16(this.intptr_0, this.type_0);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		public override object vmethod_1()
		{
			if (!this.type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(this.intptr_0, this.type_0);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			if (this.type_0.IsValueType)
			{
				Marshal.StructureToPtr(object_0, this.intptr_0, false);
				return;
			}
			switch (Type.GetTypeCode(object_0.GetType()))
			{
			case TypeCode.Char:
				Marshal.WriteInt16(this.intptr_0, Convert.ToChar(object_0));
				return;
			case TypeCode.SByte:
				Marshal.WriteByte(this.intptr_0, (byte)Convert.ToSByte(object_0));
				return;
			case TypeCode.Byte:
				Marshal.WriteByte(this.intptr_0, Convert.ToByte(object_0));
				return;
			case TypeCode.Int16:
				Marshal.WriteInt16(this.intptr_0, Convert.ToInt16(object_0));
				return;
			case TypeCode.UInt16:
				Marshal.WriteInt16(this.intptr_0, (short)Convert.ToUInt16(object_0));
				return;
			case TypeCode.Int32:
				Marshal.WriteInt32(this.intptr_0, Convert.ToInt32(object_0));
				return;
			case TypeCode.UInt32:
				Marshal.WriteInt32(this.intptr_0, (int)Convert.ToUInt32(object_0));
				return;
			case TypeCode.Int64:
				Marshal.WriteInt64(this.intptr_0, Convert.ToInt64(object_0));
				return;
			case TypeCode.UInt64:
				Marshal.WriteInt64(this.intptr_0, (long)Convert.ToUInt64(object_0));
				return;
			case TypeCode.Single:
				Marshal.WriteInt32(this.intptr_0, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), 0));
				return;
			case TypeCode.Double:
				Marshal.WriteInt64(this.intptr_0, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(object_0)), 0));
				return;
			default:
				throw new ArgumentException();
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00010F50 File Offset: 0x0000F150
		public override sbyte vmethod_9()
		{
			return (sbyte)Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00010F6C File Offset: 0x0000F16C
		public override short E1099AD6()
		{
			return Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00010F88 File Offset: 0x0000F188
		public override int E5B28EFF()
		{
			return Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		public override long D264B6CE()
		{
			return Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public override char FBD6E971()
		{
			return (char)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00010FDC File Offset: 0x0000F1DC
		public override byte vmethod_10()
		{
			return Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public override ushort DA16486C()
		{
			return (ushort)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00010F88 File Offset: 0x0000F188
		public override uint vmethod_11()
		{
			return (uint)Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		public override ulong vmethod_12()
		{
			return (ulong)Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		public override float BD4D4126()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(this.intptr_0)), 0);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00011024 File Offset: 0x0000F224
		public override double vmethod_13()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.intptr_0)), 0);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00011050 File Offset: 0x0000F250
		public override IntPtr BF5057B5()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)Marshal.ReadInt32(this.intptr_0)) : Marshal.ReadInt64(this.intptr_0));
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00011084 File Offset: 0x0000F284
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)Marshal.ReadInt32(this.intptr_0)) : ((ulong)Marshal.ReadInt64(this.intptr_0)));
		}

		// Token: 0x04000359 RID: 857
		private IntPtr intptr_0;

		// Token: 0x0400035A RID: 858
		private Type type_0;
	}

	// Token: 0x02000049 RID: 73
	private sealed class Class29
	{
		// Token: 0x06000313 RID: 787 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public Class29(byte byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000110E0 File Offset: 0x0000F2E0
		public byte method_0()
		{
			return this.byte_0;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00011110 File Offset: 0x0000F310
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x0400035B RID: 859
		private byte byte_0;

		// Token: 0x0400035C RID: 860
		private int int_0;

		// Token: 0x0400035D RID: 861
		private int int_1;
	}

	// Token: 0x0200004A RID: 74
	private sealed class Class30
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00011128 File Offset: 0x0000F328
		public Class30(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011168 File Offset: 0x0000F368
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00011180 File Offset: 0x0000F380
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00011198 File Offset: 0x0000F398
		public int method_2(GClass5.Class30 class30_0)
		{
			if (class30_0 == null)
			{
				return 1;
			}
			int num = this.int_0.CompareTo(class30_0.method_0());
			if (num == 0)
			{
				num = class30_0.method_1().CompareTo(this.int_1);
			}
			return num;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000111D8 File Offset: 0x0000F3D8
		public void method_3(byte byte_0, int int_2, int int_3)
		{
			this.list_0.Add(new GClass5.Class29(byte_0, int_2, int_3));
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00011204 File Offset: 0x0000F404
		public List<GClass5.Class29> method_4()
		{
			return this.list_0;
		}

		// Token: 0x0400035E RID: 862
		private int int_0;

		// Token: 0x0400035F RID: 863
		private int int_1;

		// Token: 0x04000360 RID: 864
		private List<GClass5.Class29> list_0 = new List<GClass5.Class29>();
	}

	// Token: 0x0200004B RID: 75
	// (Invoke) Token: 0x0600031E RID: 798
	internal delegate void Delegate0();
}
