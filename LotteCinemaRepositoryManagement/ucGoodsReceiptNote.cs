using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucGoodsReceiptNote : UserControl
    {
        GoodsReceiptNote goodsReceiptNote = new GoodsReceiptNote();
        GoodsReceiptNoteBLL grnBLL = new GoodsReceiptNoteBLL();

        public ucGoodsReceiptNote()
        {
            InitializeComponent();
        }

        private static ucGoodsReceiptNote instance;
        public static ucGoodsReceiptNote Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucGoodsReceiptNote();
                return instance;
            }
        }

        private void ucGoodsReceiptNote_Load(object sender, EventArgs e)
        {
            Get();
        }

        private void numericUpDownCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) ||
                         (e.KeyChar == 8) || (e.KeyChar == 127) ||
                         (e.KeyChar == 46));
        }

        private void numericUpDownQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) ||
                         (e.KeyChar == 8) || (e.KeyChar == 127));
        }

        void ClearData()
        {
            txtEdtGRN_No.Text = "";
            numericUpDownCost.Text = "0";
            numericUpDownQuantity.Text = "0";
        }

        public void Get()
        {
            GetDate();
            GetCommodityName();
            GetSupplierName();
            GetEmployeeName();
        }

        void GetDate()
        {
            DataTable dt = new DataTable();
            grnBLL.GetDate(dt);
            cboDate.DisplayMember = "Date";
            cboDate.ValueMember = "GRN_No";
            cboDate.DataSource = dt;
        }

        void GetCommodityName()
        {
            DataTable dt = new DataTable();
            grnBLL.GetCommodityName(dt);
            cboCommodityName.DisplayMember = "CommodityName";
            cboCommodityName.ValueMember = "CommodityID";
            cboCommodityName.DataSource = dt;
        }

        void GetSupplierName()
        {
            DataTable dt = new DataTable();
            grnBLL.GetSupplierName(dt);
            cboSupplierName.DisplayMember = "SupplierName";
            cboSupplierName.ValueMember = "SupplierID";
            cboSupplierName.DataSource = dt;
        }

        void GetEmployeeName()
        {
            DataTable dt = new DataTable();
            grnBLL.GetEmployeeName(dt);
            cboEmployeeName.DisplayMember = "FullName";
            cboEmployeeName.ValueMember = "EmployeeID";
            cboEmployeeName.DataSource = dt;
        }

        bool CheckData()
        {
            if (cboDate.Text != "" && cboSupplierName.Text != "" && cboEmployeeName.Text != "" & cboCommodityName.Text != "")
                return true;
            return false;
        }

        void GetByNumber()
        {
            if (cboDate.Text != "")
            {
                goodsReceiptNote.GRN_No = cboDate.SelectedValue.ToString();
                dgvGoodsReceiptNote.DataSource = grnBLL.GetByNumber(goodsReceiptNote);
                dgvGoodsReceiptNote.ClearSelection();
                txtEdtTotalAmount.Text = CalculateTotalAmount() + "";
            }
        }

        double CalculateTotalAmount()
        {
            double totalAmount = 0;
            for (int i = 0; i < dgvGoodsReceiptNote.RowCount; i++)
            {
                try
                {
                    totalAmount += double.Parse(dgvGoodsReceiptNote["Giá nhập", i].Value.ToString()) * double.Parse(dgvGoodsReceiptNote["Số lượng", i].Value.ToString());
                }
                catch { }
            }

            return totalAmount;
        }

        private void splBtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn muốn tạo phiếu nhập kho mới?", "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                goodsReceiptNote.Date = DateTime.Now;
                goodsReceiptNote.Supplier.ID = cboSupplierName.SelectedValue.ToString();
                goodsReceiptNote.Employee.ID = cboEmployeeName.SelectedValue.ToString();

                dgvGoodsReceiptNote.DataSource = grnBLL.Add(goodsReceiptNote);
                GetDate();
                cboDate.SelectedIndex = cboDate.Items.Count - 1;
                XtraMessageBox.Show("Đã thêm phiếu nhập kho ngày " + goodsReceiptNote.Date, "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xoá phiếu nhập kho ngày " + cboDate.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                goodsReceiptNote.Date = DateTime.Parse(cboDate.Text);

                goodsReceiptNote.GRN_No = cboDate.SelectedValue.ToString();
                dgvGoodsReceiptNote.DataSource = grnBLL.Delete(goodsReceiptNote);
                ClearData();
                Get();

                XtraMessageBox.Show("Đã xoá phiếu nhập kho ngày " + goodsReceiptNote.Date, "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnGet_Click(object sender, EventArgs e)
        {
            GetByNumber();
            ClearData();
        }

        private void splBtnAddDetails_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void splBtnSave_Click(object sender, EventArgs e)
        {
            if (CheckData() && numericUpDownCost.Text != "0" && numericUpDownQuantity.Text != "0")
            {
                try
                {
                    if (txtEdtGRN_No.Text == "")
                    {
                        goodsReceiptNote.GRN_No = cboDate.SelectedValue.ToString();
                        goodsReceiptNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                        goodsReceiptNote.Cost = double.Parse(numericUpDownCost.Text);
                        goodsReceiptNote.Quantity = int.Parse(numericUpDownQuantity.Text);

                        dgvGoodsReceiptNote.DataSource = grnBLL.AddDetails(goodsReceiptNote);
                        ClearData();
                        GetByNumber();

                        // Bắt lỗi datagridview không có dữ liệu
                        try
                        {
                            int rowIndex = dgvGoodsReceiptNote.CurrentRow.Index;
                            cboSupplierName.Text = dgvGoodsReceiptNote["Tên nhà cung cấp", rowIndex].Value.ToString();
                            cboEmployeeName.Text = dgvGoodsReceiptNote["Tên nhân viên", rowIndex].Value.ToString();
                        }
                        catch { }

                        XtraMessageBox.Show("Đã thêm nội dung phiếu nhập kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int rowIndex = dgvGoodsReceiptNote.CurrentRow.Index;
                        goodsReceiptNote.Commodity.Name = dgvGoodsReceiptNote["Tên hàng hoá", rowIndex].Value.ToString();
                        goodsReceiptNote.Cost = double.Parse(dgvGoodsReceiptNote["Giá nhập", rowIndex].Value.ToString());
                        goodsReceiptNote.Quantity = int.Parse(dgvGoodsReceiptNote["Số lượng", rowIndex].Value.ToString());
                        goodsReceiptNote.Supplier.Name = dgvGoodsReceiptNote["Tên nhà cung cấp", rowIndex].Value.ToString();
                        goodsReceiptNote.Employee.FullName = dgvGoodsReceiptNote["Tên nhân viên", rowIndex].Value.ToString();

                        if ((goodsReceiptNote.Supplier.Name != cboSupplierName.Text || goodsReceiptNote.Employee.FullName != cboEmployeeName.Text) &&
                            (goodsReceiptNote.Cost != double.Parse(numericUpDownCost.Text) || goodsReceiptNote.Quantity != int.Parse(numericUpDownQuantity.Text)))
                        {
                            goodsReceiptNote.GRN_No = txtEdtGRN_No.Text;
                            goodsReceiptNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                            goodsReceiptNote.Cost = double.Parse(numericUpDownCost.Text);
                            goodsReceiptNote.Quantity = int.Parse(numericUpDownQuantity.Text);
                            goodsReceiptNote.Supplier.ID = cboSupplierName.SelectedValue.ToString();
                            goodsReceiptNote.Employee.ID = cboEmployeeName.SelectedValue.ToString();

                            dgvGoodsReceiptNote.DataSource = grnBLL.Update(goodsReceiptNote);
                            dgvGoodsReceiptNote.DataSource = grnBLL.UpdateDetails(goodsReceiptNote);
                            ClearData();
                            GetByNumber();
                            XtraMessageBox.Show("Đã sửa thông tin nội dung phiếu nhập kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (goodsReceiptNote.Supplier.Name != cboSupplierName.Text || goodsReceiptNote.Employee.FullName != cboEmployeeName.Text)
                        {
                            goodsReceiptNote.GRN_No = txtEdtGRN_No.Text;
                            goodsReceiptNote.Supplier.ID = cboSupplierName.SelectedValue.ToString();
                            goodsReceiptNote.Employee.ID = cboEmployeeName.SelectedValue.ToString();

                            dgvGoodsReceiptNote.DataSource = grnBLL.Update(goodsReceiptNote);
                            ClearData();
                            GetByNumber();
                            XtraMessageBox.Show("Đã sửa thông tin nội dung phiếu nhập kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (goodsReceiptNote.Cost != double.Parse(numericUpDownCost.Text) || goodsReceiptNote.Quantity != int.Parse(numericUpDownQuantity.Text))
                        {
                            goodsReceiptNote.GRN_No = txtEdtGRN_No.Text;
                            goodsReceiptNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                            goodsReceiptNote.Cost = double.Parse(numericUpDownCost.Text);
                            goodsReceiptNote.Quantity = int.Parse(numericUpDownQuantity.Text);

                            dgvGoodsReceiptNote.DataSource = grnBLL.UpdateDetails(goodsReceiptNote);
                            ClearData();
                            GetByNumber();
                            XtraMessageBox.Show("Đã sửa thông tin nội dung phiếu nhập kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Phiếu nhập kho đã có hàng hoá " + cboCommodityName.Text, "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                XtraMessageBox.Show("Vui lòng nhập đủ các thông tin", "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void splBtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xoá thông tin hàng hoá " + cboCommodityName.Text + 
                                                      " trên phiếu nhập kho ngày " + cboDate.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtEdtGRN_No.Text != "")
                {
                    goodsReceiptNote.GRN_No = txtEdtGRN_No.Text;
                    goodsReceiptNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                    dgvGoodsReceiptNote.DataSource = grnBLL.Remove(goodsReceiptNote);
                    ClearData();
                    GetByNumber();
                }
                else
                    XtraMessageBox.Show("Vui lòng chọn thông tin phiếu nhập kho cần xoá", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvGoodsReceiptNote.Rows.Count > 0)
            {

                frmGoodsReceiptNote pnkList = new frmGoodsReceiptNote(dgvGoodsReceiptNote["Thời gian lập", dgvGoodsReceiptNote.CurrentRow.Index].Value.ToString(),
                                                                      double.Parse(txtEdtTotalAmount.Text));
                pnkList.ShowDialog();
            }
        }

        private void dgvGoodsReceiptNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdtGRN_No.Text = cboDate.SelectedValue.ToString();
            cboCommodityName.Text = dgvGoodsReceiptNote["Tên hàng hoá", e.RowIndex].Value.ToString();
            numericUpDownCost.Text = dgvGoodsReceiptNote["Giá nhập", e.RowIndex].Value.ToString(); ;
            numericUpDownQuantity.Text = dgvGoodsReceiptNote["Số lượng", e.RowIndex].Value.ToString();
            cboSupplierName.Text = dgvGoodsReceiptNote["Tên nhà cung cấp", e.RowIndex].Value.ToString();
            cboEmployeeName.Text = dgvGoodsReceiptNote["Tên nhân viên", e.RowIndex].Value.ToString();
        }

        private void splBtnExport_Click(object sender, EventArgs e)
        {
            if (dgvGoodsReceiptNote.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvGoodsReceiptNote.DataSource;
                Export(dt, "Phiếu nhập kho", "PHIẾU NHẬP KHO");
            }
        }

        void Export(DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Thời gian lập";
            cl1.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên hàng hoá";
            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Giá xuất";
            cl3.ColumnWidth = 17.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số lượng";
            cl4.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Đơn vị tính";
            cl5.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Nhà cung cấp";
            cl6.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Tên nhân viên";
            cl7.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c == 2)
                    {
                        arr[r, c] = "'" + dr[c];
                        continue;
                    }

                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}