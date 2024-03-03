using Customers.DAL;
using Customers.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Handles the interaction between the view and the Customer Data Access Layer 
    /// </summary>
    public class CustomerDBController
    {
        private CustomersDBDAL CustomerSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDBController"/> class.
        /// </summary>
        public CustomerDBController()
        {
            CustomerSource = new CustomersDBDAL();
        }

        /// <summary>
        /// Returns the customers from the source 
        /// </summary>
        /// <returns> the indicents from the internal structore </returns>
        public List<Customer> GetCustomers()
        {
            return this.CustomerSource.GetCustomers();
        }

        /// <summary>
        /// Gets the customer names.
        /// </summary>
        /// <returns>list of customers with names and customer ID </returns>
        public List<Customer> GetCustomerNames()
        {
            return this.CustomerSource.GetCustomers();
        }

        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <returns></returns>
        public Customer GetCustomer(int customerID)
        {
            return this.CustomerSource.GetCustomer(customerID);
        }

        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <returns></returns>
        public int GetCustomerID(string customerName)
        {
            return this.CustomerSource.GetCustomerID(customerName);
        }
    }
}
