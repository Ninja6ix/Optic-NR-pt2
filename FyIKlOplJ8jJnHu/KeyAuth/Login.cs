using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using FyIKlOplJ8jJnHu.Properties;
using injector;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000009 RID: 9
	public partial class Login : Form
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000022D8 File Offset: 0x000004D8
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000022EC File Offset: 0x000004EC
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005C64 File Offset: 0x00003E64
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			this.Text = Settings.Default.Login;
			this.username.Text = Settings.Default.Login;
			this.Text = Settings.Default.Password;
			this.password.Text = Settings.Default.Password;
			Login.KeyAuthApp.init();
			if (Login.KeyAuthApp.checkblack())
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000022F8 File Offset: 0x000004F8
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.upgrade(this.username.Text, this.license.Text);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002320 File Offset: 0x00000520
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002348 File Offset: 0x00000548
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000234A File Offset: 0x0000054A
		private void LicBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.license(this.license.Text);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002348 File Offset: 0x00000548
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002348 File Offset: 0x00000548
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002348 File Offset: 0x00000548
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002348 File Offset: 0x00000548
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002348 File Offset: 0x00000548
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002348 File Offset: 0x00000548
		private void siticoneLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002348 File Offset: 0x00000548
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002348 File Offset: 0x00000548
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002348 File Offset: 0x00000548
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002348 File Offset: 0x00000548
		private void password_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002348 File Offset: 0x00000548
		private void siticoneLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002348 File Offset: 0x00000548
		private void siticoneLabel3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002348 File Offset: 0x00000548
		private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002348 File Offset: 0x00000548
		private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002348 File Offset: 0x00000548
		private void label3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002348 File Offset: 0x00000548
		private void RgstrBtn_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002348 File Offset: 0x00000548
		private void license_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002348 File Offset: 0x00000548
		private void password_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002348 File Offset: 0x00000548
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002348 File Offset: 0x00000548
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002348 File Offset: 0x00000548
		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002348 File Offset: 0x00000548
		private void license_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002348 File Offset: 0x00000548
		private void pictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002348 File Offset: 0x00000548
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002348 File Offset: 0x00000548
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005CF4 File Offset: 0x00003EF4
		private void LoginBtn_Click_1(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			Login.KeyAuthApp.log("Login Successful");
			Optic optic = new Optic();
			optic.Show();
			base.Hide();
			Settings.Default.Login = this.username.Text;
			Settings.Default.Save();
			Settings.Default.Password = this.password.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005D98 File Offset: 0x00003F98
		private void RgstrBtn_Click_2(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.license.Text);
			MessageBox.Show(string.Concat(new string[]
			{
				"Thanks For Registering \n Key: ",
				this.license.Text,
				"\n Username: ",
				this.username.Text,
				"\n Password: ",
				this.password.Text,
				"\nPlease click OK and Login :) "
			}), "Optic Cheats");
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002348 File Offset: 0x00000548
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002348 File Offset: 0x00000548
		private void password_TextChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002364 File Offset: 0x00000564
		private void username_MouseClick(object sender, MouseEventArgs e)
		{
			this.username.Text = " ";
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002379 File Offset: 0x00000579
		private void password_MouseClick(object sender, MouseEventArgs e)
		{
			this.password.Text = " ";
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000238E File Offset: 0x0000058E
		private void license_MouseClick(object sender, MouseEventArgs e)
		{
			this.license.Text = " ";
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005E64 File Offset: 0x00004064
		private void label2_MouseClick(object sender, MouseEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FyIKlOplJ8jJnHu");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002348 File Offset: 0x00000548
		private void label2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002348 File Offset: 0x00000548
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000043 RID: 67
		private static string name = "Proxy NR";

		// Token: 0x04000044 RID: 68
		private static string ownerid = "EgG46Xxtnh";

		// Token: 0x04000045 RID: 69
		private static string secret = "85dd2070641d5ca08126cde08a8bf807180e58e28530833ead67ec94fb3c6a0f";

		// Token: 0x04000046 RID: 70
		private static string version = "1.0";

		// Token: 0x04000047 RID: 71
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
