using System.Data;

namespace DataAccessLayer
{
    public class CommodityDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public DataTable GetAll()
        {
            return db.Get("sp_Commodity_Select", name, value, 0);
        }

        public DataTable GetByName(string commodityName)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@CommodityName";
            value[0] = commodityName;
            return db.Get("sp_Commodity_SelectByName", name, value, 1);
        }

        public int Add(string commodityName, string calculationUnit)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@CommodityName";
            value[0] = commodityName;
            name[1] = "@CalculationUnit";
            value[1] = calculationUnit;
            return db.Excute("sp_Commodity_Insert", name, value, 2);
        }

        public int Update(string commodityID, string commodityName, string calculationUnit)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@CommodityID";
            value[0] = commodityID;
            name[1] = "@CommodityName";
            value[1] = commodityName;
            name[2] = "@CalculationUnit";
            value[2] = calculationUnit;
            return db.Excute("sp_Commodity_Update", name, value, 3);
        }

        public int Delete(string commodityID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@CommodityID";
            value[0] = commodityID;
            return db.Excute("sp_Commodity_Delete", name, value, 1);
        }

        public DataTable Display()
        {
            return db.Get("sp_CommodityAudit_Select", name, value, 0);
        }

        public int Recover(string commodityID, string commodityName, int quantity, string calculationUnit)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@CommodityID";
            value[0] = commodityID;
            name[1] = "@CommodityName";
            value[1] = commodityName;
            name[2] = "@Quantity";
            value[2] = quantity;
            name[3] = "@CalculationUnit";
            value[3] = calculationUnit;
            return db.Excute("sp_CommodityAudit_Insert", name, value, 4);
        }
    }
}