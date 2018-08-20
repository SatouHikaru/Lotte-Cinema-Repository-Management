using System;

namespace BusinessLogicLayer
{
    public class GoodsReceiptNote
    {
        public string GRN_No { get; set; }
        public DateTime Date { get; set; }
        public Commodity Commodity { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public Supplier Supplier { get; set; }
        public Employee Employee { get; set; }

        public GoodsReceiptNote()
        {
            Commodity = new Commodity();
            Supplier = new Supplier();
            Employee = new Employee();
        }
    }
}