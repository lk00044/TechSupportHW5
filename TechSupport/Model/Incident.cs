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
        public string Title { get; }
        public string Description { get;  }
        public int CustomerID { get; }

        /// <summary>
        /// Constructor to create the Incident object
        /// </summary>
        /// <param UserName="Title"></param>            The Title of the incident
        /// <param UserName="Description"></param>      The Description of the incident
        /// <param CustomerID="CustomerID"></param> The customer id of the incident
        /// <exception cref="ArgumentNullException"></exception>
        public Incident(string UserName, string Password, int CustomerID)
        {
            if (string.IsNullOrEmpty(UserName))
                throw new ArgumentNullException("UserName cannot be empty", "Title");

            if (string.IsNullOrEmpty(Password))
                throw new ArgumentNullException("Description cannot be empty", "Title");

            if (string.IsNullOrEmpty(CustomerID.ToString()))
                throw new ArgumentNullException("Customer ID cannot be empty", "Title");

            this.Title = UserName;
            this.Description = Password;
            this.CustomerID = CustomerID;
        }

    }
}
