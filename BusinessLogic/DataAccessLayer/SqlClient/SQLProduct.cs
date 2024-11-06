using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.DataAccessLayer.SqlClient
{
    public class SQLProduct : ProductProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public override int DeleteProduct(Product product)
        {
            int Result = 0;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("Sp_Product", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 10).Value = product.UpdatedUser;
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

        public override Product GetProductById(int Id)
        {
            Product product = new Product();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetById";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    product.Id = Convert.ToInt32(reader["Id"]);
                    product.HtmlText = reader["HtmlText"].ToString();
                    product.PID = Convert.ToInt32(reader["PID"]);
                    product.Image = reader["Image"].ToString();
                    product.TecDataID = Convert.ToInt32(reader["TecDataID"]);
                    product.TecItemID = Convert.ToInt32(reader["TecItemID"]);
                    product.TecItemValue = reader["TecItemValue"].ToString();

                    //other
                    product.ProductDesc = reader["ProductDesc"].ToString();
                    product.TechDataDesc = reader["TechDataDesc"].ToString();
                    product.TechItemDesc = reader["TechItemDesc"].ToString();
                }
            }
            return product;
        }

        public override DataTable GetProductList()
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_Product", con);
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

        public override int InsertProduct(Product product)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Pid", SqlDbType.Int).Value = product.PID;
                cmd.Parameters.Add("@HtmlText", SqlDbType.VarChar, -1).Value = product.HtmlText;
                cmd.Parameters.Add("@Image", SqlDbType.NVarChar, 500).Value = product.Image;
                cmd.Parameters.Add("@TecDataID", SqlDbType.Int).Value = product.TecDataID;
                cmd.Parameters.Add("@TecItemID", SqlDbType.Int).Value = product.TecItemID;
                cmd.Parameters.Add("@TecItemValue", SqlDbType.VarChar, 50).Value = product.TecItemValue;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CreatedUser", SqlDbType.VarChar, 50).Value = product.CreatedUser;
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

        public override int UpdateProduct(Product product)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("Sp_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
                cmd.Parameters.Add("@Pid", SqlDbType.Int).Value = product.PID;
                cmd.Parameters.Add("@HtmlText", SqlDbType.VarChar, -1).Value = product.HtmlText;
                cmd.Parameters.Add("@Image", SqlDbType.NVarChar, 500).Value = product.Image;
                cmd.Parameters.Add("@TecDataID", SqlDbType.Int).Value = product.TecDataID;
                cmd.Parameters.Add("@TecItemID", SqlDbType.Int).Value = product.TecItemID;
                cmd.Parameters.Add("@TecItemValue", SqlDbType.VarChar, 50).Value = product.TecItemValue;
                cmd.Parameters.Add("@UpdatedDate", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@UpdatedUser", SqlDbType.VarChar, 50).Value = product.UpdatedUser;
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

        public override DataSet GetProductmasterList()
        {
            DataSet dataset = new DataSet ();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "Select";
                SqlDataAdapter ada = new SqlDataAdapter(cmd); 
                ada.Fill(dataset); 

            }

            return dataset;
        }

        public override DataTable GetProductTecDataList(int PID)
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_Product", con);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.Add("@Pid", SqlDbType.Int).Value = PID;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetProductTecData";
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();

            }

            return dataTable;
        }

        public override DataTable GetProductTecItemList(int PID, int TecDataID)
        {
            DataTable dataTable = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_Product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Pid", SqlDbType.Int).Value = PID;

                cmd.Parameters.Add("@TecDataID", SqlDbType.Int).Value = TecDataID;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 50).Value = "GetProductTecItem";
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
