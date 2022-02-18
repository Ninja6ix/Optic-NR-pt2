using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x0200000F RID: 15
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x040002BA RID: 698
		TERMINATE = 1,
		// Token: 0x040002BB RID: 699
		SUSPEND_RESUME = 2,
		// Token: 0x040002BC RID: 700
		GET_CONTEXT = 8,
		// Token: 0x040002BD RID: 701
		SET_CONTEXT = 16,
		// Token: 0x040002BE RID: 702
		SET_INFORMATION = 32,
		// Token: 0x040002BF RID: 703
		QUERY_INFORMATION = 64,
		// Token: 0x040002C0 RID: 704
		SET_THREAD_TOKEN = 128,
		// Token: 0x040002C1 RID: 705
		IMPERSONATE = 256,
		// Token: 0x040002C2 RID: 706
		DIRECT_IMPERSONATION = 512
	}
}
