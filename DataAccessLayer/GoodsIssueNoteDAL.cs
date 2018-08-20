using System;
using System.Data;

namespace DataAccessLayer
{
    public class GoodsIssueNoteDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public void GetDate(DataTable dt)
        {
            db.GetData("GoodsIssueNote", dt);
        }

        public void GetEmployeeName(DataTable dt)
        {
            db.GetData("Employee", dt);
        }

        public void GetCommodityName(DataTable dt)
        {
            db.GetData("Commodity", dt);
        }

        public DataTable GetByNumber(string ginNo)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            return db.Get("sp_GoodsIssueNoteDetails_SelectByNumber", name, value, 1);
        }

        public int Add(DateTime date, string employeeID)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Date";
            value[0] = date;
            name[1] = "@EmployeeID";
            value[1] = employeeID;
            return db.Excute("sp_GoodsIssueNote_Insert", name, value, 2);
        }

        public int AddDetails(string ginNo, string commodityID, double cost, int quantity)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            name[1] = "@CommodityID";
            value[1] = commodityID;
            name[2] = "@Cost";
            value[2] = cost;
            name[3] = "@Quantity";
            value[3] = quantity;
            return db.Excute("sp_GoodsIssueNoteDetails_Insert", name, value, 4);
        }

        public int Update(string ginNo, string employeeID)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            name[1] = "@EmployeeID";
            value[1] = employeeID;
            return db.Excute("sp_GoodsIssueNote_Update", name, value, 2);
        }

        public int UpdateDetails(string ginNo, string commodityID, double cost, int quantity)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            name[1] = "@CommodityID";
            value[1] = commodityID;
            name[2] = "@Cost";
            value[2] = cost;
            name[3] = "@Quantity";
            value[3] = quantity;
            return db.Excute("sp_GoodsIssueNoteDetails_Update", name, value, 4);
        }

        public int Delete(string ginNo)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            return db.Excute("sp_GoodsIssueNote_Delete", name, value, 1);
        }

        public int Remove(string ginNo, string commodityID)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            name[1] = "@CommodityID";
            value[1] = commodityID;
            return db.Excute("sp_GoodsIssueNoteDetails_Delete", name, value, 2);
        }

        public DataTable Display()
        {
            return db.Get("sp_GoodsIssueNoteAudit_Select", name, value, 0);
        }

        public DataTable DisplayDetails()
        {
            return db.Get("sp_GoodsIssueNoteDetailsAudit_Select", name, value, 0);
        }

        public int Recover(string ginNo, DateTime date, string employeeID)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@GIN_No";
            value[0] = ginNo;
            name[1] = "@Date";
            value[1] = date;
            name[2] = "@EmployeeID";
            value[2] = employeeID;
            return db.Excute("sp_GoodsIssueNoteAudit_Insert", name, value, 3);
        }
    }
}