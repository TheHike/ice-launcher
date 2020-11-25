using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace IceLauncher.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002140 File Offset: 0x00000340
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003C40 File Offset: 0x00001E40
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("IceLauncher.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002148 File Offset: 0x00000348
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003C94 File Offset: 0x00001E94
		internal static Bitmap Azul
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Azul", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003CC0 File Offset: 0x00001EC0
		internal static Bitmap DarkAzul
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("DarkAzul", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400001F RID: 31
		private static ResourceManager resourceMan;

		// Token: 0x04000020 RID: 32
		private static CultureInfo resourceCulture;
	}
}
