using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.SqlClient
{
    public class SQLContactEnquiry : ContactEnquiryProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override DataTable GetContactList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ContactEnquiry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetAll";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
            }

            return dataTable;
        }

        public override int InsertContact(ContactEnquiry ContactEnquiry)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_ContactEnquiry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar, 20).Value = ContactEnquiry.FullName;
                cmd.Parameters.Add("@EmailId", SqlDbType.VarChar, 100).Value = ContactEnquiry.EmailId;
                cmd.Parameters.Add("@MobileNo", SqlDbType.VarChar, 20).Value = ContactEnquiry.MobileNo;
                cmd.Parameters.Add("@NatureOfEnquiry", SqlDbType.VarChar, 200).Value = ContactEnquiry.NatureOfEnquiry;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = ContactEnquiry.Description;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = ContactEnquiry.CreatedUser;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "Insert";
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch
            {
                return i;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
