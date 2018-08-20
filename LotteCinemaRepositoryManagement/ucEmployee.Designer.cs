namespace LotteCinemaRepositoryManagement
{
    partial class ucEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployee));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.pnlCtrlNhanVien = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtEdtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtMobilePhone = new DevExpress.XtraEditors.TextEdit();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtEdtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splBtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnGet = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlNhanVien)).BeginInit();
            this.pnlCtrlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMobilePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvEmployee);
            this.groupControl1.Controls.Add(this.pnlCtrlNhanVien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(615, 426);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Nhân viên";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(2, 170);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(611, 254);
            this.dgvEmployee.TabIndex = 3;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // pnlCtrlNhanVien
            // 
            this.pnlCtrlNhanVien.Controls.Add(this.panelControl2);
            this.pnlCtrlNhanVien.Controls.Add(this.panelControl1);
            this.pnlCtrlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlNhanVien.Location = new System.Drawing.Point(2, 20);
            this.pnlCtrlNhanVien.Name = "pnlCtrlNhanVien";
            this.pnlCtrlNhanVien.Size = new System.Drawing.Size(611, 150);
            this.pnlCtrlNhanVien.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtEdtID);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtEdtMobilePhone);
            this.panelControl2.Controls.Add(this.dtpBirthday);
            this.panelControl2.Controls.Add(this.rdoFemale);
            this.panelControl2.Controls.Add(this.rdoMale);
            this.panelControl2.Controls.Add(this.txtEdtFullName);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(269, 146);
            this.panelControl2.TabIndex = 0;
            // 
            // txtEdtID
            // 
            this.txtEdtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtID.EditValue = "";
            this.txtEdtID.Location = new System.Drawing.Point(79, 10);
            this.txtEdtID.Name = "txtEdtID";
            this.txtEdtID.Properties.ReadOnly = true;
            this.txtEdtID.Size = new System.Drawing.Size(93, 20);
            this.txtEdtID.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Mã nhân viên";
            // 
            // txtEdtMobilePhone
            // 
            this.txtEdtMobilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtMobilePhone.EditValue = "";
            this.txtEdtMobilePhone.Location = new System.Drawing.Point(79, 116);
            this.txtEdtMobilePhone.Name = "txtEdtMobilePhone";
            this.txtEdtMobilePhone.Properties.MaxLength = 11;
            this.txtEdtMobilePhone.Size = new System.Drawing.Size(93, 20);
            this.txtEdtMobilePhone.TabIndex = 10;
            this.txtEdtMobilePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdtMobilePhone_KeyPress);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(79, 89);
            this.dtpBirthday.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(93, 21);
            this.dtpBirthday.TabIndex = 8;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(139, 65);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(39, 17);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(79, 65);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(46, 17);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtEdtFullName
            // 
            this.txtEdtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtFullName.EditValue = "";
            this.txtEdtFullName.Location = new System.Drawing.Point(79, 36);
            this.txtEdtFullName.Name = "txtEdtFullName";
            this.txtEdtFullName.Properties.MaxLength = 30;
            this.txtEdtFullName.Size = new System.Drawing.Size(181, 20);
            this.txtEdtFullName.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Giới tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Ngày sinh";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Họ tên";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splBtnExport);
            this.panelControl1.Controls.Add(this.splBtnPrint);
            this.panelControl1.Controls.Add(this.splBtnGet);
            this.panelControl1.Controls.Add(this.splBtnDelete);
            this.panelControl1.Controls.Add(this.splBtnAdd);
            this.panelControl1.Controls.Add(this.splBtnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(271, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(338, 146);
            this.panelControl1.TabIndex = 1;
            // 
            // splBtnExport
            // 
            this.splBtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnExport.ImageOptions.Image")));
            this.splBtnExport.Location = new System.Drawing.Point(91, 78);
            this.splBtnExport.Name = "splBtnExport";
            this.splBtnExport.Size = new System.Drawing.Size(75, 23);
            this.splBtnExport.TabIndex = 5;
            this.splBtnExport.Text = "Xuất";
            this.splBtnExport.Click += new System.EventHandler(this.splBtnExport_Click);
            // 
            // splBtnPrint
            // 
            this.splBtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnPrint.ImageOptions.Image")));
            this.splBtnPrint.Location = new System.Drawing.Point(10, 78);
            this.splBtnPrint.Name = "splBtnPrint";
            this.splBtnPrint.Size = new System.Drawing.Size(75, 23);
            this.splBtnPrint.TabIndex = 4;
            this.splBtnPrint.Text = "In ấn";
            this.splBtnPrint.Click += new System.EventHandler(this.splBtnPrint_Click);
            // 
            // splBtnGet
            // 
            this.splBtnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnGet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnGet.ImageOptions.Image")));
            this.splBtnGet.Location = new System.Drawing.Point(10, 44);
            this.splBtnGet.Name = "splBtnGet";
            this.splBtnGet.Size = new System.Drawing.Size(75, 23);
            this.splBtnGet.TabIndex = 0;
            this.splBtnGet.Text = "Hiển thị";
            this.splBtnGet.Click += new System.EventHandler(this.splBtnGet_Click);
            // 
            // splBtnDelete
            // 
            this.splBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnDelete.ImageOptions.Image")));
            this.splBtnDelete.Location = new System.Drawing.Point(253, 44);
            this.splBtnDelete.Name = "splBtnDelete";
            this.splBtnDelete.Size = new System.Drawing.Size(75, 23);
            this.splBtnDelete.TabIndex = 3;
            this.splBtnDelete.Text = "Xoá";
            this.splBtnDelete.Click += new System.EventHandler(this.splBtnDelete_Click);
            // 
            // splBtnAdd
            // 
            this.splBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnAdd.ImageOptions.Image")));
            this.splBtnAdd.Location = new System.Drawing.Point(91, 44);
            this.splBtnAdd.Name = "splBtnAdd";
            this.splBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.splBtnAdd.TabIndex = 1;
            this.splBtnAdd.Text = "Thêm";
            this.splBtnAdd.Click += new System.EventHandler(this.splBtnAdd_Click);
            // 
            // splBtnSave
            // 
            this.splBtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnSave.ImageOptions.Image")));
            this.splBtnSave.Location = new System.Drawing.Point(172, 44);
            this.splBtnSave.Name = "splBtnSave";
            this.splBtnSave.Size = new System.Drawing.Size(75, 23);
            this.splBtnSave.TabIndex = 2;
            this.splBtnSave.Text = "Lưu";
            this.splBtnSave.Click += new System.EventHandler(this.splBtnSave_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(78, 244);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(2, 162);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(611, 262);
            this.gridSplitContainer1.TabIndex = 3;
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(615, 426);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlNhanVien)).EndInit();
            this.pnlCtrlNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMobilePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl pnlCtrlNhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtMobilePhone;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private DevExpress.XtraEditors.TextEdit txtEdtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton splBtnPrint;
        private DevExpress.XtraEditors.SimpleButton splBtnGet;
        private DevExpress.XtraEditors.SimpleButton splBtnDelete;
        private DevExpress.XtraEditors.SimpleButton splBtnAdd;
        private DevExpress.XtraEditors.SimpleButton splBtnSave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEdtID;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private DevExpress.XtraEditors.SimpleButton splBtnExport;
    }
}
