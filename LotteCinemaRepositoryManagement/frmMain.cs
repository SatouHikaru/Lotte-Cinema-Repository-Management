using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool hasSupplierChanged = false;
        bool hasChanged = false;
        bool hasChecked = false;
        string username;

        public frmMain(string username, string name, string role)
        {
            InitializeComponent();

            this.username = username;
            SttLblTen.Text = name;
            if (role == "Quản lý")
                ribbnPgGrpManagement.Enabled = false;
            else if (role == "Giám sát")
            {
                ribbnPgGrpManagement.Enabled = false;
                ribbnPgGrpMenu.Enabled = false;
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            sttLblThoiGian.Text = String.Format("Bây giờ là {0} " +
                                                "ngày {1} tháng {2} năm {3}",
                                                DateTime.Now.ToString("HH:mm:ss"),
                                                DateTime.Now.Day,
                                                DateTime.Now.Month,
                                                DateTime.Now.Year);
        }

        private void barBtnItmPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucPassword.Instance.account.Username = username;
            if (!panelControl.Controls.Contains(ucPassword.Instance))
            {
                panelControl.Controls.Add(ucPassword.Instance);
                ucPassword.Instance.Dock = DockStyle.Fill;
            }
            ucPassword.Instance.BringToFront();
        }

        private void barBtnItmLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barBtnItmDecentralization_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucManagement.Instance))
            {
                panelControl.Controls.Add(ucManagement.Instance);
                ucManagement.Instance.Dock = DockStyle.Fill;
                hasChecked = true;
            }
            else
                ucManagement.Instance.LoadData();
            ucManagement.Instance.BringToFront();
        }

        private void barBtnItmSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucSupplier.Instance))
            {
                panelControl.Controls.Add(ucSupplier.Instance);
                ucSupplier.Instance.Dock = DockStyle.Fill;
                hasSupplierChanged = true;
            }
            else if (!hasChecked)
                ucSupplier.Instance.GetAll();
            ucSupplier.Instance.BringToFront();
        }

        private void barBtnItmCommodity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucCommodity.Instance))
            {
                panelControl.Controls.Add(ucCommodity.Instance);
                ucCommodity.Instance.Dock = DockStyle.Fill;
                hasChanged = true;
            }
            else
                ucCommodity.Instance.GetAll();
            ucCommodity.Instance.BringToFront();
        }

        private void barBtnItmEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucEmployee.Instance))
            {
                panelControl.Controls.Add(ucEmployee.Instance);
                ucEmployee.Instance.Dock = DockStyle.Fill;
                hasChanged = true;
            }
            else if (!hasChecked)
                ucEmployee.Instance.GetAll();
            ucEmployee.Instance.BringToFront();
        }

        private void barBtnItmGoodsReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucGoodsReceiptNote.Instance))
            {
                panelControl.Controls.Add(ucGoodsReceiptNote.Instance);
                ucGoodsReceiptNote.Instance.Dock = DockStyle.Fill;
            }
            else if (hasSupplierChanged || hasChanged || hasChecked)
                ucGoodsReceiptNote.Instance.Get();
            ucGoodsReceiptNote.Instance.BringToFront();
        }

        private void barBtnItmGoodsIssue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucGoodsIssueNote.Instance))
            {
                panelControl.Controls.Add(ucGoodsIssueNote.Instance);
                ucGoodsIssueNote.Instance.Dock = DockStyle.Fill;
            }
            else if (hasChanged || hasChecked)
                ucGoodsIssueNote.Instance.Get();
            ucGoodsIssueNote.Instance.BringToFront();
        }

        private void barBtnItmThongKeHangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucCommodityInputReport.Instance))
            {
                panelControl.Controls.Add(ucCommodityInputReport.Instance);
                ucCommodityInputReport.Instance.Dock = DockStyle.Fill;
            }
            ucCommodityInputReport.Instance.BringToFront();
        }

        private void barBtnItmThongKeHangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelControl.Controls.Contains(ucCommodityOutputReport.Instance))
            {
                panelControl.Controls.Add(ucCommodityOutputReport.Instance);
                ucCommodityOutputReport.Instance.Dock = DockStyle.Fill;
            }
            ucCommodityOutputReport.Instance.BringToFront();
        }
    }
}