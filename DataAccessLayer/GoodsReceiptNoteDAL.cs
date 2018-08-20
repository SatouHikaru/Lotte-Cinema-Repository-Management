using System;
using System.Data;

namespace DataAccessLayer
{
    public class GoodsReceiptNoteDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public void GetDate(DataTable dt)
        {
            db.GetData("GoodsReceiptNote", dt);
        }

        public void GetSupplierName(DataTable dt)
        {
            db.GetData("Supplier", dt);
        }

        public void GetEmployeeName(DataTable dt)
        {
            db.GetData("Employee", dt);
        }

        public void GetCommodityName(DataTable dt)
        {
            db.GetData("Commodity", dt);
        }

        public DataTable GetByNumber(string grnNo)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            return db.Get("sp_GoodsReceiptNoteDetails_SelectByNumber", name, value, 1);
        }

        public int Add(DateTime date, string supplierID, string employeeID)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@Date";
            value[0] = date;
            name[1] = "@SupplierID";
            value[1] = supplierID;
            name[2] = "@EmployeeID";
            value[2] = employeeID;
            return db.Excute("sp_GoodsReceiptNote_Insert", name, value, 3);
        }

        public int AddDetails(string grnNo, string commodityID, double cost, int quantity)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            name[1] = "@CommodityID";
            value[1] = commodityID;
            name[2] = "@Cost";
            value[2] = cost;
            name[3] = "@Quantity";
            value[3] = quantity;
            return db.Excute("sp_GoodsReceiptNoteDetails_Insert", name, value, 4);
        }

        public int Update(string grnNo, string supplierID, string employeeID)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            name[1] = "@SupplierID";
            value[1] = supplierID;
            name[2] = "@EmployeeID";
            value[2] = employeeID;
            return db.Excute("sp_GoodsReceiptNote_Update", name, value, 3);
        }

        public int UpdateDetails(string grnNo, string commodityID, double cost, int quantity)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            name[1] = "@CommodityID";
            value[1] = commodityID;
            name[2] = "@Cost";
            value[2] = cost;
            name[3] = "@Quantity";
            value[3] = quantity;
            return db.Excute("sp_GoodsReceiptNoteDetails_Update", name, value, 4);
        }

        public int Delete(string grnNo)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            return db.Excute("sp_GoodsReceiptNote_Delete", name, value, 1);
        }

        public int Remove(string grnNo, string commodityID)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            name[1] = "@CommodityID";
            value[1] = commodityID;
            return db.Excute("sp_GoodsReceiptNoteDetails_Delete", name, value, 2);
        }

        public DataTable Display()
        {
            return db.Get("sp_GoodsReceiptNoteAudit_Select", name, value, 0);
        }

        public DataTable DisplayDetails()
        {
            return db.Get("sp_GoodsReceiptNoteDetailsAudit_Select", name, value, 0);
        }

        public int Recover(string grnNo, DateTime date, string supplierID, string employeeID)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@GRN_No";
            value[0] = grnNo;
            name[1] = "@date";
            value[1] = date;
            name[2] = "@supplierID";
            value[2] = supplierID;
            name[3] = "@EmployeeID";
            value[3] = employeeID;
            return db.Excute("sp_GoodsReceiptNoteAudit_Insert", name, value, 4);
        }
    }
}