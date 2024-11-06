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
    public class SQLBanner : BannerProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override int DeleteBanner(Banner Banner)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_Banner", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Banner.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = Banner.UpdatedUser;
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

        public override Banner GetBannerById(int Id)
        {
            Banner Banner = new Banner();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Banner", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Banner.Id = Convert.ToInt32(reader["Id"]);
                    Banner.BannerOrder = Convert.ToInt32(reader["BannerOrder"]);
                    Banner.BannerImage = reader["BannerImage"].ToString(); 
                    Banner.PopupContent = reader["PopupContent"].ToString();
                    Banner.ReadmoreUrl = reader["ReadmoreUrl"].ToString();
                }
            }
            return Banner;
        }

        public override DataTable GetBannerList()
        {
            List<Banner> lstb = new List<Banner>();
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Banner", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetAll";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                  dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                //SqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    Banner Banner = new Banner
                //    {
                //        Id = Convert.ToInt32(reader["Id"]),
                //        BannerImage = reader["BannerImage"].ToString(),
                //        PopupHeading = reader["PopupHeading"].ToString(),
                //        BannerOrder = Convert.ToInt32(reader["BannerOrder"]),
                //        PopupContent = reader["PopupContent"].ToString(),
                //        ReadmoreUrl = reader["ReadmoreUrl"].ToString(),
                //    };
                //    lstb.Add(Banner);
                //}
            }

            return dataTable;
        }

        public override int InsertBanner(Banner Banner)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Banner", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BannerOrder", SqlDbType.Int).Value = Banner.BannerOrder;
                cmd.Parameters.Add("@BannerImage", SqlDbType.NVarChar, 5000).Value = Banner.BannerImage;
                //cmd.Parameters.Add("@PopupHeading", SqlDbType.NVarChar, 5000).Value = Banner.PopupHeading;
                cmd.Parameters.Add("@PopupContent", SqlDbType.VarChar, -1).Value = Banner.PopupContent;
                cmd.Parameters.Add("@ReadmoreUrl", SqlDbType.NVarChar, 500).Value = Banner.ReadmoreUrl;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar,50).Value =Banner.CreatedUser;
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

        public override int UpdateBanner(Banner Banner)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Banner", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Banner.Id;
                cmd.Parameters.Add("@BannerOrder", SqlDbType.Int).Value = Banner.BannerOrder;
                cmd.Parameters.Add("@BannerImage", SqlDbType.NVarChar, 5000).Value = Banner.BannerImage; 
                cmd.Parameters.Add("@PopupContent", SqlDbType.VarChar, -1).Value = Banner.PopupContent;
                cmd.Parameters.Add("@ReadmoreUrl", SqlDbType.NVarChar, 500).Value = Banner.ReadmoreUrl;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = Banner.UpdatedUser;
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
