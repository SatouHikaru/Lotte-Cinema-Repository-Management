using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CommodityInputReportBLL
    {
        CommodityInputReportDAL cirDAL = new CommodityInputReportDAL();

        public DataTable Get(DateTime timeStart, DateTime timeEnd)
        {
            return cirDAL.Get(timeStart, timeEnd);
        }
    }
}