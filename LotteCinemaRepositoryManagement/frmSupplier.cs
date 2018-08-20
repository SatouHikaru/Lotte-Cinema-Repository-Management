using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            crSupplier supplier = new crSupplier();
            supplier.SetParameterValue("Date", DateTime.Now);
            crystalReportViewer.ReportSource = supplier;
        }
    }
}