using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AccountBLL
    {
        AccountDAL accountDAL = new AccountDAL();

        public DataTable Login(Account account)
        {
            return accountDAL.Login(account.Username, account.Password);
        }

        public DataTable ResetPassword(Account account)
        {
            return accountDAL.ResetPassword(account.Username, account.Password);
        }

        public int SendMessage(Account account)
        {
            return accountDAL.SendMessage(account.Username);
        }

        public DataTable GetAll()
        {
            return accountDAL.GetAll();
        }

        public DataTable GetByUsername(Account account)
        {
            return accountDAL.GetByUsername(account.Username);
        }

        public DataTable GetByName(Account account)
        {
            return accountDAL.GetByName(account.Name);
        }

        public int Add(Account account)
        {
            return accountDAL.Add(account.Username, account.Password, account.Name, account.Role);
        }

        public int Delete(Account account)
        {
            return accountDAL.Delete(account.Username);
        }
    }
}