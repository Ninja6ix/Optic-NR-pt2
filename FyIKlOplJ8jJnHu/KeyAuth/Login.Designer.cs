﻿namespace KeyAuth
{
	// Token: 0x02000009 RID: 9
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00005EC4 File Offset: 0x000040C4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005F08 File Offset: 0x00004108
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			global::BunifuAnimatorNS.Animation animation2 = new global::BunifuAnimatorNS.Animation();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LicBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.username = new global::System.Windows.Forms.TextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.password = new global::System.Windows.Forms.TextBox();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.license = new global::System.Windows.Forms.TextBox();
			this.LoginBtn = new global::System.Windows.Forms.Button();
			this.RgstrBtn = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuTransition1 = new global::BunifuAnimatorNS.BunifuTransition(this.components);
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse3 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse4 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.siticoneControlBox1.BorderRadius = 10;
			this.bunifuTransition1.SetDecoration(this.siticoneControlBox1, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(591, 0);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.PressedColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.bunifuTransition1.SetDecoration(this.siticoneControlBox2, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox2.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(565, 0);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.PressedColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label1, global::BunifuAnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.LicBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.LicBtn.BorderThickness = 1;
			this.LicBtn.CheckedState.Parent = this.LicBtn;
			this.LicBtn.CustomImages.Parent = this.LicBtn;
			this.siticoneTransition1.SetDecoration(this.LicBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.LicBtn, global::BunifuAnimatorNS.DecorationType.None);
			this.LicBtn.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.LicBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LicBtn.ForeColor = global::System.Drawing.Color.Black;
			this.LicBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LicBtn.HoveredState.Parent = this.LicBtn;
			this.LicBtn.Location = new global::System.Drawing.Point(180, 587);
			this.LicBtn.Name = "LicBtn";
			this.LicBtn.PressedColor = global::System.Drawing.Color.Gray;
			this.LicBtn.ShadowDecoration.Parent = this.LicBtn;
			this.LicBtn.Size = new global::System.Drawing.Size(153, 27);
			this.LicBtn.TabIndex = 37;
			this.LicBtn.Text = "License";
			this.LicBtn.Visible = false;
			this.LicBtn.Click += new global::System.EventHandler(this.LicBtn_Click);
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.pictureBox1, global::BunifuAnimatorNS.DecorationType.None);
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(85, 75);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 41;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.pictureBox1);
			this.bunifuTransition1.SetDecoration(this.panel1, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(616, 75);
			this.panel1.TabIndex = 52;
			this.username.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.username.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.username, global::BunifuAnimatorNS.DecorationType.None);
			this.username.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.SystemColors.MenuBar;
			this.username.Location = new global::System.Drawing.Point(97, 139);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(188, 16);
			this.username.TabIndex = 54;
			this.username.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.username_MouseClick);
			this.username.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged_1);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(51, 65, 255);
			this.bunifuTransition1.SetDecoration(this.panel2, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.panel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel2.Location = new global::System.Drawing.Point(97, 157);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(200, 1);
			this.panel2.TabIndex = 55;
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(51, 65, 255);
			this.bunifuTransition1.SetDecoration(this.panel3, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.panel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel3.Location = new global::System.Drawing.Point(97, 218);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(200, 1);
			this.panel3.TabIndex = 58;
			this.panel3.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			this.password.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.password.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.password, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.password, global::BunifuAnimatorNS.DecorationType.None);
			this.password.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.password.ForeColor = global::System.Drawing.SystemColors.MenuBar;
			this.password.Location = new global::System.Drawing.Point(97, 200);
			this.password.Name = "password";
			this.password.Size = new global::System.Drawing.Size(188, 16);
			this.password.TabIndex = 57;
			this.password.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
			this.password.TextChanged += new global::System.EventHandler(this.password_TextChanged_2);
			this.panel4.BackColor = global::System.Drawing.Color.FromArgb(51, 65, 255);
			this.bunifuTransition1.SetDecoration(this.panel4, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this.panel4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel4.Location = new global::System.Drawing.Point(97, 282);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(200, 1);
			this.panel4.TabIndex = 61;
			this.panel4.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			this.license.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.license.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.license, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.license, global::BunifuAnimatorNS.DecorationType.None);
			this.license.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.license.ForeColor = global::System.Drawing.SystemColors.MenuBar;
			this.license.Location = new global::System.Drawing.Point(97, 264);
			this.license.Name = "license";
			this.license.Size = new global::System.Drawing.Size(188, 16);
			this.license.TabIndex = 60;
			this.license.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.license_MouseClick);
			this.license.TextChanged += new global::System.EventHandler(this.license_TextChanged_1);
			this.LoginBtn.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginBtn.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.siticoneTransition1.SetDecoration(this.LoginBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.LoginBtn, global::BunifuAnimatorNS.DecorationType.None);
			this.LoginBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(51, 65, 255);
			this.LoginBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoginBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginBtn.Location = new global::System.Drawing.Point(495, 308);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new global::System.Drawing.Size(99, 28);
			this.LoginBtn.TabIndex = 62;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = false;
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click_1);
			this.RgstrBtn.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RgstrBtn.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.siticoneTransition1.SetDecoration(this.RgstrBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.RgstrBtn, global::BunifuAnimatorNS.DecorationType.None);
			this.RgstrBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(51, 65, 255);
			this.RgstrBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RgstrBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RgstrBtn.Location = new global::System.Drawing.Point(495, 270);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.Size = new global::System.Drawing.Size(99, 28);
			this.RgstrBtn.TabIndex = 63;
			this.RgstrBtn.Text = "Register";
			this.RgstrBtn.UseVisualStyleBackColor = false;
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click_2);
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label2, global::BunifuAnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(51, 65, 255);
			this.label2.Location = new global::System.Drawing.Point(12, 331);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(27, 15);
			this.label2.TabIndex = 64;
			this.label2.Text = "Exit";
			this.label2.Click += new global::System.EventHandler(this.label2_Click_1);
			this.label2.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label3, global::BunifuAnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(157, 120);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(81, 16);
			this.label3.TabIndex = 65;
			this.label3.Text = "Username";
			this.label4.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label4, global::BunifuAnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(157, 181);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(77, 16);
			this.label4.TabIndex = 66;
			this.label4.Text = "Password";
			this.label5.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label5, global::BunifuAnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(177, 245);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(34, 16);
			this.label5.TabIndex = 67;
			this.label5.Text = "Key";
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuTransition1.AnimationType = global::BunifuAnimatorNS.AnimationType.VertSlide;
			this.bunifuTransition1.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
			animation2.LeafCoeff = 0f;
			animation2.MaxTime = 1f;
			animation2.MinTime = 0f;
			animation2.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
			animation2.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicShift");
			animation2.MosaicSize = 0;
			animation2.Padding = new global::System.Windows.Forms.Padding(0);
			animation2.RotateCoeff = 0f;
			animation2.RotateLimit = 0f;
			animation2.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
			animation2.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
			animation2.TimeCoeff = 0f;
			animation2.TransparencyCoeff = 0f;
			this.bunifuTransition1.DefaultAnimation = animation2;
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			this.bunifuElipse2.ElipseRadius = 10;
			this.bunifuElipse2.TargetControl = this;
			this.bunifuElipse3.ElipseRadius = 10;
			this.bunifuElipse3.TargetControl = this;
			this.bunifuElipse4.ElipseRadius = 10;
			this.bunifuElipse4.TargetControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(616, 355);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.license);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.password);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.username);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.LicBtn);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.bunifuTransition1.SetDecoration(this, global::BunifuAnimatorNS.DecorationType.None);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			this.ForeColor = global::System.Drawing.Color.Transparent;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "----";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000048 RID: 72
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000049 RID: 73
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400004A RID: 74
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400004B RID: 75
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400004C RID: 76
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400004E RID: 78
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x0400004F RID: 79
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LicBtn;

		// Token: 0x04000050 RID: 80
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000051 RID: 81
		private global::BunifuAnimatorNS.BunifuTransition bunifuTransition1;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000053 RID: 83
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x04000054 RID: 84
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse2;

		// Token: 0x04000055 RID: 85
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse3;

		// Token: 0x04000056 RID: 86
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse4;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TextBox username;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.TextBox license;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.TextBox password;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Button LoginBtn;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Button RgstrBtn;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label4;
	}
}
