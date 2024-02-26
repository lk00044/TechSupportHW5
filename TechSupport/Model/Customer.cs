
/// <summary>
/// Class to represent the customer
/// </summary>
namespace Customers.Model
{
    public class Customer
    {

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <param name="custID">The customer identifier.</param>
        /// <returns></returns>
        public string GetCustomerName(int custID)
        {
            return Name;
        }

    }


}
