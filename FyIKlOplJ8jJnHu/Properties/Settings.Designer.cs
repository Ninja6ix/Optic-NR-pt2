﻿using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FyIKlOplJ8jJnHu.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000213C File Offset: 0x0000033C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002143 File Offset: 0x00000343
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002158 File Offset: 0x00000358
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Login
		{
			get
			{
				return (string)this["Login"];
			}
			set
			{
				this["Login"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000216C File Offset: 0x0000036C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002181 File Offset: 0x00000381
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002195 File Offset: 0x00000395
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000021AA File Offset: 0x000003AA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Directory
		{
			get
			{
				return (string)this["Directory"];
			}
			set
			{
				this["Directory"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021BE File Offset: 0x000003BE
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000021D3 File Offset: 0x000003D3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Clearlog
		{
			get
			{
				return (string)this["Clearlog"];
			}
			set
			{
				this["Clearlog"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021E7 File Offset: 0x000003E7
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000021FC File Offset: 0x000003FC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string NorecoilDirectory
		{
			get
			{
				return (string)this["NorecoilDirectory"];
			}
			set
			{
				this["NorecoilDirectory"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002210 File Offset: 0x00000410
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002225 File Offset: 0x00000425
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool CheckBox
		{
			get
			{
				return (bool)this["CheckBox"];
			}
			set
			{
				this["CheckBox"] = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
