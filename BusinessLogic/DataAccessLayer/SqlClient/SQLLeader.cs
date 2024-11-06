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
    public class SQLLeader : LeaderProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override int DeleteLeader(Leader leader)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_Leader", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = leader.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = leader.UpdatedUser;
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

        public override Leader GetLeaderById(int Id)
        {
            Leader leader = new Leader();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Leader", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    leader.Id = Convert.ToInt32(reader["Id"]);
                    leader.OpenPopup = Convert.ToBoolean(reader["OpenPopup"]);
                    leader.Name = reader["Name"].ToString();
                    leader.Designation = reader["Designation"].ToString();
                    leader.Category = reader["Category"].ToString();
                    leader.LinkedinUrl = reader["LinkedinUrl"].ToString();
                    leader.PopupContent = reader["PopupContent"].ToString();
                    leader.ProfileImage = reader["ProfileImage"].ToString();
                    leader.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    leader.OpenPopup = Convert.ToBoolean(reader["IsActive"]);
                }
            }
            return leader;
        }

        public override DataTable GetLeaderList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Leader", con);

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

        public override int InsertLeader(Leader leader)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Leader", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = leader.Name; 
                cmd.Parameters.Add("@Designation", SqlDbType.VarChar, 100).Value = leader.Designation;
                cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = leader.Category; 
                cmd.Parameters.Add("@LinkedinUrl", SqlDbType.VarChar, 500).Value = leader.LinkedinUrl;
                cmd.Parameters.Add("@OpenPopup", SqlDbType.Bit).Value = leader.OpenPopup;
                cmd.Parameters.Add("@PopupContent", SqlDbType.NVarChar, -1).Value = leader.PopupContent; 
                cmd.Parameters.Add("@ProfileImage", SqlDbType.NVarChar, 500).Value = leader.ProfileImage; 
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = leader.CreatedUser;
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

        public override int UpdateLeader(Leader leader)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Leader", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = leader.Name;

                cmd.Parameters.Add("@Id", SqlDbType.VarChar, 100).Value = leader.Id;
                cmd.Parameters.Add("@Designation", SqlDbType.VarChar, 100).Value = leader.Designation;
                cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = leader.Category;
                cmd.Parameters.Add("@LinkedinUrl", SqlDbType.VarChar, 500).Value = leader.LinkedinUrl;
                cmd.Parameters.Add("@OpenPopup", SqlDbType.Bit).Value = leader.OpenPopup;
                cmd.Parameters.Add("@PopupContent", SqlDbType.NVarChar, -1).Value = leader.PopupContent;
                cmd.Parameters.Add("@ProfileImage", SqlDbType.NVarChar, 500).Value = leader.ProfileImage; 
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = leader.UpdatedUser;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "Update";
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
