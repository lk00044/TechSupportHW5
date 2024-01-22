using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Leslie Keller

namespace TechSupport.Model
{

    public class Incident
    /// <summary>
    /// Class that will keep the Incident objects
    /// </summary>
    {
        public string title { get;  }
        public string description { get;  }
        public int customerID { get; }

        /// <summary>
        /// Constructor to create the Incident object
        /// </summary>
        /// <param name="Title"></param>            The title of the incident
        /// <param name="Description"></param>      The description of the incident
        /// <param customerID="customerID"></param> The customer id of the incident
        /// <exception cref="ArgumentNullException"></exception>
        public Incident(string UserName, string Password, int customerID)
        {
            if (string.IsNullOrEmpty(UserName))
                throw new ArgumentNullException("UserName cannot be empty", "title");

            if (string.IsNullOrEmpty(Password))
                throw new ArgumentNullException("description cannot be empty", "title");

            if (string.IsNullOrEmpty(customerID.ToString()))
                throw new ArgumentNullException("Customer ID cannot be empty", "title");

            this.title = UserName;
            this.description = Password;
            this.customerID = customerID;
        }

    }
}
