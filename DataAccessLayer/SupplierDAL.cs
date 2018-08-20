using System.Data;

namespace DataAccessLayer
{
    public class SupplierDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public DataTable GetAll()
        {
            return db.Get("sp_Supplier_Select", name, value, 0);
        }

        public DataTable GetByName(string supplierName)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SupplierName";
            value[0] = supplierName;
            return db.Get("sp_Supplier_SelectByName", name, value, 1);
        }

        public int Add(string supplierName, string phoneNumber, string address)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@SupplierName";
            value[0] = supplierName;
            name[1] = "@PhoneNumber";
            value[1] = phoneNumber;
            name[2] = "@Address";
            value[2] = address;
            return db.Excute("sp_Supplier_Insert", name, value, 3);
        }

        public int Update(string supplierID, string supplierName, string phoneNumber, string address)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@SupplierID";
            value[0] = supplierID;
            name[1] = "@SupplierName";
            value[1] = supplierName;
            name[2] = "@PhoneNumber";
            value[2] = phoneNumber;
            name[3] = "@Address";
            value[3] = address;
            return db.Excute("sp_Supplier_Update", name, value, 4);
        }

        public int Delete(string supplierID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SupplierID";
            value[0] = supplierID;
            return db.Excute("sp_Supplier_Delete", name, value, 1);
        }

        public DataTable Display()
        {
            return db.Get("sp_SupplierAudit_Select", name, value, 0);
        }

        public int Recover(string supplierID, string supplierName, string phoneNumber, string address)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@SupplierID";
            value[0] = supplierID;
            name[1] = "@SupplierName";
            value[1] = supplierName;
            name[2] = "@PhoneNumber";
            value[2] = phoneNumber;
            name[3] = "@Address";
            value[3] = address;
            return db.Excute("sp_SupplierAudit_Insert", name, value, 4);
        }
    }
}