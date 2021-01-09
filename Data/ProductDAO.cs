using ADLVShop.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADLVShop.Data
{
    internal class ProductDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ADLVShopDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        //performs all the operations related to the database. get all, create, delete, get one, search etc.

        public List<ProductModel> FetchAll()
        {
            List<ProductModel> returnList = new List<ProductModel>();

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Products";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new product object. Addit to the list to return.
                        ProductModel product = new ProductModel();
                        product.Id = reader.GetInt32(0);
                        product.ProductName = reader.GetString(1);
                        product.ProductDescription = reader.GetString(2);
                        product.ProductPrice = (double)reader.GetDecimal(3);
                        product.AvailableItems = reader.GetInt32(4);

                        returnList.Add(product);
                    }
                }
            }
                return returnList;
        }

        public ProductModel FetchOne(int Id)
        {

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Products WHERE Id = @id";

                //associate @id with Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                ProductModel product = new ProductModel();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new product object. Addit to the list to return.
                        
                        product.Id = reader.GetInt32(0);
                        product.ProductName = reader.GetString(1);
                        product.ProductDescription = reader.GetString(2);
                        product.ProductPrice = (double)reader.GetDecimal(3);
                        product.AvailableItems = reader.GetInt32(4);

                       
                    }
                }
                return product;
            }
         
        }

    }
}