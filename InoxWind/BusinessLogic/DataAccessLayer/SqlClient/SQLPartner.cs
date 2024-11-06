using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.DataAccessLayer.SqlClient
{
    public class SQLPartner : PartnerProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override int DeletePartner(Partner partner)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_Partner", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = partner.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = partner.UpdatedUser;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                Result = cmd.ExecuteNonQuery();
            }
            catch (SqlException sExp)
            {
                throw new Exception(sExp.ToString());
            }
            catch (Exception exp)
            {
                throw new Exception(exp.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return Result;
        }

        public override Partner GetBannerById(int Id)
        {
            Partner partner = new Partner();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Partner", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    partner.Id = Convert.ToInt32(reader["Id"]);
                    partner.PartnerImage = reader["PartnerImage"].ToString();
                    partner.PartnerName = reader["PartnerName"].ToString();
                }
            }
            return partner;
        }

        public override DataTable GetPartnerList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Partner", con);

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

        public override int InsertPartner(Partner partner)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Partner", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PartnerName", SqlDbType.VarChar,200).Value = partner.PartnerName;
                cmd.Parameters.Add("@PartnerImage", SqlDbType.NVarChar, 5000).Value = partner.PartnerImage;
                cmd.Parameters.Add("@PartnerType", SqlDbType.NVarChar, 5000).Value = partner.PartnerType;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = partner.CreatedUser;
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
