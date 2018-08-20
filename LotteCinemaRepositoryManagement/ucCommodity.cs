using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucCommodity : UserControl
    {
        Commodity commodity = new Commodity();
        CommodityBLL commodityBLL = new CommodityBLL();

        public ucCommodity()
        {
            InitializeComponent();
        }

        private static ucCommodity instance;
        public static ucCommodity Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucCommodity();
                return instance;
            }
        }

        void GetData()
        {
            commodity.ID = txtEdtID.Text;
            commodity.Name = txtEdtName.Text;
            commodity.CalculationUnit = txtEdtCalculationUnit.Text;
        }

        void ClearAll()
        {
            txtEdtID.Text = "";
            txtEdtName.Text = "";
            txtEdtCalculationUnit.Text = "";
        }

        public void GetAll()
        {
            dgvCommodity.DataSource = commodityBLL.GetAll();
            dgvCommodity.ClearSelection();
        }

        private void splBtnGet_Click(object sender, EventArgs e)
        {
            commodity.Name = txtEdtName.Text;
            if (commodity.Name == "")
                GetAll();
            else
            {
                dgvCommodity.DataSource = commodityBLL.GetByName(commodity);
                dgvCommodity.ClearSelection();
            }

            ClearAll();
        }

        private void splBtnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void splBtnSave_Click(object sender, EventArgs e)
        {
            if (txtEdtName.Text != "" && txtEdtCalculationUnit.Text != "")
            {
                if (txtEdtID.Text == "")
                {
                    try
                    {
                        GetData();
                        dgvCommodity.DataSource = commodityBLL.Add(commodity);
                        ClearAll();
                        GetAll();

                        XtraMessageBox.Show("Đã thêm thông tin hàng hoá " + commodity.Name, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Tên hàng hoá đã tồn tại", "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    int rowIndex = dgvCommodity.CurrentRow.Index;
                    commodity.Name = dgvCommodity["Tên hàng hoá", rowIndex].Value.ToString();
                    commodity.Quantity = int.Parse(dgvCommodity["Số lượng", rowIndex].Value.ToString());
                    commodity.CalculationUnit = dgvCommodity["Đơn vị tính", rowIndex].Value.ToString();

                    if (commodity.Name != txtEdtName.Text ||
                        commodity.CalculationUnit != txtEdtCalculationUnit.Text)
                    {
                        try
                        {
                            GetData();
                            dgvCommodity.DataSource = commodityBLL.Update(commodity);
                            ClearAll();
                            GetAll();

                            XtraMessageBox.Show("Đã sửa thông tin hàng hoá " + commodity.Name, "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Tên hàng hoá đã tồn tại", "THÔNG BÁO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
                XtraMessageBox.Show("Vui lòng nhập đủ các thông tin", "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void splBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xoá hàng hoá " + txtEdtName.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtEdtID.Text != "")
                {
                    commodity.ID = txtEdtID.Text;
                    dgvCommodity.DataSource = commodityBLL.Delete(commodity);
                    ClearAll();
                    GetAll();

                    XtraMessageBox.Show("Đã xoá thông tin hàng hoá " + commodity.Name, "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Vui lòng chọn thông tin hàng hoá cần xoá", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvCommodity.Rows.Count > 0)
            {
                frmCommodity commodityList = new frmCommodity();
                commodityList.ShowDialog();
            }
        }

        private void dgvCommodity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvCommodity.CurrentRow.Index;
            txtEdtID.Text = dgvCommodity["Mã hàng hoá", e.RowIndex].Value.ToString();
            txtEdtName.Text = dgvCommodity["Tên hàng hoá", e.RowIndex].Value.ToString();
            txtEdtCalculationUnit.Text = dgvCommodity["Đơn vị tính", e.RowIndex].Value.ToString();
        }

        private void splBtnExport_Click(object sender, EventArgs e)
        {
            if (dgvCommodity.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvCommodity.DataSource;
                Export(dt, "Danh sách hàng hoá", "DANH SÁCH HÀNG HOÁ");
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
            cl1.Value2 = "Mã hàng hoá";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên hàng hoá";
            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số lượng";
            cl3.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Đơn vị tính";
            cl4.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");

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

        private void numericUpDownQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) ||
                         (e.KeyChar == 8) || (e.KeyChar == 127));
        }
    }
}