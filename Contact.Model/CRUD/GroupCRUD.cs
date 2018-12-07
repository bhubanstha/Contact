using System;
using Contact.Model;
using System.Data.SqlClient;
using System.Data;

namespace Contact.CRUD
{
    public class GroupCRUD
    {
        public int Add(Group g)
        {
            SqlCommand cmd = DataAccess.CreateCommand();
            cmd.CommandText = "SaveGroup";
            cmd.Parameters.AddWithValue("@Name", g.Name);
            int i = DataAccess.ExecuteNonQuery(cmd);
            return i;
        }
        public int Delete(int id)
        {
            try
            {
                SqlCommand cmd = DataAccess.CreateCommand();
                cmd.CommandText = "DeleteGroup";
                cmd.Parameters.AddWithValue("@Id", id);
                int i = DataAccess.ExecuteNonQuery(cmd);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetAllGroup()
        {
            try
            {
                SqlCommand cmd = DataAccess.CreateCommand();
                cmd.CommandText = "GetAllGroup";
                DataTable dt = DataAccess.ExecuteReaderCommand(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
    }
}
