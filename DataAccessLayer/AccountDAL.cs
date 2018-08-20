using System.Data;

namespace DataAccessLayer
{
    public class AccountDAL
    {
        Database db = new Database();
        string[] name = { };
        object[] value = { };

        public DataTable Login(string username, string password)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Username";
            value[0] = username;
            name[1] = "@Password";
            value[1] = password;
            return db.Get("sp_Login", name, value, 2);
        }

        public DataTable ResetPassword(string username, string password)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Username";
            value[0] = username;
            name[1] = "@Password";
            value[1] = password;
            return db.Get("sp_Account_UpdatePassword", name, value, 2);
        }

        public int SendMessage(string username)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Username";
            value[0] = username;
            name[1] = "@Message";
            value[1] = "Forgot password";
            return db.Excute("sp_Account_UpdateMessage", name, value, 2);
        }

        public DataTable GetAll()
        {
            return db.Get("sp_AccountAudit_Select", name, value, 0);
        }

        public DataTable GetByUsername(string username)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Username";
            value[0] = username;
            return db.Get("sp_Account_SelectByUsername", name, value, 1);
        }

        public DataTable GetByName(string name)
        {
            this.name = new string[1];
            value = new object[1];
            this.name[0] = "@Name";
            value[0] = name;
            return db.Get("sp_Account_SelectByName", this.name, value, 1);
        }

        public int Add(string username, string password, string name, string role)
        {
            this.name = new string[4];
            value = new object[4];
            this.name[0] = "@Username";
            value[0] = username;
            this.name[1] = "@Password";
            value[1] = password;
            this.name[2] = "@Name";
            value[2] = name;
            this.name[3] = "@Role";
            value[3] = role;
            return db.Excute("sp_Account_Insert", this.name, value, 4);
        }

        public int Delete(string username)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Username";
            value[0] = username;
            return db.Excute("sp_Account_Delete", name, value, 1);
        }
    }
}