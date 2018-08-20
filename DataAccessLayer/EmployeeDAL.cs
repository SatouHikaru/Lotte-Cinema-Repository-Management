using System;
using System.Data;

namespace DataAccessLayer
{
    public class EmployeeDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public DataTable GetAll()
        {
            return db.Get("sp_Employee_Select", name, value, 0);
        }

        public DataTable GetByName(string name)
        {
            this.name = new string[1];
            value = new object[1];
            this.name[0] = "@Name";
            value[0] = name;
            return db.Get("sp_Employee_SelectByName", this.name, value, 1);
        }

        public int Add(string fullName, bool gender, DateTime birthday, string mobilePhone)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@FullName";
            value[0] = fullName;
            name[1] = "@Gender";
            value[1] = gender;
            name[2] = "@Birthday";
            value[2] = birthday;
            name[3] = "@MobilePhone";
            value[3] = mobilePhone;
            return db.Excute("sp_Employee_Insert", name, value, 4);
        }

        public int Update(string employeeID, string fullName, bool gender, DateTime birthday, string mobilePhone)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@EmployeeID";
            value[0] = employeeID;
            name[1] = "@FullName";
            value[1] = fullName;
            name[2] = "@Gender";
            value[2] = gender;
            name[3] = "@Birthday";
            value[3] = birthday;
            name[4] = "@MobilePhone";
            value[4] = mobilePhone;
            return db.Excute("sp_Employee_Update", name, value, 5);
        }

        public int Delete(string employeeID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@EmployeeID";
            value[0] = employeeID;
            return db.Excute("sp_Employee_Delete", name, value, 1);
        }

        public DataTable Display()
        {
            return db.Get("sp_EmployeeAudit_Select", name, value, 0);
        }

        public int Recover(string employeeID, string fullName, bool gender, DateTime birthday, string mobilePhone)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@EmployeeID";
            value[0] = employeeID;
            name[1] = "@FullName";
            value[1] = fullName;
            name[2] = "@Gender";
            value[2] = gender;
            name[3] = "@Birthday";
            value[3] = birthday;
            name[4] = "@MobilePhone";
            value[4] = mobilePhone;
            return db.Excute("sp_EmployeeAudit_Insert", name, value, 5);
        }
    }
}