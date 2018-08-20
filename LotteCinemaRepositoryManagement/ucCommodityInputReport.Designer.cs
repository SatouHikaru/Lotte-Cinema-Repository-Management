namespace LotteCinemaRepositoryManagement
{
    partial class ucCommodityInputReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCommodityInputReport));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dgvPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.pnlCtrlNhanVien = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splBtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.splBtnGet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlNhanVien)).BeginInit();
            this.pnlCtrlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvReport);
            this.groupControl1.Controls.Add(this.dgvPhieuNhapKho);
            this.groupControl1.Controls.Add(this.pnlCtrlNhanVien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(870, 426);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Báo cáo hàng nhập";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(2, 63);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(866, 361);
            this.dgvReport.TabIndex = 0;
            // 
            // dgvPhieuNhapKho
            // 
            this.dgvPhieuNhapKho.AllowUserToAddRows = false;
            this.dgvPhieuNhapKho.AllowUserToDeleteRows = false;
            this.dgvPhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhapKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvPhieuNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhapKho.Location = new System.Drawing.Point(2, 63);
            this.dgvPhieuNhapKho.Name = "dgvPhieuNhapKho";
            this.dgvPhieuNhapKho.ReadOnly = true;
            this.dgvPhieuNhapKho.Size = new System.Drawing.Size(866, 361);
            this.dgvPhieuNhapKho.TabIndex = 3;
            // 
            // pnlCtrlNhanVien
            // 
            this.pnlCtrlNhanVien.Controls.Add(this.panelControl2);
            this.pnlCtrlNhanVien.Controls.Add(this.panelControl1);
            this.pnlCtrlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlNhanVien.Location = new System.Drawing.Point(2, 20);
            this.pnlCtrlNhanVien.Name = "pnlCtrlNhanVien";
            this.pnlCtrlNhanVien.Size = new System.Drawing.Size(866, 43);
            this.pnlCtrlNhanVien.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.textEdit1);
            this.panelControl2.Controls.Add(this.txtEdtTotalAmount);
            this.panelControl2.Controls.Add(this.dtpTimeEnd);
            this.panelControl2.Controls.Add(this.dtpTimeStart);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(611, 39);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(426, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Tổng tiền";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.EditValue = "VNĐ";
            this.textEdit1.Location = new System.Drawing.Point(574, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEdit1.Size = new System.Drawing.Size(28, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // txtEdtTotalAmount
            // 
            this.txtEdtTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdtTotalAmount.EditValue = "";
            this.txtEdtTotalAmount.Location = new System.Drawing.Point(477, 9);
            this.txtEdtTotalAmount.Name = "txtEdtTotalAmount";
            this.txtEdtTotalAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEdtTotalAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEdtTotalAmount.Properties.ReadOnly = true;
            this.txtEdtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEdtTotalAmount.Size = new System.Drawing.Size(98, 20);
            this.txtEdtTotalAmount.TabIndex = 4;
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeEnd.Location = new System.Drawing.Point(307, 9);
            this.dtpTimeEnd.MinDate = new System.DateTime(2003, 1, 2, 0, 0, 0, 0);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(76, 21);
            this.dtpTimeEnd.TabIndex = 3;
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeStart.Location = new System.Drawing.Point(98, 9);
            this.dtpTimeStart.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(76, 21);
            this.dtpTimeStart.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Thời gian bắt đầu";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(216, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Thời gian kết thúc";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splBtnExport);
            this.panelControl1.Controls.Add(this.splBtnPrint);
            this.panelControl1.Controls.Add(this.splBtnGet);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(613, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(251, 39);
            this.panelControl1.TabIndex = 15;
            // 
            // splBtnExport
            // 
            this.splBtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnExport.ImageOptions.Image")));
            this.splBtnExport.Location = new System.Drawing.Point(169, 8);
            this.splBtnExport.Name = "splBtnExport";
            this.splBtnExport.Size = new System.Drawing.Size(75, 23);
            this.splBtnExport.TabIndex = 2;
            this.splBtnExport.Text = "Xuất";
            this.splBtnExport.Click += new System.EventHandler(this.splBtnExport_Click);
            // 
            // splBtnPrint
            // 
            this.splBtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnPrint.ImageOptions.Image")));
            this.splBtnPrint.Location = new System.Drawing.Point(88, 8);
            this.splBtnPrint.Name = "splBtnPrint";
            this.splBtnPrint.Size = new System.Drawing.Size(75, 23);
            this.splBtnPrint.TabIndex = 1;
            this.splBtnPrint.Text = "In ấn";
            this.splBtnPrint.Click += new System.EventHandler(this.splBtnPrint_Click);
            // 
            // splBtnGet
            // 
            this.splBtnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splBtnGet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("splBtnGet.ImageOptions.Image")));
            this.splBtnGet.Location = new System.Drawing.Point(7, 8);
            this.splBtnGet.Name = "splBtnGet";
            this.splBtnGet.Size = new System.Drawing.Size(75, 23);
            this.splBtnGet.TabIndex = 0;
            this.splBtnGet.Text = "Hiển thị";
            this.splBtnGet.Click += new System.EventHandler(this.splBtnGet_Click);
            // 
            // ucCommodityInputReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucCommodityInputReport";
            this.Size = new System.Drawing.Size(870, 426);
            this.Load += new System.EventHandler(this.ucCommodityInputReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlNhanVien)).EndInit();
            this.pnlCtrlNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvPhieuNhapKho;
        private DevExpress.XtraEditors.PanelControl pnlCtrlNhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton splBtnPrint;
        private DevExpress.XtraEditors.SimpleButton splBtnGet;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtEdtTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton splBtnExport;
    }
}
