using System;
using System.Windows.Forms;

namespace IceLauncher
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002129 File Offset: 0x00000329
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form());
		}
	}
}
