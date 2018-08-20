using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Database
    {
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;

        void GetConnection()
        {
            connect = new SqlConnection(@"Data Source=HIKARU\HIKARU;Initial Catalog=LotteCinemaRepositoryManagement;Integrated Security=True");
            connect.Open();
        }

        void Disconnect()
        {
            connect.Close();
            connect.Dispose();
        }

        public DataTable Get(string sp, string[] name, object[] value, int n)
        {
            GetConnection();
            cmd = new SqlCommand(sp, connect);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < n; i++)
                cmd.Parameters.AddWithValue(name[i], value[i]);

            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void GetData(string name, DataTable dt)
        {
            GetConnection();
            da = new SqlDataAdapter("SELECT * FROM " + name, connect);
            da.Fill(dt);
            Disconnect();
        }

        public int Excute(string sp, string[] name, object[] value, int n)
        {
            GetConnection();
            cmd = new SqlCommand(sp, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < n; i++)
                cmd.Parameters.AddWithValue(name[i], value[i]);
            return cmd.ExecuteNonQuery();
        }
    }
}