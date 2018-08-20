using System;
using System.Data;

namespace DataAccessLayer
{
    public class CommodityOutputReportDAL
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
            timeEnd = DateTime.Parse(timeEnd.ToShortDateString() + " 11:59 PM");
            name[1] = "@TimeEnd";
            value[1] = timeEnd;
            return db.Get("sp_GoodsIssueNoteDetails_SelectBetweenTimeGroupByName", name, value, 2);
        }
    }
}