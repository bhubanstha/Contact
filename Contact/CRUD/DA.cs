using System;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Configuration;

namespace Contact.CRUD
{
    public class DataAccess
    {        
        public static SqlCommand CreateCommand()
        {
            var con = new SqlConnection { ConnectionString = ConnectionString() };
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static DataTable ExecuteReaderCommand(SqlCommand cmd)
        {
            cmd.Connection.Open();
            var rdr = cmd.ExecuteReader();
            var tbl = new DataTable();
            tbl.Load(rdr);
            cmd.Connection.Close();
            return tbl;
        }

        public static int ExecuteNonQuery(SqlCommand cmd)
        {
            var i = -1;
            cmd.Connection.Open();
            i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return i;
        }

        public static string ExecuteScalarCommand(SqlCommand cmd)
        {
            var data = "";
            cmd.Connection.Open();
            data = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
            return data;
        }

        private static string ConnectionString()
        {
            var connectionString = "";
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(CultureInfo.InvariantCulture), "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connectionString;
        }

        ~DataAccess()
        {
            GC.Collect();

        }
    }


}