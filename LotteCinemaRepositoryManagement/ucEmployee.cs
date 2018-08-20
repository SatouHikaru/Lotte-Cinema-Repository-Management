using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucEmployee : UserControl
    {
        Employee employee = new Employee();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        public ucEmployee()
        {
            InitializeComponent();
        }

        private static ucEmployee instance;
        public static ucEmployee Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucEmployee();
                return instance;
            }
        }

        private void txtEdtMobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 32) ||
                         (e.KeyChar == 8) || (e.KeyChar == 127));
        }

        void GetData()
        {
            employee.ID = txtEdtID.Text;
            employee.FullName = txtEdtFullName.Text;
            if (rdoMale.Checked)
                employee.Gender = true;
            else
                employee.Gender = false;
            employee.Birthday = DateTime.Parse(dtpBirthday.Value.ToString("yyyy-MM-dd"));
            employee.MobilePhone = txtEdtMobilePhone.Text;
        }

        void ClearData()
        {
            txtEdtID.Text = "";
            txtEdtFullName.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            dtpBirthday.Value = DateTime.Now;
            txtEdtMobilePhone.Text = "";
        }

        public void GetAll()
        {
            dgvEmployee.DataSource = employeeBLL.GetAll();
            dgvEmployee.ClearSelection();
        }

        private void splBtnGet_Click(object sender, EventArgs e)
        {
            employee.FullName = txtEdtFullName.Text;
            if (employee.FullName == "")
                GetAll();
            else
            {
                dgvEmployee.DataSource = employeeBLL.GetByName(employee);
                dgvEmployee.ClearSelection();
            }

            ClearData();
        }

        private void splBtnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void splBtnSave_Click(object sender, EventArgs e)
        {
            if (txtEdtFullName.Text != "" && (rdoMale.Checked || rdoFemale.Checked) &&
                txtEdtMobilePhone.Text != "")
            {
                if (txtEdtID.Text == "")
                {
                    try
                    {
                        GetData();
                        dgvEmployee.DataSource = employeeBLL.Add(employee);
                        ClearData();
                        GetAll();

                        XtraMessageBox.Show("Đã thêm thông tin nhân viên " + employee.FullName, "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không được thêm nhân viên dưới 18 tuổi", "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    int rowIndex = dgvEmployee.CurrentRow.Index;
                    employee.FullName = dgvEmployee["Họ tên", rowIndex].Value.ToString();

                    if (rdoMale.Checked)
                        employee.Gender = true;
                    else
                        employee.Gender = false;

                    employee.Birthday = DateTime.Parse(dgvEmployee["Ngày sinh", rowIndex].Value.ToString());
                    employee.MobilePhone = dgvEmployee["Điện thoại", rowIndex].Value.ToString();

                    if (employee.FullName != txtEdtFullName.Text ||
                        employee.Gender != (bool)dgvEmployee["Giới tính", rowIndex].Value ||
                        employee.Birthday != dtpBirthday.Value ||
                        employee.MobilePhone != txtEdtMobilePhone.Text)
                    {
                        try
                        {
                            GetData();
                            dgvEmployee.DataSource = employeeBLL.Update(employee);
                            ClearData();
                            GetAll();

                            XtraMessageBox.Show("Đã sửa thông tin nhân viên " + employee.FullName, "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Nhân viên không được dưới 18 tuổi", "THÔNG BÁO!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
                XtraMessageBox.Show("Vui lòng nhập đủ các thông tin", "THÔNG BÁO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void splBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên " + txtEdtFullName.Text + " hay không?",
                                                      "THÔNG BÁO!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtEdtID.Text != "")
                {
                    employee.ID = txtEdtID.Text;
                    dgvEmployee.DataSource = employeeBLL.Delete(employee);
                    ClearData();
                    GetAll();

                    XtraMessageBox.Show("Đã xoá thông tin nhân viên " + txtEdtFullName.Text, "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Vui lòng chọn nhân viên cần xoá", "THÔNG BÁO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void splBtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                frmEmployee employeeList = new frmEmployee();
                employeeList.ShowDialog();
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdtID.Text = dgvEmployee["Mã nhân viên", e.RowIndex].Value.ToString();
            txtEdtFullName.Text = dgvEmployee["Họ tên", e.RowIndex].Value.ToString();
            dtpBirthday.Value = (DateTime)dgvEmployee["Ngày sinh", e.RowIndex].Value;

            if ((bool)dgvEmployee["Giới tính", e.RowIndex].Value == true)
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;

            txtEdtMobilePhone.Text = dgvEmployee["Điện thoại", e.RowIndex].Value.ToString();
        }

        private void splBtnExport_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvEmployee.DataSource;
                Export(dt, "Danh sách nhân viên", "DANH SÁCH NHÂN VIÊN");
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã nhân viên";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ tên";
            cl2.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Giới tính";
            cl3.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Điện thoại";
            cl5.ColumnWidth = 15.0;
            

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

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
                        string gender;
                        if (dr[c].Equals(true))
                            gender = "Nam";
                        else
                            gender = "Nữ";

                        arr[r, c] = gender;
                        continue;
                    }
                    else if (c == 3)
                    {
                        DateTime date = DateTime.Parse(dr[c].ToString());
                        arr[r, c] = date;
                        continue;
                    }
                    else if (c == 4)
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