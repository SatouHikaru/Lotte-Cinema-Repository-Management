using System;

namespace BusinessLogicLayer
{
    public class GoodsIssueNote
    {
        public string GIN_No { get; set; }
        public DateTime Date { get; set; }
        public Commodity Commodity { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public Employee Employee { get; set; }

        public GoodsIssueNote()
        {
            Commodity = new Commodity();
            Employee = new Employee();
        }
    }
}