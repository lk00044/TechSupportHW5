using Customers.Model;
using System.Data.SqlClient;
using System.Xml.Linq;
using TechSupport.DAL;

/// <summary>
/// Get the Customer data from database 
/// </summary>

namespace Customers.DAL
{
    public class CustomersDBDAL {

        /// <summary>
        /// Gets the customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            string selectStatement =
                "SELECT CustomerID, Name, Address, City, State, ZipCode, Phone, Email " +
                "FROM Customers "
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
                            Customer customer = new Customer();
                            customer.CustomerID = (int)reader["CustomerID"];
                            customer.Name = reader["Name"].ToString();
                            customer.Address = reader["Address"].ToString();
                            customer.City = reader["City"].ToString();
                            customer.State = reader["State"].ToString();
                            customer.ZipCode = reader["ZipCode"].ToString();
                            customer.Phone = reader["Phone"].ToString();
                            customer.Email = reader["Email"].ToString();

                            customerList.Add(customer);
                        }
                    }
                }
            }
            return customerList;
        }

        /// <summary>
        /// Gets the customer based on the customer name.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <returns></returns>
        public Customer GetCustomer(int customerID)
        {
            Customer customer = new Customer(); 

            string selectStatement =
                "SELECT CustomerID, Name, Address, City, State, ZipCode, Phone, Email " +
                "FROM Customers " +
                "WHERE CustomerID = @customerID"
                ;
           

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@customerID", customerID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer.CustomerID = (int)reader["CustomerID"];
                            customer.Name = reader["Name"].ToString();
                            customer.Address = reader["Address"].ToString();
                            customer.City = reader["City"].ToString();
                            customer.State = reader["State"].ToString();
                            customer.ZipCode = reader["ZipCode"].ToString();
                            customer.Phone = reader["Phone"].ToString();
                            customer.Email = reader["Email"].ToString();

                        }
                    }
                }
            }
            return customer;
        }

        public int GetCustomerID(string customerName)
        {
            Customer customer = new Customer();

            string selectStatement =
                "SELECT CustomerID, Name " +
                "FROM Customers " +
                "WHERE Name = @customerName"
                ;


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@customerName", customerName);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer.CustomerID = (int)reader["CustomerID"];
                            customer.Name = reader["Name"].ToString();

                        }
                    }
                }
            }
            return customer.CustomerID;
        }
    }
}
