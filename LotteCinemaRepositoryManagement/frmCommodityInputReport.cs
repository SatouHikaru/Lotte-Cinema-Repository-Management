using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmCommodityInputReport : Form
    {
        string timeStart;
        string timeEnd;
        double total;

        public frmCommodityInputReport(DateTime timeStart, DateTime timeEnd, double total)
        {
            InitializeComponent();
            this.timeStart = timeStart.ToString("yyyy-MM-dd") + " 12:00 AM";
            this.timeEnd = timeEnd.ToString("yyyy-MM-dd") + " 11:59 PM";
            this.total = total;
        }

        private void frmReportHangNhap_Load(object sender, EventArgs e)
        {
            crCommodityInputReport input = new crCommodityInputReport();
            input.SetParameterValue("@TimeStart", DateTime.Parse(timeStart));
            input.SetParameterValue("@TimeEnd", DateTime.Parse(timeEnd));
            input.SetParameterValue("Total", total);
            crystalReportViewer.ReportSource = input;
        }
    }
}