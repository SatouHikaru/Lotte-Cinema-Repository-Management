using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace LotteCinemaRepositoryManagement
{
    public partial class ucCommodityInputReport : UserControl
    {
        CommodityInputReportBLL cirBLL = new CommodityInputReportBLL();

        public ucCommodityInputReport()
        {
            InitializeComponent();
        }

        private static ucCommodityInputReport instance;
        public static ucCommodityInputReport Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucCommodityInputReport();
                return instance;
            }
        }

        private void ucCommodityInputReport_Load(object sender, EventArgs e)
        {
            dtpTimeEnd.MaxDate = DateTime.Now;
            dtpTimeStart.Value = dtpTimeEnd.Value.Subtract(TimeSpan.FromDays(1));
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimeStart.Value > dtpTimeEnd.Value)
                dtpTimeStart.Value = dtpTimeEnd.Value.Subtract(TimeSpan.FromDays(1));
        }

        double CalculateTotalAmount()
        {
            double totalAmount = 0;
            for (int i = 0; i < dgvReport.RowCount; i++)
                totalAmount += double.Parse(dgvReport["Giá nhập", i].Value.ToString()) * double.Parse(dgvReport["Tổng số lượng", i].Value.ToString());
            return totalAmount;
        }

        private void splBtnGet_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = cirBLL.Get(dtpTimeStart.Value, dtpTimeEnd.Value);
            txtEdtTotalAmount.Text = CalculateTotalAmount() + "";
        }

        private void splBtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                frmCommodityInputReport cir = new frmCommodityInputReport(dtpTimeStart.Value, dtpTimeEnd.Value, double.Parse(txtEdtTotalAmount.Text));
                cir.ShowDialog();
            }
        }

        private void splBtnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvReport.DataSource;
                Export(dt, "Thống kê hàng nhập", "THỐNG KÊ HÀNG NHẬP TỪ NGÀY " + dtpTimeStart.Value.ToString("dd-MM-yyyy") +
                                        " ĐẾN NGÀY " + dtpTimeEnd.Value.ToString("dd-MM-yyyy"));
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên hàng hoá";
            cl1.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Giá nhập";
            cl2.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tổng số lượng";
            cl3.ColumnWidth = 16.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

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