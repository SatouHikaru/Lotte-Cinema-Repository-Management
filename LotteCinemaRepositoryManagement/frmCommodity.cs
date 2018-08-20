using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmCommodity : Form
    {
        public frmCommodity()
        {
            InitializeComponent();
        }

        private void frmCommodity_Load(object sender, EventArgs e)
        {
            crCommodity commodity = new crCommodity();
            commodity.SetParameterValue("Date", DateTime.Now);
            crystalReportViewer.ReportSource = commodity;
        }
    }
}
