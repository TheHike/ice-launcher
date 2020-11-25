using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace IceLauncher.Properties
{
	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003CEC File Offset: 0x00001EEC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003D00 File Offset: 0x00001F00
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002150 File Offset: 0x00000350
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string name
		{
			get
			{
				return (string)this["name"];
			}
			set
			{
				this["name"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003D20 File Offset: 0x00001F20
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000215E File Offset: 0x0000035E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003D40 File Offset: 0x00001F40
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000216C File Offset: 0x0000036C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string storeinfo
		{
			get
			{
				return (string)this["storeinfo"];
			}
			set
			{
				this["storeinfo"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003D60 File Offset: 0x00001F60
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000217A File Offset: 0x0000037A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string fivemdir
		{
			get
			{
				return (string)this["fivemdir"];
			}
			set
			{
				this["fivemdir"] = value;
			}
		}

		// Token: 0x04000021 RID: 33
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
