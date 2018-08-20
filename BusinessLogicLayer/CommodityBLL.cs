using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CommodityBLL
    {
        CommodityDAL commodityDAL = new CommodityDAL();

        public DataTable GetAll()
        {
            return commodityDAL.GetAll();
        }

        public DataTable GetByName(Commodity commodity)
        {
            return commodityDAL.GetByName(commodity.Name);
        }

        public int Add(Commodity commodity)
        {
            return commodityDAL.Add(commodity.Name, commodity.CalculationUnit);
        }

        public int Update(Commodity commodity)
        {
            return commodityDAL.Update(commodity.ID, commodity.Name, commodity.CalculationUnit);
        }

        public int Delete(Commodity commodity)
        {
            return commodityDAL.Delete(commodity.ID);
        }

        public DataTable Display()
        {
            return commodityDAL.Display();
        }

        public int Recover(Commodity commodity)
        {
            return commodityDAL.Recover(commodity.ID, commodity.Name, commodity.Quantity, commodity.CalculationUnit);
        }
    }
}