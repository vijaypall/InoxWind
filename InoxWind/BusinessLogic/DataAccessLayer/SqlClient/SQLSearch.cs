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
    public class SQLSearch : SearchProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override DataTable GetSearchByText(string searchtext)
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Search", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PageText", SqlDbType.NVarChar, -1).Value = searchtext;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetByText";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
            }

            return dataTable;
        }
    }
}
