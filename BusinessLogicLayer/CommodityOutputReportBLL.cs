using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CommodityOutputReportBLL
    {
        CommodityOutputReportDAL corDAL = new CommodityOutputReportDAL();

        public DataTable Get(DateTime timeStart, DateTime timeEnd)
        {
            return corDAL.Get(timeStart, timeEnd);
        }
    }
}