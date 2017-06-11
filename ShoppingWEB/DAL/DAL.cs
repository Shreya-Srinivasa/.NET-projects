using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace adoDAL
{
    public class DAL
    {
        string _connectionString = "Data Source=DESKTOP-B2UJG1E\\SQLEXPRESS01;Initial Catalog=shoppingDB;Integrated Security=True";
        SqlConnection _objConnection = new SqlConnection();

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
                objCommand.CommandText = "GetProductsSPs";
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
    }
}

