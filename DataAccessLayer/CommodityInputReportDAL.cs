using System;
using System.Data;

namespace DataAccessLayer
{
    public class CommodityInputReportDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public DataTable Get(DateTime timeStart, DateTime timeEnd)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@TimeStart";
            timeStart = DateTime.Parse(timeStart.ToShortDateString() + " 12:00 AM");
            value[0] = timeStart;
            name[1] = "@TimeEnd";
            timeEnd = DateTime.Parse(timeEnd.ToShortDateString() + " 11:59 PM");
            value[1] = timeEnd;
            return db.Get("sp_GoodsReceiptNoteDetails_SelectBetweenTimeGroupByName", name, value, 2);
        }
    }
}