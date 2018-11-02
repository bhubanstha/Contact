using System.Data;
using System.Data.SqlClient;

namespace Contact.CRUD
{
    class UserCrud
    {
        public int ChangePassword(string password, string userName)
        {
            SqlCommand cmd = DataAccess.CreateCommand();
            cmd.CommandText = "ChangePassword";
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Name", userName);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetUser(string password, string userName)
        {
            SqlCommand cmd = DataAccess.CreateCommand();
            cmd.CommandText = "GetUser";
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Name", userName);
            return DataAccess.ExecuteReaderCommand(cmd);
        }

        public DataTable GetUser(string userName)
        {
            SqlCommand cmd = DataAccess.CreateCommand();
            cmd.CommandText = "GetUserByName";
            cmd.Parameters.AddWithValue("@Name", userName);
            return DataAccess.ExecuteReaderCommand(cmd);
        }

    }
}
