using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmCommodityOutputReport : Form
    {
        string timeStart;
        string timeEnd;
        double total;

        public frmCommodityOutputReport(DateTime timeStart, DateTime timeEnd, double total)
        {
            InitializeComponent();
            this.timeStart = timeStart.ToString("yyyy-MM-dd") + " 12:00 AM";
            this.timeEnd = timeEnd.ToString("yyyy-MM-dd") + " 11:59 PM";
            this.total = total;
        }

        private void frmReportHangXuat_Load(object sender, EventArgs e)
        {
            crCommodityOutputReport output = new crCommodityOutputReport();
            output.SetParameterValue("@TimeStart", DateTime.Parse(timeStart));
            output.SetParameterValue("@TimeEnd", DateTime.Parse(timeEnd));
            output.SetParameterValue("Total", total);
            crystalReportViewer.ReportSource = output;
        }
    }
}
