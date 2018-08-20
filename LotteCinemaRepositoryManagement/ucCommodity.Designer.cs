namespace LotteCinemaRepositoryManagement
{
    partial class ucCommodity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCommodity));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.pnlCtrlNhanVien = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtEdtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtCalculationUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splBtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnGet = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlNhanVien)).BeginInit();
            this.pnlCtrlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtCalculationUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvCommodity);
            this.groupControl1.Controls.Add(this.pnlCtrlNhanVien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(615, 426);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hàng hoá";
            // 
            // dgvCommodity
            // 
            this.dgvCommodity.AllowUserToAddRows = false;
            this.dgvCommodity.AllowUserToDeleteRows = false;
            this.dgvCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommodity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvCommodity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommodity.Location = new System.Drawing.Point(2, 115);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.ReadOnly = true;
            this.dgvCommodity.Size = new System.Drawing.Size(611, 309);
            this.dgvCommodity.TabIndex = 0;
            this.dgvCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommodity_CellContentClick);
            // 
            // pnlCtrlNhanVien
            // 
            this.pnlCtrlNhanVien.Controls.Add(this.panelControl2);
            this.pnlCtrlNhanVien.Controls.Add(this.panelControl1);
            this.pnlCtrlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlNhanVien.Location = new System.Drawing.Point(2, 20);
            this.pnlCtrlNhanVien.Name = "pnlCtrlNhanVien";
            this.pnlCtrlNhanVien.Size = new System.Drawing.Size(611, 95);
            this.pnlCtrlNhanVien.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtEdtID);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtEdtCalculationUnit);
            this.panelControl2.Controls.Add(this.txtEdtName);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(269, 91);
            this.panelControl2.TabIndex = 0;
            // 
            // txtEdtID
            // 
            this.txtEdtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtID.EditValue = "";
            this.txtEdtID.Location = new System.Drawing.Point(80, 10);
            this.txtEdtID.Name = "txtEdtID";
            this.txtEdtID.Properties.ReadOnly = true;
            this.txtEdtID.Size = new System.Drawing.Size(93, 20);
            this.txtEdtID.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Mã hàng hoá";
            // 
            // txtEdtCalculationUnit
            // 
            this.txtEdtCalculationUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtCalculationUnit.EditValue = "";
            this.txtEdtCalculationUnit.Location = new System.Drawing.Point(80, 61);
            this.txtEdtCalculationUnit.Name = "txtEdtCalculationUnit";
            this.txtEdtCalculationUnit.Properties.MaxLength = 20;
            this.txtEdtCalculationUnit.Size = new System.Drawing.Size(93, 20);
            this.txtEdtCalculationUnit.TabIndex = 7;
            // 
            // txtEdtName
            // 
            this.txtEdtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtName.EditValue = "";
            this.txtEdtName.Location = new System.Drawing.Point(80, 36);
            this.txtEdtName.Name = "txtEdtName";
            this.txtEdtName.Properties.MaxLength = 30;
            this.txtEdtName.Size = new System.Drawing.Size(180, 20);
            this.txtEdtName.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Đơn vị tính";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên hàng hoá";
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
            this.panelControl1.Size = new System.Drawing.Size(338, 91);
            this.panelControl1.TabIndex = 1;
            // 
            // splBtnPrint
            // 
            this.splBtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnPrint.ImageOptions.Image")));
            this.splBtnPrint.Location = new System.Drawing.Point(10, 51);
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
            this.splBtnGet.Location = new System.Drawing.Point(10, 17);
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
            this.splBtnDelete.Location = new System.Drawing.Point(253, 17);
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
            this.splBtnAdd.Location = new System.Drawing.Point(91, 17);
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
            this.splBtnSave.Location = new System.Drawing.Point(172, 17);
            this.splBtnSave.Name = "splBtnSave";
            this.splBtnSave.Size = new System.Drawing.Size(75, 23);
            this.splBtnSave.TabIndex = 2;
            this.splBtnSave.Text = "Lưu";
            this.splBtnSave.Click += new System.EventHandler(this.splBtnSave_Click);
            // 
            // splBtnExport
            // 
            this.splBtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnExport.ImageOptions.Image")));
            this.splBtnExport.Location = new System.Drawing.Point(91, 52);
            this.splBtnExport.Name = "splBtnExport";
            this.splBtnExport.Size = new System.Drawing.Size(75, 23);
            this.splBtnExport.TabIndex = 5;
            this.splBtnExport.Text = "Xuất";
            this.splBtnExport.Click += new System.EventHandler(this.splBtnExport_Click);
            // 
            // ucCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucCommodity";
            this.Size = new System.Drawing.Size(615, 426);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlNhanVien)).EndInit();
            this.pnlCtrlNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtCalculationUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvCommodity;
        private DevExpress.XtraEditors.PanelControl pnlCtrlNhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEdtCalculationUnit;
        private DevExpress.XtraEditors.TextEdit txtEdtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton splBtnPrint;
        private DevExpress.XtraEditors.SimpleButton splBtnGet;
        private DevExpress.XtraEditors.SimpleButton splBtnDelete;
        private DevExpress.XtraEditors.SimpleButton splBtnAdd;
        private DevExpress.XtraEditors.SimpleButton splBtnSave;
        private DevExpress.XtraEditors.SimpleButton splBtnExport;
    }
}
