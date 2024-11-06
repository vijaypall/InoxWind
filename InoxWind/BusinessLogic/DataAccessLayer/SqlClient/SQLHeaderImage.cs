using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.DataAccessLayer.Providers;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BusinessLogic.DataAccessLayer.SqlClient
{
    public class SQLHeaderImage : HeaderImageProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override List<HeaderImage> GetHeaderImagesList()
        {
            List<HeaderImage> headerimage = new List<HeaderImage>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HeaderImages", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetAll";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HeaderImage product = new HeaderImage
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PageName = reader["PageName"].ToString(),
                        ImageName = reader["ImageName"].ToString(),
                    };
                    headerimage.Add(product);
                }
            }

            return headerimage;
        } 
        public override int InsertHeaderImages(HeaderImage headerimages)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_HeaderImages", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PageName", SqlDbType.VarChar, 50).Value = headerimages.PageName;
                cmd.Parameters.Add("@ImageName", SqlDbType.VarChar, 500).Value = headerimages.ImageName;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 500).Value = headerimages.CreatedUser;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar,50).Value = "Insert";
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
        public override int UpdateHeaderImages(HeaderImage headerimages)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_HeaderImages", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = headerimages.Id;
                cmd.Parameters.Add("@PageName", SqlDbType.VarChar,200).Value = headerimages.PageName;
                cmd.Parameters.Add("@ImageName", SqlDbType.VarChar,200).Value = headerimages.ImageName;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = headerimages.UpdatedUser;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar,50).Value = "Update"; 
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
        public override int DeleteHeaderImages(HeaderImage headerimages)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_HeaderImages", con); 
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = headerimages.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = headerimages.UpdatedUser;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar,50).Value = "Delete";
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
        public override HeaderImage GetHeaderImagesById(int Id)
        {
            HeaderImage headerImg = new HeaderImage();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HeaderImages", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    headerImg.Id = Convert.ToInt32(reader["Id"]);
                    headerImg.PageName = reader["PageName"].ToString();
                    headerImg.ImageName = reader["ImageName"].ToString();
                }
            } 
            return headerImg;
        }

        public override List<WebsitePage> GetWebPageList()
        {
            List<WebsitePage> LstWebPage = new List<WebsitePage>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HeaderImages", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "WebPageList";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    WebsitePage webpage = new WebsitePage
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PageName = reader["PageName"].ToString()
                    };
                    LstWebPage.Add(webpage);
                }
            }

            return LstWebPage;
        }
    }
}
