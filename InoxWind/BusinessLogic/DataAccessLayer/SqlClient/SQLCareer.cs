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
    public class SQLCareer : CareerProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override List<Career> GetCareerList()
        {
            List<Career> lstCareer = new List<Career>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Career", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetAll";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Career Career = new Career
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PositionName = reader["PositionName"].ToString(),
                        RequireQualification = reader["RequireQualification"].ToString(),
                        DetailPdf = reader["DetailPdf"].ToString()
                    };
                    lstCareer.Add(Career);
                }
            }

            return lstCareer;
        }
        public override int InsertCareer(Career Career)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Career", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PositionName", SqlDbType.NVarChar, 200).Value = Career.PositionName;
                cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 500).Value = Career.Location;
                cmd.Parameters.Add("@RequireQualification", SqlDbType.NVarChar, 500).Value = Career.RequireQualification;
                cmd.Parameters.Add("@DetailPdf", SqlDbType.NVarChar, 500).Value = Career.DetailPdf;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
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

        public override int UpdateCareer(Career Career)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Career", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Career.Id;
                cmd.Parameters.Add("@PositionName", SqlDbType.NVarChar, 200).Value = Career.PositionName;
                cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 500).Value = Career.Location;
                cmd.Parameters.Add("@RequireQualification", SqlDbType.NVarChar, 500).Value = Career.RequireQualification;
                cmd.Parameters.Add("@DetailPdf", SqlDbType.NVarChar, 500).Value = Career.DetailPdf;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = Career.UpdatedUser;
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
        public override int DeleteCareer(Career Career)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_Career", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Career.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = Career.UpdatedUser;
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
        public override Career GetCareerbyId(int Id)
        {
            Career Career = new Career();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Career", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Career.Id = Convert.ToInt32(reader["Id"]);
                    Career.PositionName = reader["PositionName"].ToString();
                    Career.Location = reader["Location"].ToString();
                    Career.RequireQualification = reader["RequireQualification"].ToString();
                    Career.DetailPdf = reader["DetailPdf"].ToString();
                }
            }
            return Career;
        }



    }
}
