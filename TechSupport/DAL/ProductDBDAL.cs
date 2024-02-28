using System.Data.SqlClient;
using Customers.Model;
using Products.Model;
using TechSupport.DAL;

namespace Products.DAL
{
    public class ProductDBDAL
    {
        public List <Product> GetProducts()
        {
            List<Product> productList = new List<Product>();

            string selectStatement =
                "SELECT ProductCode, Name, Version, ReleaseDate " +
                "FROM Products "
                ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.ProductCode = reader["ProductCode"].ToString();
                            product.ProductName = reader["ProductName"].ToString();
                            product.Version = (double) reader["Version"];
                           // product.ReleaseDate = reader.IsDBNull(int columnOrdinal)
                            product.ReleaseDate = (DateTime) reader["ReleaseDate"];
                        
                            productList.Add(product);
                        }
                    }
                }
            }
            return productList;
        }

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetProductNames()
        {

            List<string> names = new List<string>();

            string selectStatement =
                "SELECT Name " +
                "FROM Products "
                ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ProductName = reader["Name"].ToString();

                            names.Add(ProductName);
                        }
                    }
                }
            }
            return names;
        }

        public string GetProductCode(string prodName)
        {
            Product product = new Product();

            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM Products " +
                "WHERE Name = @prodName "
                ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@prodName", prodName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.ProductCode = reader["ProductCode"].ToString();
                        }
                    }
                }
            }
            return product.ProductCode;
        }
    }
}

