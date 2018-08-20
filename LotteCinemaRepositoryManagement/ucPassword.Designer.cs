namespace LotteCinemaRepositoryManagement
{
    partial class ucPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPassword));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splBtnChange = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtEdtNewPassword1 = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtNewPassword2 = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtNewPassword1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtNewPassword2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.splBtnChange);
            this.groupControl1.Controls.Add(this.splBtnClear);
            this.groupControl1.Controls.Add(this.txtEdtNewPassword1);
            this.groupControl1.Controls.Add(this.txtEdtNewPassword2);
            this.groupControl1.Controls.Add(this.txtEdtOldPassword);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(615, 426);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl3.Location = new System.Drawing.Point(23, 225);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nhập lại mật khẩu mới";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Location = new System.Drawing.Point(23, 185);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhập mật khẩu mới";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Location = new System.Drawing.Point(23, 147);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập mật khẩu cũ";
            // 
            // splBtnChange
            // 
            this.splBtnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splBtnChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnChange.ImageOptions.Image")));
            this.splBtnChange.Location = new System.Drawing.Point(204, 288);
            this.splBtnChange.Name = "splBtnChange";
            this.splBtnChange.Size = new System.Drawing.Size(75, 23);
            this.splBtnChange.TabIndex = 6;
            this.splBtnChange.Text = "Thay đổi";
            this.splBtnChange.Click += new System.EventHandler(this.splBtnChange_Click);
            // 
            // splBtnClear
            // 
            this.splBtnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splBtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnClear.ImageOptions.Image")));
            this.splBtnClear.Location = new System.Drawing.Point(322, 288);
            this.splBtnClear.Name = "splBtnClear";
            this.splBtnClear.Size = new System.Drawing.Size(75, 23);
            this.splBtnClear.TabIndex = 7;
            this.splBtnClear.Text = "Huỷ";
            this.splBtnClear.Click += new System.EventHandler(this.splBtnClear_Click);
            // 
            // txtEdtNewPassword1
            // 
            this.txtEdtNewPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtNewPassword1.Location = new System.Drawing.Point(138, 182);
            this.txtEdtNewPassword1.Name = "txtEdtNewPassword1";
            this.txtEdtNewPassword1.Properties.UseSystemPasswordChar = true;
            this.txtEdtNewPassword1.Size = new System.Drawing.Size(438, 20);
            this.txtEdtNewPassword1.TabIndex = 3;
            // 
            // txtEdtNewPassword2
            // 
            this.txtEdtNewPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtNewPassword2.Location = new System.Drawing.Point(138, 222);
            this.txtEdtNewPassword2.Name = "txtEdtNewPassword2";
            this.txtEdtNewPassword2.Properties.UseSystemPasswordChar = true;
            this.txtEdtNewPassword2.Size = new System.Drawing.Size(438, 20);
            this.txtEdtNewPassword2.TabIndex = 5;
            // 
            // txtEdtOldPassword
            // 
            this.txtEdtOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtOldPassword.Location = new System.Drawing.Point(138, 144);
            this.txtEdtOldPassword.Name = "txtEdtOldPassword";
            this.txtEdtOldPassword.Properties.UseSystemPasswordChar = true;
            this.txtEdtOldPassword.Size = new System.Drawing.Size(438, 20);
            this.txtEdtOldPassword.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ucPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucPassword";
            this.Size = new System.Drawing.Size(615, 426);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtNewPassword1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtNewPassword2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton splBtnChange;
        private DevExpress.XtraEditors.SimpleButton splBtnClear;
        private DevExpress.XtraEditors.TextEdit txtEdtNewPassword1;
        private DevExpress.XtraEditors.TextEdit txtEdtNewPassword2;
        private DevExpress.XtraEditors.TextEdit txtEdtOldPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
