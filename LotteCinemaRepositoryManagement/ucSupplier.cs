using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucSupplier : UserControl
    {
        Supplier supplier = new Supplier();
        SupplierBLL supplierBLL = new SupplierBLL();

        public ucSupplier()
        {
            InitializeComponent();
        }

        private static ucSupplier instance;
        public static ucSupplier Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucSupplier();
                return instance;
            }
        }

        private void txtEdtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 32) ||
                         (e.KeyChar == 8) || (e.KeyChar == 127));
        }

        void GetData()
        {
            supplier.ID = txtEdtID.Text;
            supplier.Name = txtEdtName.Text;
            supplier.PhoneNumber = txtEdtPhoneNumber.Text;
            supplier.Address = txtAddress.Text;
        }

        void ClearData()
        {
            txtEdtID.Text = "";
            txtEdtName.Text = "";
            txtEdtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }

        void ClearSelection() => dgvSupplier.ClearSelection();

        public void GetAll()
        {
            dgvSupplier.DataSource = supplierBLL.GetAll();
            ClearSelection();
        }

        private void splBtnGet_Click(object sender, EventArgs e)
        {
            supplier.Name = txtEdtName.Text;
            if (supplier.Name == "")
                GetAll();
            else
            {
                dgvSupplier.DataSource = supplierBLL.GetByName(supplier);
                ClearSelection();
            }

            ClearData();
        }

        private void splBtnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void splBtnSave_Click(object sender, EventArgs e)
        {
            if (txtEdtName.Text != "" && txtEdtPhoneNumber.Text != "" && txtAddress.Text != "")
            {
                if (txtEdtID.Text == "")
                {
                    try
                    {
                        GetData();
                        dgvSupplier.DataSource = supplierBLL.Add(supplier);
                        ClearData();
                        GetAll();

                        XtraMessageBox.Show("Đã thêm thông tin nhà cung cấp " + supplier.Name, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Tên nhà cung cấp đã tồn tại", "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    int rowIndex = dgvSupplier.CurrentRow.Index;
                    supplier.Name = dgvSupplier["Tên nhà cung cấp", rowIndex].Value.ToString();
                    supplier.PhoneNumber = dgvSupplier["Số điện thoại", rowIndex].Value.ToString();
                    supplier.Address = dgvSupplier["Địa chỉ", rowIndex].Value.ToString();

                    if (supplier.Name != txtEdtName.Text ||
                        supplier.PhoneNumber != txtEdtPhoneNumber.Text ||
                        supplier.Address != txtAddress.Text)
                    {
                        try
                        {
                            GetData();
                            dgvSupplier.DataSource = supplierBLL.Update(supplier);
                            ClearData();
                            GetAll();

                            XtraMessageBox.Show("Đã sửa thông tin nhà cung cấp " + supplier.Name, "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Tên nhà cung cấp đã tồn tại", "THÔNG BÁO!",
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
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xoá nhà cung cấp " + txtEdtName.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtEdtID.Text != "")
                {
                    supplier.ID = txtEdtID.Text;
                    dgvSupplier.DataSource = supplierBLL.Delete(supplier);
                    ClearData();
                    GetAll();

                    XtraMessageBox.Show("Đã xoá thông tin nhà cung cấp " + supplier.Name, "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Vui lòng chọn thông tin nhà cung cấp cần xoá", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.Rows.Count > 0)
            {
                frmSupplier supplierList = new frmSupplier();
                supplierList.ShowDialog();
            }
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdtID.Text = dgvSupplier["Mã nhà cung cấp", e.RowIndex].Value.ToString();
            txtEdtName.Text = dgvSupplier["Tên nhà cung cấp", e.RowIndex].Value.ToString();
            txtEdtPhoneNumber.Text = dgvSupplier["Số điện thoại", e.RowIndex].Value.ToString();
            txtAddress.Text = dgvSupplier["Địa chỉ", e.RowIndex].Value.ToString();
        }

        private void splBtnExport_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvSupplier.DataSource;
                Export(dt, "Danh sách nhà cung cấp", "DANH SÁCH NHÀ CUNG CẤP");
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
            cl1.Value2 = "Mã nhà cung cấp";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên nhà cung cấp";
            cl2.ColumnWidth = 17.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Điện thoại";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Địa chỉ";
            cl4.ColumnWidth = 50.0;

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