using System;
using Contact.Model;
using System.Data.SqlClient;
using System.Data;

namespace Contact.CRUD
{
    public class PersonCrud
    {
        public int Add(Person p)
        {
            SqlCommand cmd = DataAccess.CreateCommand();
            cmd.CommandText = "SaveUpdatePerson";
            cmd.Parameters.AddWithValue("@FullName", p.FullName);
            cmd.Parameters.AddWithValue("@Address", p.Address);
            cmd.Parameters.AddWithValue("@PrimaryEmail", p.PrimaryEmail);
            cmd.Parameters.AddWithValue("@GroupId", p.GroupId == 0 ? null : p.GroupId);
            cmd.Parameters.AddWithValue("@Mobile1", p.Mobile1);
            cmd.Parameters.AddWithValue("@Mobile2", p.Mobile2);
            cmd.Parameters.AddWithValue("@Relation", p.Relation);
            cmd.Parameters.AddWithValue("@BirthDay", p.BirthDay);
            cmd.Parameters.AddWithValue("@Company", p.Company);
            cmd.Parameters.AddWithValue("@Title", p.Title);
            cmd.Parameters.AddWithValue("@Website", p.Website);
            cmd.Parameters.AddWithValue("@ProfEmail", p.ProfEmail);
            cmd.Parameters.AddWithValue("@Telephone1", p.Telephone1);
            cmd.Parameters.AddWithValue("@Telephone2", p.Telephone2);
            cmd.Parameters.AddWithValue("@ProfMobile1", p.ProfMobile1);
            cmd.Parameters.AddWithValue("@ProfMobile2", p.ProfMobile2);
            cmd.Parameters.AddWithValue("@Fax", p.Fax);
            cmd.Parameters.AddWithValue("@Note", p.Note);
            cmd.Parameters.AddWithValue("@Skype", p.Skype);
            cmd.Parameters.AddWithValue("@WindowsLive", p.WindowsLive);
            cmd.Parameters.AddWithValue("@Yahoo", p.Yahoo);
            cmd.Parameters.AddWithValue("@Hangout", p.Hangout);
            cmd.Parameters.AddWithValue("@Gmail", p.Gmail);
            cmd.Parameters.AddWithValue("@Facebook", p.Facebook);
            cmd.Parameters.AddWithValue("@ProfileImage", p.ImageName);
            int i = DataAccess.ExecuteNonQuery(cmd);
            return i;
        }
        public int Update(Person p, int id)
        {

            SqlCommand cmd = DataAccess.CreateCommand();
            cmd.CommandText = "SaveUpdatePerson";
            cmd.Parameters.AddWithValue("@FullName", p.FullName);
            cmd.Parameters.AddWithValue("@Address", p.Address);
            cmd.Parameters.AddWithValue("@PrimaryEmail", p.PrimaryEmail);
            cmd.Parameters.AddWithValue("@GroupId", p.GroupId == 0 ? null : p.GroupId);
            cmd.Parameters.AddWithValue("@Mobile1", p.Mobile1);
            cmd.Parameters.AddWithValue("@Mobile2", p.Mobile2);
            cmd.Parameters.AddWithValue("@Relation", p.Relation);
            cmd.Parameters.AddWithValue("@BirthDay", p.BirthDay);
            cmd.Parameters.AddWithValue("@Company", p.Company);
            cmd.Parameters.AddWithValue("@Title", p.Title);
            cmd.Parameters.AddWithValue("@Website", p.Website);
            cmd.Parameters.AddWithValue("@ProfEmail", p.ProfEmail);
            cmd.Parameters.AddWithValue("@Telephone1", p.Telephone1);
            cmd.Parameters.AddWithValue("@Telephone2", p.Telephone2);
            cmd.Parameters.AddWithValue("@ProfMobile1", p.ProfMobile1);
            cmd.Parameters.AddWithValue("@ProfMobile2", p.ProfMobile2);
            cmd.Parameters.AddWithValue("@Fax", p.Fax);
            cmd.Parameters.AddWithValue("@Note", p.Note);
            cmd.Parameters.AddWithValue("@Skype", p.Skype);
            cmd.Parameters.AddWithValue("@WindowsLive", p.WindowsLive);
            cmd.Parameters.AddWithValue("@Yahoo", p.Yahoo);
            cmd.Parameters.AddWithValue("@Hangout", p.Hangout);
            cmd.Parameters.AddWithValue("@Gmail", p.Gmail);
            cmd.Parameters.AddWithValue("@Facebook", p.Facebook);
            cmd.Parameters.AddWithValue("@ProfileImage", p.ImageName);
            cmd.Parameters.AddWithValue("@Id", id);
            int i = DataAccess.ExecuteNonQuery(cmd);
            return i;
        }
        public int Delete(int id)
        {
            try
            {
                SqlCommand cmd = DataAccess.CreateCommand();
                cmd.CommandText = "DeleteContact";
                cmd.Parameters.AddWithValue("@Id", id);
                int i = DataAccess.ExecuteNonQuery(cmd);               
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }
        public DataTable GetAllContact()
        {
            try
            {
                SqlCommand cmd = DataAccess.CreateCommand();
                cmd.CommandText = "GetAllContact";
                DataTable dt = DataAccess.ExecuteReaderCommand(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public DataTable GetContactById(int id)
        {
            try
            {
                SqlCommand cmd = DataAccess.CreateCommand();
                cmd.CommandText = "GetContactById";
                cmd.Parameters.AddWithValue("@Id", id);
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
