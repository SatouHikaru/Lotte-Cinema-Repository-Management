using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucGoodsIssueNote : UserControl
    {
        GoodsIssueNote goodsIssueNote = new GoodsIssueNote();
        GoodsIssueNoteBLL ginBLL = new GoodsIssueNoteBLL();

        public ucGoodsIssueNote()
        {
            InitializeComponent();
        }

        private static ucGoodsIssueNote instance;
        public static ucGoodsIssueNote Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucGoodsIssueNote();
                return instance;
            }
        }

        private void ucGoodsIssueNote_Load(object sender, EventArgs e)
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
            txtEdtGIN_No.Text = "";
            numericUpDownCost.Text = "0";
            numericUpDownQuantity.Text = "0";
        }

        public void Get()
        {
            GetDate();
            GetCommodityName();
            GetEmployeeName();
        }

        void GetDate()
        {
            DataTable dt = new DataTable();
            ginBLL.GetDate(dt);
            cboDate.DisplayMember = "Date";
            cboDate.ValueMember = "GIN_No";
            cboDate.DataSource = dt;
        }

        void GetCommodityName()
        {
            DataTable dt = new DataTable();
            ginBLL.GetCommodityName(dt);
            cboCommodityName.DisplayMember = "CommodityName";
            cboCommodityName.ValueMember = "CommodityID";
            cboCommodityName.DataSource = dt;
        }

        void GetEmployeeName()
        {
            DataTable dt = new DataTable();
            ginBLL.GetEmployeeName(dt);
            cboEmployeeName.DisplayMember = "FullName";
            cboEmployeeName.ValueMember = "EmployeeID";
            cboEmployeeName.DataSource = dt;
        }

        bool CheckData()
        {
            if (cboDate.Text != "" && cboEmployeeName.Text != "" & cboCommodityName.Text != "")
                return true;
            return false;
        }

        void GetByNumber()
        {
            if (cboDate.Text != "")
            {
                goodsIssueNote.GIN_No = cboDate.SelectedValue.ToString();
                dgvGoodsIssueNote.DataSource = ginBLL.GetByNumber(goodsIssueNote);
                dgvGoodsIssueNote.ClearSelection();
                txtEdtTotalAmount.Text = CalculateTotalAmount() + "";
            }
        }

        double CalculateTotalAmount()
        {
            double totalAmount = 0;
            for (int i = 0; i < dgvGoodsIssueNote.RowCount; i++)
                totalAmount += double.Parse(dgvGoodsIssueNote["Giá xuất", i].Value.ToString()) * double.Parse(dgvGoodsIssueNote["Số lượng", i].Value.ToString());
            return totalAmount;
        }

        private void splBtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn muốn tạo phiếu xuất kho mới?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                goodsIssueNote.Date = DateTime.Now;
                goodsIssueNote.Employee.ID = cboEmployeeName.SelectedValue.ToString();
                dgvGoodsIssueNote.DataSource = ginBLL.Add(goodsIssueNote);

                GetDate();
                cboDate.SelectedIndex = cboDate.Items.Count - 1;
                XtraMessageBox.Show("Đã thêm phiếu xuất kho ngày " + goodsIssueNote.Date, "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xoá phiếu xuất kho ngày " + cboDate.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                goodsIssueNote.GIN_No = cboDate.SelectedValue.ToString();
                dgvGoodsIssueNote.DataSource = ginBLL.Delete(goodsIssueNote);
                ClearData();
                GetByNumber();
                XtraMessageBox.Show("Đã xoá phiếu xuất kho ngày " + cboDate.Text, "THÔNG BÁO!",
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
                    if (txtEdtGIN_No.Text == "")
                    {
                        goodsIssueNote.GIN_No = cboDate.SelectedValue.ToString();
                        goodsIssueNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                        goodsIssueNote.Cost = double.Parse(numericUpDownCost.Text);
                        goodsIssueNote.Quantity = int.Parse(numericUpDownQuantity.Text);

                        dgvGoodsIssueNote.DataSource = ginBLL.AddDetails(goodsIssueNote);
                        ClearData();
                        GetByNumber();

                        // Bắt lỗi datagridview không có dữ liệu
                        try
                        {
                            int rowIndex = dgvGoodsIssueNote.CurrentRow.Index;
                            cboEmployeeName.Text = dgvGoodsIssueNote["Tên nhân viên", rowIndex].Value.ToString();
                        }
                        catch { }

                        XtraMessageBox.Show("Đã thêm nội dung phiếu xuất kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int rowIndex = dgvGoodsIssueNote.CurrentRow.Index;
                        goodsIssueNote.Commodity.Name = dgvGoodsIssueNote["Tên hàng hoá", rowIndex].Value.ToString();
                        goodsIssueNote.Cost = double.Parse(dgvGoodsIssueNote["Giá xuất", rowIndex].Value.ToString());
                        goodsIssueNote.Quantity = int.Parse(dgvGoodsIssueNote["Số lượng", rowIndex].Value.ToString());
                        goodsIssueNote.Employee.FullName = dgvGoodsIssueNote["Tên nhân viên", rowIndex].Value.ToString();

                        if (goodsIssueNote.Employee.FullName != cboEmployeeName.Text &&
                            (goodsIssueNote.Cost != double.Parse(numericUpDownCost.Text) || goodsIssueNote.Quantity != int.Parse(numericUpDownQuantity.Text)))
                        {
                            goodsIssueNote.GIN_No = txtEdtGIN_No.Text;
                            goodsIssueNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                            goodsIssueNote.Cost = double.Parse(numericUpDownCost.Text);
                            goodsIssueNote.Quantity = int.Parse(numericUpDownQuantity.Text);
                            goodsIssueNote.Employee.ID = cboEmployeeName.SelectedValue.ToString();

                            dgvGoodsIssueNote.DataSource = ginBLL.Update(goodsIssueNote);
                            dgvGoodsIssueNote.DataSource = ginBLL.UpdateDetails(goodsIssueNote);
                            ClearData();
                            GetByNumber();
                            XtraMessageBox.Show("Đã sửa thông tin nội dung phiếu xuất kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (goodsIssueNote.Employee.FullName != cboEmployeeName.Text)
                        {
                            goodsIssueNote.GIN_No = cboDate.SelectedValue.ToString();
                            goodsIssueNote.Employee.ID = cboEmployeeName.SelectedValue.ToString();

                            dgvGoodsIssueNote.DataSource = ginBLL.Update(goodsIssueNote);
                            ClearData();
                            GetByNumber();
                            XtraMessageBox.Show("Đã sửa thông tin nội dung phiếu xuất kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (goodsIssueNote.Cost != double.Parse(numericUpDownCost.Text) ||
                                 goodsIssueNote.Quantity != int.Parse(numericUpDownQuantity.Text))
                        {
                            goodsIssueNote.GIN_No = txtEdtGIN_No.Text;
                            goodsIssueNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                            goodsIssueNote.Cost = double.Parse(numericUpDownCost.Text);
                            goodsIssueNote.Quantity = int.Parse(numericUpDownQuantity.Text);

                            dgvGoodsIssueNote.DataSource = ginBLL.UpdateDetails(goodsIssueNote);
                            ClearData();
                            GetByNumber();
                            XtraMessageBox.Show("Đã sửa thông tin nội dung phiếu xuất kho ngày " + cboDate.Text, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Phiếu xuất kho đã có hàng hoá " + cboCommodityName.Text, "THÔNG BÁO!",
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
                                                      " trên phiếu xuất kho ngày " + cboDate.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtEdtGIN_No.Text != "")
                {
                    goodsIssueNote.GIN_No = txtEdtGIN_No.Text;
                    goodsIssueNote.Commodity.ID = cboCommodityName.SelectedValue.ToString();
                    dgvGoodsIssueNote.DataSource = ginBLL.Remove(goodsIssueNote);
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
            if (dgvGoodsIssueNote.Rows.Count > 0)
            {
                frmGoodsIssueNote pxkList = new frmGoodsIssueNote(dgvGoodsIssueNote["Thời gian lập", dgvGoodsIssueNote.CurrentRow.Index].Value.ToString(),
                                                                  double.Parse(txtEdtTotalAmount.Text));
                pxkList.ShowDialog();
            }
        }

        private void dgvGoodsIssueNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdtGIN_No.Text = cboDate.SelectedValue.ToString();
            cboCommodityName.Text = dgvGoodsIssueNote["Tên hàng hoá", e.RowIndex].Value.ToString();
            numericUpDownCost.Text = dgvGoodsIssueNote["Giá xuất", e.RowIndex].Value.ToString();
            numericUpDownQuantity.Text = dgvGoodsIssueNote["Số lượng", e.RowIndex].Value.ToString();
            cboEmployeeName.Text = dgvGoodsIssueNote["Tên nhân viên", e.RowIndex].Value.ToString();
        }

        private void splBtnExport_Click(object sender, EventArgs e)
        {
            if (dgvGoodsIssueNote.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvGoodsIssueNote.DataSource;
                Export(dt, "Phiếu xuất kho", "PHIẾU XUẤT KHO");
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");
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
            cl6.Value2 = "Tên nhân viên";
            cl6.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

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
                    arr[r, c] = dr[c];
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