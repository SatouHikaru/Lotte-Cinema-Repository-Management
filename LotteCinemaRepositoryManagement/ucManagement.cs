using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using DevExpress.XtraEditors;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucManagement : UserControl
    {
        Supplier supplier = new Supplier();
        SupplierBLL supplierBLL = new SupplierBLL();

        Commodity commodity = new Commodity();
        CommodityBLL commodityBLL = new CommodityBLL();

        Employee employee = new Employee();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        GoodsReceiptNote goodsReceiptNote = new GoodsReceiptNote();
        GoodsReceiptNoteBLL goodsReceiptNoteBLL = new GoodsReceiptNoteBLL();

        GoodsIssueNote goodsIssueNote = new GoodsIssueNote();
        GoodsIssueNoteBLL goodsIssueNoteBLL = new GoodsIssueNoteBLL();

        Account account = new Account();
        AccountBLL accountBLL = new AccountBLL();

        public ucManagement()
        {
            InitializeComponent();
        }

        private static ucManagement instance;
        public static ucManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucManagement();
                return instance;
            }
        }

        private void ucManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            if (tabPaneAdmin.SelectedPage == tabNavigationPageSupplier)
                dgvAdminSupplier.DataSource = supplierBLL.Display();
            else if (tabPaneAdmin.SelectedPage == tabNavigationPageCommodity)
                dgvAdminCommodity.DataSource = commodityBLL.Display();
            else if (tabPaneAdmin.SelectedPage == tabNavigationPageEmployee)
                dgvAdminEmployee.DataSource = employeeBLL.Display();
            else if (tabPaneAdmin.SelectedPage == tabNavigationPageGoodsReceiptNote)
                dgvAdminGoodsReceiptNote.DataSource = goodsReceiptNoteBLL.Display();
            else if (tabPaneAdmin.SelectedPage == tabNavigationPageGoodsReceiptNoteDetails)
                dgvAdminGoodsReceiptNoteDetails.DataSource = goodsReceiptNoteBLL.DisplayDetails();
            else if (tabPaneAdmin.SelectedPage == tabNavigationPageGoodsIssueNote)
                dgvAdminGoodsIssueNote.DataSource = goodsIssueNoteBLL.Display();
            else if (tabPaneAdmin.SelectedPage == tabNavigationPageGoodsIssueNoteDetails)
                dgvAdminGoodsIssueNoteDetails.DataSource = goodsIssueNoteBLL.DisplayDetails();
            else
                GetAccount();
        }

        void GetAccount()
        {
            dgvAdminAccount.DataSource = accountBLL.GetAll();
        }

        private void tabPaneAdmin_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            LoadData();
        }

        #region Supplier
        private void splBtnSupplierRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục nhà cung cấp " + dgvAdminSupplier["Tên nhà cung cấp", dgvAdminSupplier.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminSupplier.CurrentRow.Index;
                try
                {
                    if (dgvAdminSupplier["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        GetSupplierData(rowIndex);
                        supplierBLL.Recover(supplier);
                        XtraMessageBox.Show("Đã khôi phục nhà cung cấp " + supplier.Name, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminSupplier["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        GetSupplierData(rowIndex);
                        supplierBLL.Update(supplier);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin nhà cung cấp " + supplier.Name, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    supplier.Name = dgvAdminSupplier["Tên nhà cung cấp", rowIndex].Value.ToString();
                    XtraMessageBox.Show("Đã khôi phục lại thông tin nhà cung cấp " + supplier.Name + " rồi" , "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        void GetSupplierData(int rowIndex)
        {
            supplier.ID = dgvAdminSupplier["Mã nhà cung cấp", rowIndex].Value.ToString();
            supplier.Name = dgvAdminSupplier["Tên nhà cung cấp", rowIndex].Value.ToString();
            supplier.PhoneNumber = dgvAdminSupplier["Số điện thoại", rowIndex].Value.ToString();
            supplier.Address = dgvAdminSupplier["Địa chỉ", rowIndex].Value.ToString();
        }
        #endregion

        #region Commodity
        private void splBtnCommodityRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục hàng hoá " + dgvAdminCommodity["Tên hàng hoá", dgvAdminCommodity.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminCommodity.CurrentRow.Index;
                try
                {
                    if (dgvAdminCommodity["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        GetCommodityData(rowIndex);
                        commodityBLL.Recover(commodity);
                        XtraMessageBox.Show("Đã khôi phục hàng hoá " + commodity.Name, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminCommodity["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        GetCommodityData(rowIndex);
                        commodityBLL.Update(commodity);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin hàng hoá " + commodity.Name, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    commodity.Name = dgvAdminCommodity["Tên hàng hoá", rowIndex].Value.ToString();
                    XtraMessageBox.Show("Đã khôi phục lại thông tin hàng hoá " + commodity.Name + " rồi", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void GetCommodityData(int rowIndex)
        {
            commodity.ID = dgvAdminCommodity["Mã hàng hoá", rowIndex].Value.ToString();
            commodity.Name = dgvAdminCommodity["Tên hàng hoá", rowIndex].Value.ToString();
            commodity.Quantity = int.Parse(dgvAdminCommodity["Số lượng", rowIndex].Value.ToString());
            commodity.CalculationUnit = dgvAdminCommodity["Đơn vị tính", rowIndex].Value.ToString();
        }
        #endregion

        #region Employee
        private void splBtnEmployeeRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục nhân viên " + dgvAdminEmployee["Họ tên", dgvAdminEmployee.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminEmployee.CurrentRow.Index;
                try
                {
                    if (dgvAdminEmployee["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        GetEmployeeData(rowIndex);
                        employeeBLL.Recover(employee);
                        XtraMessageBox.Show("Đã khôi phục nhân viên " + employee.FullName, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminEmployee["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        GetEmployeeData(rowIndex);
                        employeeBLL.Update(employee);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin nhân viên " + employee.FullName, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    employee.FullName = dgvAdminEmployee["Họ tên", rowIndex].Value.ToString();
                    XtraMessageBox.Show("Đã khôi phục lại thông tin nhân viên " + employee.FullName + " rồi", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void GetEmployeeData(int rowIndex)
        {
            employee.ID = dgvAdminEmployee["Mã nhân viên", rowIndex].Value.ToString();
            employee.FullName = dgvAdminEmployee["Họ tên", rowIndex].Value.ToString();
            employee.Birthday = (DateTime)dgvAdminEmployee["Ngày sinh", rowIndex].Value;
            employee.Gender = (bool)dgvAdminEmployee["Giới tính", rowIndex].Value;
            employee.MobilePhone = dgvAdminEmployee["Điện thoại", rowIndex].Value.ToString();
        }
        #endregion

        #region Goods Receipt Note
        private void splBtnGoodsReceiptNoteRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục phiếu nhập kho ngày " + dgvAdminGoodsReceiptNote["Ngày nhập", dgvAdminGoodsReceiptNote.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminGoodsReceiptNote.CurrentRow.Index;
                try
                {
                    if (dgvAdminGoodsReceiptNote["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        GetGoodsReceiptNoteData(rowIndex);
                        goodsReceiptNoteBLL.Recover(goodsReceiptNote);
                        XtraMessageBox.Show("Đã khôi phục phiếu nhập kho ngày " + goodsReceiptNote.GRN_No, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminGoodsReceiptNote["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        GetGoodsReceiptNoteData(rowIndex);
                        goodsReceiptNoteBLL.Update(goodsReceiptNote);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin phiếu nhập kho ngày " + goodsReceiptNote.GRN_No, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    goodsReceiptNote.Date = (DateTime)dgvAdminGoodsReceiptNote["Ngày nhập", rowIndex].Value;
                    XtraMessageBox.Show("Đã khôi phục lại thông tin phiếu nhập kho ngày " + goodsReceiptNote.Date + " rồi", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void GetGoodsReceiptNoteData(int rowIndex)
        {
            goodsReceiptNote.GRN_No = dgvAdminGoodsReceiptNote["Số phiếu nhập kho", rowIndex].Value.ToString();
            goodsReceiptNote.Date = (DateTime)dgvAdminGoodsReceiptNote["Ngày nhập", rowIndex].Value;
            goodsReceiptNote.Supplier.ID = dgvAdminGoodsReceiptNote["Mã nhà cung cấp", rowIndex].Value.ToString();
            goodsReceiptNote.Employee.ID = dgvAdminGoodsReceiptNote["Mã nhân viên", rowIndex].Value.ToString();
        }
        #endregion

        #region Goods Receipt Note Details
        private void splBtnGoodsReceiptNoteDetailsRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục nội dung hàng hoá " + dgvAdminGoodsReceiptNoteDetails["Tên hàng hoá", dgvAdminGoodsReceiptNoteDetails.CurrentRow.Index].Value.ToString() +
                                                      " trên phiếu nhập kho ngày " + dgvAdminGoodsReceiptNoteDetails["Ngày nhập", dgvAdminGoodsReceiptNoteDetails.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminGoodsReceiptNoteDetails.CurrentRow.Index;
                try
                {
                    GetGoodsReceiptNoteDetailsData(rowIndex);
                    if (dgvAdminGoodsReceiptNoteDetails["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        goodsReceiptNoteBLL.AddDetails(goodsReceiptNote);
                        XtraMessageBox.Show("Đã khôi phục nội dung hàng hoá " + goodsReceiptNote.Commodity.Name +
                                            " trên phiếu nhập kho ngày " + goodsReceiptNote.Date.ToString(),
                                            "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminGoodsReceiptNoteDetails["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        goodsReceiptNoteBLL.UpdateDetails(goodsReceiptNote);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin nội dung hàng hoá " + goodsReceiptNote.Commodity.Name +
                                            " trên phiếu nhập kho ngày " + goodsReceiptNote.Date.ToString(),
                                            "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    goodsReceiptNote.Date = DateTime.Parse(dgvAdminGoodsReceiptNoteDetails["Ngày nhập", rowIndex].Value.ToString());
                    XtraMessageBox.Show("Chưa khôi phục phiếu nhập kho ngày " + goodsReceiptNote.Date.ToString(),
                                        "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void GetGoodsReceiptNoteDetailsData(int rowIndex)
        {
            goodsReceiptNote.Date = DateTime.Parse(dgvAdminGoodsReceiptNoteDetails["Ngày nhập", rowIndex].Value.ToString());

            goodsReceiptNote.GRN_No = dgvAdminGoodsReceiptNoteDetails["Số phiếu nhập kho", rowIndex].Value.ToString();
            goodsReceiptNote.Commodity.ID = dgvAdminGoodsReceiptNoteDetails["Mã hàng hoá", rowIndex].Value.ToString();
            goodsReceiptNote.Cost = double.Parse(dgvAdminGoodsReceiptNoteDetails["Giá nhập", rowIndex].Value.ToString());
            goodsReceiptNote.Quantity = int.Parse(dgvAdminGoodsReceiptNoteDetails["Số lượng", rowIndex].Value.ToString());
        }
        #endregion

        #region Goods Issue Note
        private void splBtnGoodsIssueNoteRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục phiếu xuất kho ngày " + dgvAdminGoodsIssueNote["Ngày xuất", dgvAdminGoodsIssueNote.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminGoodsIssueNote.CurrentRow.Index;
                try
                {
                    if (dgvAdminGoodsIssueNote["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        GetGoodsIssueNoteData(rowIndex);
                        goodsIssueNoteBLL.Recover(goodsIssueNote);
                        XtraMessageBox.Show("Đã khôi phục phiếu xuất kho ngày " + goodsIssueNote.GIN_No, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminGoodsIssueNote["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        GetGoodsIssueNoteData(rowIndex);
                        goodsIssueNoteBLL.Update(goodsIssueNote);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin phiếu xuất kho ngày " + goodsIssueNote.GIN_No, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    goodsIssueNote.Date = DateTime.Parse(dgvAdminGoodsIssueNote["Ngày xuất", rowIndex].Value.ToString());
                    XtraMessageBox.Show("Đã khôi phục lại thông tin phiếu xuất kho ngày " + goodsIssueNote.GIN_No + " rồi", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void GetGoodsIssueNoteData(int rowIndex)
        {
            goodsIssueNote.GIN_No = dgvAdminGoodsIssueNote["Số phiếu xuất kho", rowIndex].Value.ToString();
            goodsIssueNote.Date = DateTime.Parse(dgvAdminGoodsIssueNote["Ngày xuất", rowIndex].Value.ToString());
            goodsIssueNote.Employee.ID = dgvAdminGoodsIssueNote["Mã nhân viên", rowIndex].Value.ToString();
        }
        #endregion

        #region Goods Issue Note Details
        private void splBtnGoodsIssueNoteDetailsRecover_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Khôi phục nội dung hàng hoá " + dgvAdminGoodsIssueNoteDetails["Tên hàng hoá", dgvAdminGoodsIssueNoteDetails.CurrentRow.Index].Value.ToString() +
                                                      " trên phiếu xuất kho ngày " + dgvAdminGoodsIssueNoteDetails["Ngày xuất", dgvAdminGoodsIssueNoteDetails.CurrentRow.Index].Value.ToString() + "?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvAdminGoodsIssueNoteDetails.CurrentRow.Index;
                try
                {
                    if (dgvAdminGoodsIssueNoteDetails["Action", rowIndex].Value.ToString() == "DELETE")
                    {
                        GetGoodsIssueNoteDetailsData(rowIndex);
                        goodsIssueNoteBLL.AddDetails(goodsIssueNote);
                        XtraMessageBox.Show("Đã khôi phục nội dung hàng hoá " + goodsIssueNote.Commodity.Name +
                                            " trên phiếu xuất kho ngày " + goodsIssueNote.Date.ToString(),
                                            "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dgvAdminGoodsIssueNoteDetails["Action", rowIndex].Value.ToString() == "UPDATE")
                    {
                        GetGoodsIssueNoteDetailsData(rowIndex);
                        goodsIssueNoteBLL.UpdateDetails(goodsIssueNote);
                        XtraMessageBox.Show("Đã khôi phục lại thông tin nội dung hàng hoá " + goodsIssueNote.Commodity.Name +
                                            " trên phiếu xuất kho ngày " + goodsIssueNote.Date.ToString(),
                                            "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    goodsIssueNote.Date = DateTime.Parse(dgvAdminGoodsIssueNoteDetails["Ngày xuất", rowIndex].Value.ToString());
                    XtraMessageBox.Show("Chưa khôi phục lại phiếu xuất kho ngày " + goodsIssueNote.Date.ToString(),
                                        "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void GetGoodsIssueNoteDetailsData(int rowIndex)
        {
            goodsIssueNote.Date = DateTime.Parse(dgvAdminGoodsIssueNoteDetails["Ngày xuất", rowIndex].Value.ToString());

            goodsIssueNote.GIN_No = dgvAdminGoodsIssueNoteDetails["Số phiếu xuất kho", rowIndex].Value.ToString();
            goodsIssueNote.Commodity.ID = dgvAdminGoodsIssueNoteDetails["Mã hàng hoá", rowIndex].Value.ToString();
            goodsIssueNote.Cost = double.Parse(dgvAdminGoodsIssueNoteDetails["Giá xuất", rowIndex].Value.ToString());
            goodsIssueNote.Quantity = int.Parse(dgvAdminGoodsIssueNoteDetails["Số lượng", rowIndex].Value.ToString());
        }
        #endregion

        #region Account
        private void splBtnGetByName_Click(object sender, EventArgs e)
        {
            if (txtEdtName.Text != "")
            {
                account.Name = txtEdtName.Text;
                dgvAdminAccount.DataSource = accountBLL.GetByName(account);
            }
            else
                GetAccount();
        }

        private void splBtnAdd_Click(object sender, EventArgs e)
        {
            if (txtEdtUsername.Text != "" && txtEdtName.Text != "" &&
                (rdoManager.Checked || rdoSupervisor.Checked))
            {
                account.Username = txtEdtUsername.Text;
                account.Name = txtEdtName.Text;
                if (rdoSupervisor.Checked)
                    account.Role = "Giám sát";
                else
                    account.Role = "Quản lý";
                account.Password = txtEdtUsername.Text;

                dgvAdminAccount.DataSource = accountBLL.Add(account);
                GetAccount();
            }
        }

        private void splBtnReactivate_Click(object sender, EventArgs e)
        {
            if (dgvAdminAccount["Tin nhắn", dgvAdminAccount.CurrentRow.Index].Value.ToString() == "Forgot password")
            {
                account.Username = txtEdtUsername.Text;
                account.Password = txtEdtUsername.Text;
                dgvAdminAccount.DataSource = accountBLL.ResetPassword(account);
                txtEdtUsername.Text = "";
                txtEdtName.Text = "";
                GetAccount();
                XtraMessageBox.Show("Đã kích hoạt mật khẩu mặc định cho tài khoản " + account.Username, "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Xoá tài khoản " + txtEdtName.Text + "?", "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                account.Username = txtEdtUsername.Text;
                dgvAdminAccount.DataSource = accountBLL.Delete(account);
                XtraMessageBox.Show("Đã xoá tài khoản " + account.Username, "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAdminAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdtUsername.Text = dgvAdminAccount["Tên tài khoản", e.RowIndex].Value.ToString();
            txtEdtName.Text = dgvAdminAccount["Tên", e.RowIndex].Value.ToString();
        }
        #endregion
    }
}