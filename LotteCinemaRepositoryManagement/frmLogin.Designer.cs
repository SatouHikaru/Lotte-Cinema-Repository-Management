namespace LotteCinemaRepositoryManagement
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEdtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splBtnExit = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.hyperlnkLblCtrlForgotPassword = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ KHO LOTTE CINEMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hyperlnkLblCtrlForgotPassword);
            this.panel1.Controls.Add(this.txtEdtPassword);
            this.panel1.Controls.Add(this.txtEdtUsername);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 142);
            this.panel1.TabIndex = 1;
            // 
            // txtEdtPassword
            // 
            this.txtEdtPassword.Location = new System.Drawing.Point(265, 59);
            this.txtEdtPassword.Name = "txtEdtPassword";
            this.txtEdtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEdtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtEdtPassword.Properties.UseSystemPasswordChar = true;
            this.txtEdtPassword.Size = new System.Drawing.Size(250, 26);
            this.txtEdtPassword.TabIndex = 3;
            // 
            // txtEdtUsername
            // 
            this.txtEdtUsername.Location = new System.Drawing.Point(265, 18);
            this.txtEdtUsername.Name = "txtEdtUsername";
            this.txtEdtUsername.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEdtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtEdtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtEdtUsername.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(149, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(149, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.splBtnExit);
            this.panel2.Controls.Add(this.splBtnLogin);
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 49);
            this.panel2.TabIndex = 2;
            // 
            // splBtnExit
            // 
            this.splBtnExit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.splBtnExit.Appearance.Options.UseFont = true;
            this.splBtnExit.Location = new System.Drawing.Point(414, 6);
            this.splBtnExit.Name = "splBtnExit";
            this.splBtnExit.Size = new System.Drawing.Size(101, 34);
            this.splBtnExit.TabIndex = 1;
            this.splBtnExit.Text = "Thoát";
            this.splBtnExit.Click += new System.EventHandler(this.splBtnExit_Click);
            // 
            // splBtnLogin
            // 
            this.splBtnLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.splBtnLogin.Appearance.Options.UseFont = true;
            this.splBtnLogin.Location = new System.Drawing.Point(265, 6);
            this.splBtnLogin.Name = "splBtnLogin";
            this.splBtnLogin.Size = new System.Drawing.Size(101, 34);
            this.splBtnLogin.TabIndex = 0;
            this.splBtnLogin.Text = "Đăng nhập";
            this.splBtnLogin.Click += new System.EventHandler(this.splBtnLogin_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // hyperlnkLblCtrlForgotPassword
            // 
            this.hyperlnkLblCtrlForgotPassword.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hyperlnkLblCtrlForgotPassword.Appearance.Options.UseFont = true;
            this.hyperlnkLblCtrlForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlnkLblCtrlForgotPassword.Location = new System.Drawing.Point(265, 107);
            this.hyperlnkLblCtrlForgotPassword.Name = "hyperlnkLblCtrlForgotPassword";
            this.hyperlnkLblCtrlForgotPassword.Size = new System.Drawing.Size(109, 20);
            this.hyperlnkLblCtrlForgotPassword.TabIndex = 4;
            this.hyperlnkLblCtrlForgotPassword.Text = "Quên mật khẩu";
            this.hyperlnkLblCtrlForgotPassword.Click += new System.EventHandler(this.hyperlnkLblCtrlForgotPassword_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.splBtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 237);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(558, 276);
            this.MinimumSize = new System.Drawing.Size(558, 276);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtEdtPassword;
        private DevExpress.XtraEditors.TextEdit txtEdtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton splBtnExit;
        private DevExpress.XtraEditors.SimpleButton splBtnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlnkLblCtrlForgotPassword;
    }
}