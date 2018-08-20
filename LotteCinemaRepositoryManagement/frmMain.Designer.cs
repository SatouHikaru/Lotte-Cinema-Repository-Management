namespace LotteCinemaRepositoryManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnItmNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmNhaCungCap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmQuanTri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmXuatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmThongKeHangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmThongKeHangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmHoaDonGiaoHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItmNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbnPgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbnPgGrpTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbnPgGrpManagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbnPgQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbnPgGrpMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbnPgGrpKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbnPgGrpThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.SttLblTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttLblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnItmNhanVien,
            this.barBtnItmHangHoa,
            this.barBtnItmNhaCungCap,
            this.barBtnItmQuanTri,
            this.barBtnItmDoiMatKhau,
            this.barBtnItmDangXuat,
            this.barBtnItmXuatHang,
            this.barBtnItmThongKeHangNhap,
            this.barBtnItmThongKeHangXuat,
            this.barBtnItmDonDatHang,
            this.barBtnItmHoaDonGiaoHang,
            this.barBtnItmNhapKho,
            this.barBtnItmNhapHang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbnPgHeThong,
            this.ribbnPgQuanLy});
            this.ribbonControl1.Size = new System.Drawing.Size(898, 143);
            // 
            // barBtnItmNhanVien
            // 
            this.barBtnItmNhanVien.Caption = "Nhân viên";
            this.barBtnItmNhanVien.Id = 1;
            this.barBtnItmNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhanVien.ImageOptions.Image")));
            this.barBtnItmNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhanVien.ImageOptions.LargeImage")));
            this.barBtnItmNhanVien.Name = "barBtnItmNhanVien";
            this.barBtnItmNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmEmployee_ItemClick);
            // 
            // barBtnItmHangHoa
            // 
            this.barBtnItmHangHoa.Caption = "Hàng hoá";
            this.barBtnItmHangHoa.Id = 2;
            this.barBtnItmHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmHangHoa.ImageOptions.Image")));
            this.barBtnItmHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmHangHoa.ImageOptions.LargeImage")));
            this.barBtnItmHangHoa.Name = "barBtnItmHangHoa";
            this.barBtnItmHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmCommodity_ItemClick);
            // 
            // barBtnItmNhaCungCap
            // 
            this.barBtnItmNhaCungCap.Caption = "Nhà cung cấp";
            this.barBtnItmNhaCungCap.Id = 3;
            this.barBtnItmNhaCungCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhaCungCap.ImageOptions.Image")));
            this.barBtnItmNhaCungCap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhaCungCap.ImageOptions.LargeImage")));
            this.barBtnItmNhaCungCap.LargeWidth = 77;
            this.barBtnItmNhaCungCap.Name = "barBtnItmNhaCungCap";
            this.barBtnItmNhaCungCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmSupplier_ItemClick);
            // 
            // barBtnItmQuanTri
            // 
            this.barBtnItmQuanTri.Caption = "Quản trị";
            this.barBtnItmQuanTri.Id = 4;
            this.barBtnItmQuanTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmQuanTri.ImageOptions.Image")));
            this.barBtnItmQuanTri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmQuanTri.ImageOptions.LargeImage")));
            this.barBtnItmQuanTri.LargeWidth = 70;
            this.barBtnItmQuanTri.Name = "barBtnItmQuanTri";
            this.barBtnItmQuanTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmDecentralization_ItemClick);
            // 
            // barBtnItmDoiMatKhau
            // 
            this.barBtnItmDoiMatKhau.Caption = "Đổi mật khẩu";
            this.barBtnItmDoiMatKhau.Id = 5;
            this.barBtnItmDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmDoiMatKhau.ImageOptions.Image")));
            this.barBtnItmDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmDoiMatKhau.ImageOptions.LargeImage")));
            this.barBtnItmDoiMatKhau.LargeWidth = 75;
            this.barBtnItmDoiMatKhau.Name = "barBtnItmDoiMatKhau";
            this.barBtnItmDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmPassword_ItemClick);
            // 
            // barBtnItmDangXuat
            // 
            this.barBtnItmDangXuat.Caption = "Đăng xuất";
            this.barBtnItmDangXuat.Id = 6;
            this.barBtnItmDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmDangXuat.ImageOptions.LargeImage")));
            this.barBtnItmDangXuat.Name = "barBtnItmDangXuat";
            this.barBtnItmDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmLogout_ItemClick);
            // 
            // barBtnItmXuatHang
            // 
            this.barBtnItmXuatHang.Caption = "Xuất hàng";
            this.barBtnItmXuatHang.Id = 9;
            this.barBtnItmXuatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmXuatHang.ImageOptions.Image")));
            this.barBtnItmXuatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmXuatHang.ImageOptions.LargeImage")));
            this.barBtnItmXuatHang.Name = "barBtnItmXuatHang";
            this.barBtnItmXuatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmGoodsIssue_ItemClick);
            // 
            // barBtnItmThongKeHangNhap
            // 
            this.barBtnItmThongKeHangNhap.Caption = "Hàng nhập";
            this.barBtnItmThongKeHangNhap.Id = 10;
            this.barBtnItmThongKeHangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmThongKeHangNhap.ImageOptions.Image")));
            this.barBtnItmThongKeHangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmThongKeHangNhap.ImageOptions.LargeImage")));
            this.barBtnItmThongKeHangNhap.Name = "barBtnItmThongKeHangNhap";
            this.barBtnItmThongKeHangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmThongKeHangNhap_ItemClick);
            // 
            // barBtnItmThongKeHangXuat
            // 
            this.barBtnItmThongKeHangXuat.Caption = "Hàng xuất";
            this.barBtnItmThongKeHangXuat.Id = 13;
            this.barBtnItmThongKeHangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmThongKeHangXuat.ImageOptions.Image")));
            this.barBtnItmThongKeHangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmThongKeHangXuat.ImageOptions.LargeImage")));
            this.barBtnItmThongKeHangXuat.Name = "barBtnItmThongKeHangXuat";
            this.barBtnItmThongKeHangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmThongKeHangXuat_ItemClick);
            // 
            // barBtnItmDonDatHang
            // 
            this.barBtnItmDonDatHang.Id = 22;
            this.barBtnItmDonDatHang.Name = "barBtnItmDonDatHang";
            // 
            // barBtnItmHoaDonGiaoHang
            // 
            this.barBtnItmHoaDonGiaoHang.Id = 23;
            this.barBtnItmHoaDonGiaoHang.Name = "barBtnItmHoaDonGiaoHang";
            // 
            // barBtnItmNhapKho
            // 
            this.barBtnItmNhapKho.Caption = "Nhập kho";
            this.barBtnItmNhapKho.Id = 20;
            this.barBtnItmNhapKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhapKho.ImageOptions.Image")));
            this.barBtnItmNhapKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhapKho.ImageOptions.LargeImage")));
            this.barBtnItmNhapKho.Name = "barBtnItmNhapKho";
            // 
            // barBtnItmNhapHang
            // 
            this.barBtnItmNhapHang.Caption = "Nhập hàng";
            this.barBtnItmNhapHang.Id = 21;
            this.barBtnItmNhapHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhapHang.ImageOptions.Image")));
            this.barBtnItmNhapHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItmNhapHang.ImageOptions.LargeImage")));
            this.barBtnItmNhapHang.Name = "barBtnItmNhapHang";
            this.barBtnItmNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItmGoodsReceipt_ItemClick);
            // 
            // ribbonPageCategory
            // 
            this.ribbonPageCategory.Name = "ribbonPageCategory";
            // 
            // ribbnPgHeThong
            // 
            this.ribbnPgHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbnPgGrpTaiKhoan,
            this.ribbnPgGrpManagement});
            this.ribbnPgHeThong.Name = "ribbnPgHeThong";
            this.ribbnPgHeThong.Text = "Hệ thống";
            // 
            // ribbnPgGrpTaiKhoan
            // 
            this.ribbnPgGrpTaiKhoan.ItemLinks.Add(this.barBtnItmDoiMatKhau);
            this.ribbnPgGrpTaiKhoan.ItemLinks.Add(this.barBtnItmDangXuat);
            this.ribbnPgGrpTaiKhoan.Name = "ribbnPgGrpTaiKhoan";
            this.ribbnPgGrpTaiKhoan.Text = "Tài khoản";
            // 
            // ribbnPgGrpQuanTri
            // 
            this.ribbnPgGrpManagement.ItemLinks.Add(this.barBtnItmQuanTri);
            this.ribbnPgGrpManagement.Name = "ribbnPgGrpQuanTri";
            this.ribbnPgGrpManagement.Text = "Quản trị";
            // 
            // ribbnPgQuanLy
            // 
            this.ribbnPgQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbnPgGrpMenu,
            this.ribbnPgGrpKho,
            this.ribbnPgGrpThongKe});
            this.ribbnPgQuanLy.Name = "ribbnPgQuanLy";
            this.ribbnPgQuanLy.Text = "Quản lý";
            // 
            // ribbnPgGrpDanhMuc
            // 
            this.ribbnPgGrpMenu.ItemLinks.Add(this.barBtnItmNhaCungCap);
            this.ribbnPgGrpMenu.ItemLinks.Add(this.barBtnItmHangHoa);
            this.ribbnPgGrpMenu.ItemLinks.Add(this.barBtnItmNhanVien);
            this.ribbnPgGrpMenu.Name = "ribbnPgGrpDanhMuc";
            this.ribbnPgGrpMenu.Text = "Danh mục";
            // 
            // ribbnPgGrpKho
            // 
            this.ribbnPgGrpKho.ItemLinks.Add(this.barBtnItmNhapHang);
            this.ribbnPgGrpKho.ItemLinks.Add(this.barBtnItmXuatHang);
            this.ribbnPgGrpKho.Name = "ribbnPgGrpKho";
            this.ribbnPgGrpKho.Text = "Kho";
            // 
            // ribbnPgGrpThongKe
            // 
            this.ribbnPgGrpThongKe.ItemLinks.Add(this.barBtnItmThongKeHangNhap);
            this.ribbnPgGrpThongKe.ItemLinks.Add(this.barBtnItmThongKeHangXuat);
            this.ribbnPgGrpThongKe.Name = "ribbnPgGrpThongKe";
            this.ribbnPgGrpThongKe.Text = "Thống kê";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhân viên";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Xuất kho";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.statusStrip);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 143);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(898, 510);
            this.panelControl.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SttLblTen,
            this.sttLblThoiGian});
            this.statusStrip.Location = new System.Drawing.Point(2, 484);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(894, 24);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // SttLblTen
            // 
            this.SttLblTen.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SttLblTen.Name = "SttLblTen";
            this.SttLblTen.Size = new System.Drawing.Size(82, 19);
            this.SttLblTen.Text = "Tên tài khoản";
            // 
            // SttLblThoiGian
            // 
            this.sttLblThoiGian.Name = "SttLblThoiGian";
            this.sttLblThoiGian.Size = new System.Drawing.Size(57, 19);
            this.sttLblThoiGian.Text = "Thời gian";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 653);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(908, 658);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý kho Lotte Cinema";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnItmNhanVien;
        private DevExpress.XtraBars.BarButtonItem barBtnItmHangHoa;
        private DevExpress.XtraBars.BarButtonItem barBtnItmNhaCungCap;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbnPgQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbnPgGrpMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbnPgGrpKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbnPgGrpThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbnPgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbnPgGrpTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbnPgGrpManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnItmQuanTri;
        private DevExpress.XtraBars.BarButtonItem barBtnItmDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem barBtnItmDangXuat;
        private DevExpress.XtraBars.BarButtonItem barBtnItmXuatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnItmThongKeHangNhap;
        private DevExpress.XtraBars.BarButtonItem barBtnItmThongKeHangXuat;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory;
        private DevExpress.XtraBars.BarButtonItem barBtnItmDonDatHang;
        private DevExpress.XtraBars.BarButtonItem barBtnItmHoaDonGiaoHang;
        private DevExpress.XtraBars.BarButtonItem barBtnItmNhapKho;
        private DevExpress.XtraBars.BarButtonItem barBtnItmNhapHang;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SttLblTen;
        private System.Windows.Forms.ToolStripStatusLabel sttLblThoiGian;
        private System.Windows.Forms.Timer timer;
    }
}

