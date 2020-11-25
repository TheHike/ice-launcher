using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using IceLauncher.Properties;

namespace IceLauncher
{
	// Token: 0x02000002 RID: 2
	public partial class Form : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000021B0 File Offset: 0x000003B0
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 132)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public Form()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021E0 File Offset: 0x000003E0
		public bool GetConnection()
		{
			bool result;
			try
			{
				using (WebClient webClient = new Form.WebClientWithTimeout())
				{
					webClient.DownloadString("http://ip.iceroleplay.pt:30120/players.json");
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002230 File Offset: 0x00000430
		private void UseCustomFont(string name, int size, Label label)
		{
			PrivateFontCollection privateFontCollection = new PrivateFontCollection();
			privateFontCollection.AddFontFile("American Captain.otf");
			label.Font = new Font(privateFontCollection.Families[0], (float)size);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002264 File Offset: 0x00000464
		private void Form_Load(object sender, EventArgs e)
		{
			this.label14.Hide();
			this.label15.Hide();
			this.label16.Hide();
			this.textBox3.Hide();
			this.button2.Hide();
			this.button4.Hide();
			this.webBrowser1.Hide();
			this.label20.Hide();
			if (this.GetConnection())
			{
				this.label22.Text = "ON";
				this.label22.ForeColor = Color.FromArgb(25, 200, 25);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002065 File Offset: 0x00000265
		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		private void label3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002075 File Offset: 0x00000275
		private void label4_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
			Process.Start("https://iceroleplay.pt");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002089 File Offset: 0x00000289
		private void label5_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
			Process.Start("https://discord.gg/icerp");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209D File Offset: 0x0000029D
		private void label6_Click(object sender, EventArgs e)
		{
			Process.Start("fivem://connect/ip.iceroleplay.pt:30120");
			base.Close();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022FC File Offset: 0x000004FC
		public int pCount()
		{
			int result;
			try
			{
				using (WebClient webClient = new Form.WebClientWithTimeout())
				{
					string text = webClient.DownloadString("http://ip.iceroleplay.pt:30120/players.json");
					int num = text.Length - text.Replace("{", "").Length;
					result = num;
				}
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000236C File Offset: 0x0000056C
		private void label7_Click(object sender, EventArgs e)
		{
			this.label8.Show();
			this.label9.Show();
			this.label10.Show();
			this.label11.Show();
			this.label12.Show();
			this.label14.Hide();
			this.label15.Hide();
			this.label16.Hide();
			this.textBox3.Hide();
			this.button2.Hide();
			this.webBrowser1.Hide();
			this.button4.Hide();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002400 File Offset: 0x00000600
		private void label13_Click(object sender, EventArgs e)
		{
			this.label8.Hide();
			this.label9.Hide();
			this.label10.Hide();
			this.label11.Hide();
			this.label12.Hide();
			this.label16.Hide();
			this.textBox3.Hide();
			this.button2.Hide();
			this.button4.Hide();
			this.webBrowser1.Hide();
			this.label14.Show();
			this.label15.Show();
			int value = this.pCount();
			string str = Convert.ToString(value);
			this.label15.Text = str + " / 128";
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020B0 File Offset: 0x000002B0
		private void label15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020B0 File Offset: 0x000002B0
		private void label14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000024B8 File Offset: 0x000006B8
		private void button4_Click(object sender, EventArgs e)
		{
			string path = Settings.Default["fivemdir"].ToString() + "\\cache";
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
				MessageBox.Show("Voçê excluiu a sua pasta cache.");
			}
			else
			{
				MessageBox.Show("A pasta Cache não foi encontrada!");
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020B2 File Offset: 0x000002B2
		private void button2_Click(object sender, EventArgs e)
		{
			Settings.Default["fivemdir"] = this.textBox3.Text;
			Settings.Default.Save();
			MessageBox.Show("Diretório Do FiveM Definido.");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020B0 File Offset: 0x000002B0
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000250C File Offset: 0x0000070C
		private void label17_Click(object sender, EventArgs e)
		{
			this.label8.Hide();
			this.label9.Hide();
			this.label10.Hide();
			this.label11.Hide();
			this.label12.Hide();
			this.label14.Hide();
			this.label15.Hide();
			this.webBrowser1.Hide();
			this.label16.Show();
			this.textBox3.Show();
			this.button2.Show();
			this.button4.Show();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020B0 File Offset: 0x000002B0
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000025A0 File Offset: 0x000007A0
		private void label18_Click(object sender, EventArgs e)
		{
			this.label8.Hide();
			this.label9.Hide();
			this.label10.Hide();
			this.label11.Hide();
			this.label12.Hide();
			this.label14.Hide();
			this.label15.Hide();
			this.label16.Hide();
			this.textBox3.Hide();
			this.button2.Hide();
			this.button4.Hide();
			this.webBrowser1.Show();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020B0 File Offset: 0x000002B0
		private void label20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020E3 File Offset: 0x000002E3
		private void button1_Click(object sender, EventArgs e)
		{
			this.label19.Hide();
			this.label20.Show();
			this.BackgroundImage = Resources.DarkAzul;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002106 File Offset: 0x00000306
		private void button3_Click(object sender, EventArgs e)
		{
			this.label19.Show();
			this.label20.Hide();
			this.BackgroundImage = Resources.Azul;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020B0 File Offset: 0x000002B0
		private void label22_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020B0 File Offset: 0x000002B0
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private const int WM_NCHITTEST = 132;

		// Token: 0x04000002 RID: 2
		private const int HT_CLIENT = 1;

		// Token: 0x04000003 RID: 3
		private const int HT_CAPTION = 2;

		// Token: 0x02000006 RID: 6
		public class WebClientWithTimeout : WebClient
		{
			// Token: 0x0600002F RID: 47 RVA: 0x00003D80 File Offset: 0x00001F80
			protected override WebRequest GetWebRequest(Uri address)
			{
				WebRequest webRequest = base.GetWebRequest(address);
				webRequest.Timeout = 1000;
				return webRequest;
			}
		}
	}
}
