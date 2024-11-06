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
    public class SQLDailyNews : DailyNewsProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public override int DeleteDailyNews(DailyNews dailyNews)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_DailyNews", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = dailyNews.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = dailyNews.UpdatedUser;
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

        public override DailyNews GetDailyNewsById(int Id)
        {
            DailyNews dailyNews = new DailyNews();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DailyNews", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dailyNews.Id = Convert.ToInt32(reader["Id"]);
                    dailyNews.NewsContent = reader["NewsContent"].ToString();
                    dailyNews.NewsHeading = reader["NewsHeading"].ToString();
                    dailyNews.NewsImage = reader["NewsImage"].ToString();
                    dailyNews.ChannelName = reader["ChannelName"].ToString();
                    dailyNews.OpenMediaPopup = Convert.ToBoolean(reader["OpenMediaPopup"].ToString());
                    dailyNews.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    dailyNews.NewsLink = reader["NewsLink"].ToString();
                }
            }
            return dailyNews;
        }

        public override DataTable GetDailyNewsList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DailyNews", con);

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

        public override int InsertDailyNews(DailyNews dailyNews)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_DailyNews", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NewsHeading", SqlDbType.VarChar, 200).Value = dailyNews.NewsHeading;
                cmd.Parameters.Add("@NewsContent", SqlDbType.VarChar, 500).Value = dailyNews.NewsContent;
                cmd.Parameters.Add("@ChannelName", SqlDbType.VarChar, 200).Value = dailyNews.ChannelName;
                cmd.Parameters.Add("@NewsImage", SqlDbType.VarChar, 500).Value = dailyNews.NewsImage;
                cmd.Parameters.Add("@OpenMediaPopup", SqlDbType.Bit).Value = dailyNews.OpenMediaPopup;
                cmd.Parameters.Add("@NewsLink", SqlDbType.VarChar, 500).Value = dailyNews.NewsLink;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = dailyNews.CreatedUser;
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

        public override int UpdateDailyNews(DailyNews dailyNews)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_DailyNews", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = dailyNews.Id;
                cmd.Parameters.Add("@NewsHeading", SqlDbType.VarChar, 200).Value = dailyNews.NewsHeading;
                cmd.Parameters.Add("@NewsContent", SqlDbType.VarChar, 500).Value = dailyNews.NewsContent;
                cmd.Parameters.Add("@ChannelName", SqlDbType.VarChar, 200).Value = dailyNews.ChannelName;
                cmd.Parameters.Add("@NewsImage", SqlDbType.VarChar, 500).Value = dailyNews.NewsImage;
                cmd.Parameters.Add("@NewsLink", SqlDbType.VarChar, 500).Value = dailyNews.NewsLink;
                cmd.Parameters.Add("@OpenMediaPopup", SqlDbType.Bit).Value = dailyNews.OpenMediaPopup;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = dailyNews.UpdatedUser;
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

        public override List<DailyNews> GetPressDalilyNews(int Id)
        {
            List<DailyNews> lstDailyNews = new List<DailyNews>();
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DailyNews", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetNext";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DailyNews dailyNews = new DailyNews();
                    dailyNews.Id = Convert.ToInt32(reader["Id"]);
                    dailyNews.NewsContent = reader["NewsContent"].ToString();
                    dailyNews.NewsHeading = reader["NewsHeading"].ToString();
                    dailyNews.NewsImage = reader["NewsImage"].ToString();
                    dailyNews.ChannelName = reader["ChannelName"].ToString();
                    dailyNews.OpenMediaPopup = Convert.ToBoolean(reader["OpenMediaPopup"].ToString());
                    dailyNews.IsActive = Convert.ToBoolean(reader["IsActive"]); 
                    dailyNews.NewsLink = reader["NewsLink"].ToString();
                    lstDailyNews.Add(dailyNews);
                }
            }
            return lstDailyNews;
        }
    }
}
