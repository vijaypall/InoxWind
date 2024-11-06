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
    public class SQLNewsRoom : NewsRoomProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override int ActiveDectiveRecord(NewsRoom newsRoom)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_NewsRoom", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = newsRoom.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = newsRoom.UpdatedUser;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "ActiveDeActive";
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

        public override NewsRoom GetRecordById(int Id)
        {
            NewsRoom newsRoom = new NewsRoom();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_NewsRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    newsRoom.Id = Convert.ToInt32(reader["Id"]);
                    newsRoom.ParticularsORNewspaper = reader["ParticularsORNewspaper"].ToString();
                    newsRoom.NewsDATE = reader["NewsDATE"].ToString();
                    newsRoom.NewsDoc = reader["NewsDoc"].ToString();
                    newsRoom.NewsType = reader["NewsType"].ToString();
                    newsRoom.NewsDoc = reader["NewsDoc"].ToString();
                    newsRoom.IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
            }
            return newsRoom;
        }

        public override DataTable GetRecordList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_NewsRoom", con);

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

        public override int InsertRecord(NewsRoom newsRoom)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_NewsRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ParticularsORNewspaper", SqlDbType.VarChar, 500).Value = newsRoom.ParticularsORNewspaper;
                cmd.Parameters.Add("@NewsDATE", SqlDbType.VarChar, 50).Value = newsRoom.NewsDATE;
                cmd.Parameters.Add("@NewsDoc", SqlDbType.VarChar, 500).Value = newsRoom.NewsDoc;
                cmd.Parameters.Add("@NewsType", SqlDbType.VarChar, 500).Value = newsRoom.NewsType;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = newsRoom.CreatedUser;
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

        public override int UpdateRecord(NewsRoom newsRoom)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_NewsRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = newsRoom.Id;
                cmd.Parameters.Add("@ParticularsORNewspaper", SqlDbType.VarChar, 500).Value = newsRoom.ParticularsORNewspaper;
                cmd.Parameters.Add("@NewsDATE", SqlDbType.VarChar, 50).Value = newsRoom.NewsDATE;
                cmd.Parameters.Add("@NewsDoc", SqlDbType.VarChar, 500).Value = newsRoom.NewsDoc;
                cmd.Parameters.Add("@NewsType", SqlDbType.VarChar, 500).Value = newsRoom.NewsType;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = newsRoom.UpdatedUser;
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

        public override List<NewsRoom> GetPressReleased(int Id,string NewsType)
        {
            List<NewsRoom> lstNews = new List<NewsRoom>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_NewsRoom", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetNext";
                    cmd.Parameters.Add("@NewsType", SqlDbType.VarChar, 500).Value = NewsType;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NewsRoom newsRoom = new NewsRoom();
                            newsRoom.Id = Convert.ToInt32(reader["Id"]);
                            newsRoom.ParticularsORNewspaper = reader["ParticularsORNewspaper"].ToString();
                            newsRoom.NewsDATE = reader["NewsDATE"].ToString();
                            newsRoom.NewsDoc = reader["NewsDoc"].ToString();
                            newsRoom.NewsType = reader["NewsType"].ToString();
                            newsRoom.NewsDoc = reader["NewsDoc"].ToString();
                            newsRoom.IsActive = Convert.ToBoolean(reader["IsActive"]);
                            lstNews.Add(newsRoom);

                        }
                    }
                }
                catch { }
                finally
                {
                    con.Close();
                }

            }

            return lstNews;
        }
    }
}
