using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmGoodsIssueNote : Form
    {
        DateTime date;
        double totalAmount;

        public frmGoodsIssueNote(string date, double totalAmount)
        {
            InitializeComponent();
            this.date = DateTime.Parse(date);
            this.totalAmount = totalAmount;
        }

        private void frmGoodsIssueNote_Load(object sender, EventArgs e)
        {
            crGoodsIssueNote goodsIssueNote = new crGoodsIssueNote();
            goodsIssueNote.SetParameterValue("Date", date);
            goodsIssueNote.SetParameterValue("TotalAmount", totalAmount);
            crystalReportViewer.ReportSource = goodsIssueNote;
        }
    }
}