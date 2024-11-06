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
    public class SQLMilestones : MilestonesProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override int DeleteMilestones(Milestones milestones)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_Milestones", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = milestones.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = milestones.UpdatedUser;
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

        public override Milestones GetMilestonesById(int Id)
        {
            Milestones milestones = new Milestones();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Milestones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    milestones.Id = Convert.ToInt32(reader["Id"]);
                    milestones.MilestonesName = reader["MilestonesName"].ToString();
                    milestones.MilestonesValue = reader["MilestonesValue"].ToString();
                }
            }
            return milestones;
        }

        public override DataTable GetMilestonesList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Milestones", con);

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

        public override int InsertMilestones(Milestones milestones)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Milestones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MilestonesName", SqlDbType.VarChar, 500).Value = milestones.MilestonesName;
                cmd.Parameters.Add("@MilestonesValue", SqlDbType.VarChar, 200).Value = milestones.MilestonesValue;
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

        public override int UpdateMilestones(Milestones milestones)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Milestones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = milestones.Id;
                cmd.Parameters.Add("@MilestonesName", SqlDbType.VarChar, 500).Value = milestones.MilestonesName;
                cmd.Parameters.Add("@MilestonesValue", SqlDbType.VarChar, -1).Value = milestones.MilestonesValue;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = milestones.UpdatedUser;
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
