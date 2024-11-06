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
    public class SQLLogin : LoginProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override Login GetLoginEmailDetail(string Email)
        {
            Login login = new Login();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EmailId", SqlDbType.VarChar,100).Value = Email;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    login.LoginId = Convert.ToInt32(reader["LoginId"]);
                    login.EmailId = reader["EmailId"].ToString();
                    login.Name = reader["Name"].ToString();
                    login.Password = reader["Password"].ToString();
                    login.LastLogin = Convert.ToDateTime(reader["LastLogin"].ToString());
                    login.LoginIP = reader["LoginIP"].ToString();
                    login.LoginBrowser = reader["LoginBrowser"].ToString();
                    login.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                }
            }
            return login;
        }
        public override Login ValidateLogin(string Email, string Password)
        {
            Login login = new Login();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EmailId", SqlDbType.VarChar,100).Value = Email;

                cmd.Parameters.Add("@password", SqlDbType.VarChar,100).Value = Password;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    login.LoginId = Convert.ToInt32(reader["LoginId"]);
                    login.EmailId = reader["EmailId"].ToString();
                    login.Name = reader["Name"].ToString();
                    login.Password = reader["Password"].ToString();
                    login.LastLogin = Convert.ToDateTime(reader["LastLogin"].ToString());
                    login.LoginIP = reader["LoginIP"].ToString();
                    login.LoginBrowser = reader["LoginBrowser"].ToString();
                    login.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                }
            }
            return login;
        }
        public override int UpdateLogin(Login login)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@LoginId", SqlDbType.Int).Value = login.LoginId;
                cmd.Parameters.Add("@LastLogin", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = login.Password;
                cmd.Parameters.Add("@LoginIP", SqlDbType.VarChar, 50).Value = login.LoginIP;
                cmd.Parameters.Add("@LoginBrowser", SqlDbType.VarChar, 500).Value = login.LoginBrowser;
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
