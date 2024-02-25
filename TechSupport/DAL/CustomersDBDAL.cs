using Customers.Model;
using System.Data.SqlClient;
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
        /// Gets the customer identifier.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <returns></returns>
        public Customer GetCustomer(string customerName)
        {
            List<Customer> aList = new List<Customer>();
            aList = this.GetCustomers();
            foreach (Customer a in aList)
            {
                if (a.Name == customerName)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
