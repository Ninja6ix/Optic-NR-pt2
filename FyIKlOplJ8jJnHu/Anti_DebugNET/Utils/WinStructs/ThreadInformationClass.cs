using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x0200000E RID: 14
	public enum ThreadInformationClass
	{
		// Token: 0x04000292 RID: 658
		ThreadBasicInformation,
		// Token: 0x04000293 RID: 659
		ThreadTimes,
		// Token: 0x04000294 RID: 660
		ThreadPriority,
		// Token: 0x04000295 RID: 661
		ThreadBasePriority,
		// Token: 0x04000296 RID: 662
		ThreadAffinityMask,
		// Token: 0x04000297 RID: 663
		ThreadImpersonationToken,
		// Token: 0x04000298 RID: 664
		ThreadDescriptorTableEntry,
		// Token: 0x04000299 RID: 665
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x0400029A RID: 666
		ThreadEventPair_Reusable,
		// Token: 0x0400029B RID: 667
		ThreadQuerySetWin32StartAddress,
		// Token: 0x0400029C RID: 668
		ThreadZeroTlsCell,
		// Token: 0x0400029D RID: 669
		ThreadPerformanceCount,
		// Token: 0x0400029E RID: 670
		ThreadAmILastThread,
		// Token: 0x0400029F RID: 671
		ThreadIdealProcessor,
		// Token: 0x040002A0 RID: 672
		ThreadPriorityBoost,
		// Token: 0x040002A1 RID: 673
		ThreadSetTlsArrayAddress,
		// Token: 0x040002A2 RID: 674
		ThreadIsIoPending,
		// Token: 0x040002A3 RID: 675
		ThreadHideFromDebugger,
		// Token: 0x040002A4 RID: 676
		ThreadBreakOnTermination,
		// Token: 0x040002A5 RID: 677
		ThreadSwitchLegacyState,
		// Token: 0x040002A6 RID: 678
		ThreadIsTerminated,
		// Token: 0x040002A7 RID: 679
		ThreadLastSystemCall,
		// Token: 0x040002A8 RID: 680
		ThreadIoPriority,
		// Token: 0x040002A9 RID: 681
		ThreadCycleTime,
		// Token: 0x040002AA RID: 682
		ThreadPagePriority,
		// Token: 0x040002AB RID: 683
		ThreadActualBasePriority,
		// Token: 0x040002AC RID: 684
		ThreadTebInformation,
		// Token: 0x040002AD RID: 685
		ThreadCSwitchMon,
		// Token: 0x040002AE RID: 686
		ThreadCSwitchPmu,
		// Token: 0x040002AF RID: 687
		ThreadWow64Context,
		// Token: 0x040002B0 RID: 688
		ThreadGroupInformation,
		// Token: 0x040002B1 RID: 689
		ThreadUmsInformation,
		// Token: 0x040002B2 RID: 690
		ThreadCounterProfiling,
		// Token: 0x040002B3 RID: 691
		ThreadIdealProcessorEx,
		// Token: 0x040002B4 RID: 692
		ThreadCpuAccountingInformation,
		// Token: 0x040002B5 RID: 693
		ThreadSuspendCount,
		// Token: 0x040002B6 RID: 694
		ThreadDescription = 38,
		// Token: 0x040002B7 RID: 695
		ThreadActualGroupAffinity = 41,
		// Token: 0x040002B8 RID: 696
		ThreadDynamicCodePolicy
	}
}
