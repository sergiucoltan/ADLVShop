using ADLVShop.Models;
using System;
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

        internal int Delete(int id)
        {
            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "DELETE FROM dbo.Products WHERE Id = @Id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add(@"Id", System.Data.SqlDbType.VarChar, 500).Value = id;               

                connection.Open();
                int deletedID = command.ExecuteNonQuery();

                return deletedID;
            }
        }

        internal List<ProductModel> SearchForName(string searchPhrase)
        {
            List<ProductModel> returnList = new List<ProductModel>();

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Products WHERE PRODUCT_NAME LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

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

                return returnList;

            }
        }


        internal List<ProductModel> SearchForDescription(string searchDescription)
        {
            List<ProductModel> returnList = new List<ProductModel>();

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Products WHERE PRODUCT_DESCRIPTION LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchDescription + "%";

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

                return returnList;

            }
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

        //create new

        public int CreateOrUpdate(ProductModel productModel)
        {
            //if productmodel.id <= 1 then create

            //if productmodel.id > 1 then update is meant.



            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "";

                if (productModel.Id <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.Products Values(@ProductName, @ProductDescription, @ProductPrice, @AvailableItems)";
                }
                else
                {
                    //update
                    sqlQuery = "UPDATE dbo.Products SET ProductName = @ProductName, ProductDescription = @ProductDescription, ProductPrice = @ProductPrice, AvailableItems = @AvailableItems WHERE Id = @Id)";
                }
                    
                    
           
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add(@"Id", System.Data.SqlDbType.VarChar, 500).Value = productModel.Id;
                command.Parameters.Add(@"ProductName", System.Data.SqlDbType.VarChar, 500).Value = productModel.ProductName;
                command.Parameters.Add(@"ProductDescription", System.Data.SqlDbType.VarChar, 500).Value = productModel.ProductDescription;
                command.Parameters.Add(@"ProductPrice", System.Data.SqlDbType.Decimal, 5).Value = productModel.ProductPrice;
                command.Parameters.Add(@"AvailableItems", System.Data.SqlDbType.Int).Value = productModel.AvailableItems;

                connection.Open();
                int newID = command.ExecuteNonQuery();

                
                return newID;
            }

        }

        //delete one

        //update one

        //search for name

        //search for description

    }
}