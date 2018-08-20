using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            crEmployee employee = new crEmployee();
            employee.SetParameterValue("Date", DateTime.Now);
            crystalReportViewer.ReportSource = employee;
        }
    }
}