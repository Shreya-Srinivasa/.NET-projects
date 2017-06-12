using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using iDAL;

namespace adoDAL
{
    public class AdoDal:iDAL.iDAL
    {
        string _connectionString = "Data Source=DESKTOP-B2UJG1E\\SQLEXPRESS01;Initial Catalog=shoppingDB;Integrated Security=True";
        SqlConnection _objConnection = new SqlConnection();

        public Product GetProductByProductID(int productID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                _objConnection.ConnectionString = _connectionString;
                _objConnection.Open();
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = _objConnection;
                objCommand.CommandType = System.Data.CommandType.StoredProcedure;
                objCommand.CommandText = "GetProductsSP";
                SqlDataReader objDataReader = objCommand.ExecuteReader();

                while (objDataReader.Read())
                {
                    products.Add(new Product { productID = Convert.ToInt16(objDataReader["productID"]), productName = objDataReader["productName"].ToString() });
                }

            }
            catch (Exception)
            {

                //throw;
                // log error to database
            }
            finally
            {
                _objConnection.Close();

            }

            return products;

        }

        public int InsertProduct(Product objProduct)
        {
            try
            {
                _objConnection.ConnectionString = _connectionString;
                _objConnection.Open();
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = _objConnection;
                objCommand.CommandType = System.Data.CommandType.StoredProcedure;
                objCommand.CommandText = "InsertProductToTblProductsSP";
                int result = objCommand.ExecuteNonQuery();
                return result;
            }
            catch
            {

                return 0;
            }
               finally
            {
                _objConnection.Close();

            }
        }

      
    }
}

