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
    }
}
