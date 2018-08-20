using System;
using System.Windows.Forms;

namespace LotteCinemaRepositoryManagement
{
    public partial class frmGoodsReceiptNote : Form
    {
        DateTime date;
        double totalAmount;

        public frmGoodsReceiptNote(string date, double totalAmount)
        {
            InitializeComponent();
            this.date = DateTime.Parse(date);
            this.totalAmount = totalAmount;
        }

        private void frmGoodsReceiptNote_Load(object sender, EventArgs e)
        {
            crGoodsReceiptNote goodsReceiptNote = new crGoodsReceiptNote();
            goodsReceiptNote.SetParameterValue("Date", date);
            goodsReceiptNote.SetParameterValue("totalAmount", totalAmount);
            crystalReportViewer.ReportSource = goodsReceiptNote;
        }
    }
}