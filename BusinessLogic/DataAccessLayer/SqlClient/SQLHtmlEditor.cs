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
  public  class SQLHtmlEditor :HtmlEditorProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override int DeleteRecord(HtmlEditor htmlEditor)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("sp_HtmlEditor", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = htmlEditor.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = htmlEditor.UpdatedUser;
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

        public override HtmlEditor GetRecordById(int Id)
        {
            HtmlEditor htmlEditor = new HtmlEditor();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HtmlEditor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    htmlEditor.Id = Convert.ToInt32(reader["Id"]); 
                    htmlEditor.HtmlText = reader["HtmlText"].ToString();
                    htmlEditor.PageName = reader["PageName"].ToString();
                    htmlEditor.SideImage = reader["SideImage"].ToString();
                    htmlEditor.KnowMoreLink = reader["KnowMoreLink"].ToString();
                }
            }
            return htmlEditor;
        }

        public override DataTable GetRecordList()
        { 
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HtmlEditor", con);

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

        public override int InsertRecord(HtmlEditor htmlEditor)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_HtmlEditor", con);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.Add("@PageName", SqlDbType.NVarChar, 5000).Value = htmlEditor.PageName;
                cmd.Parameters.Add("@HtmlText", SqlDbType.VarChar, -1).Value = htmlEditor.HtmlText;
                cmd.Parameters.Add("@SideImage", SqlDbType.NVarChar, 5000).Value = htmlEditor.SideImage; 
                cmd.Parameters.Add("@KnowMoreLink", SqlDbType.VarChar, 5000).Value = htmlEditor.KnowMoreLink;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = htmlEditor.CreatedUser;
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

        public override int UpdateRecord(HtmlEditor htmlEditor)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_HtmlEditor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = htmlEditor.Id;
                cmd.Parameters.Add("@PageName", SqlDbType.NVarChar, 5000).Value = htmlEditor.PageName;
                cmd.Parameters.Add("@HtmlText", SqlDbType.VarChar, -1).Value = htmlEditor.HtmlText;
                cmd.Parameters.Add("@SideImage", SqlDbType.NVarChar, 5000).Value = htmlEditor.SideImage; 
                cmd.Parameters.Add("@KnowMoreLink", SqlDbType.VarChar, 5000).Value = htmlEditor.KnowMoreLink;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 100).Value = htmlEditor.UpdatedUser;
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
