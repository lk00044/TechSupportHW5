// Leslie Keller


using Customers.Model;

/// <summary>
/// Class that will keep the Incident objects
/// </summary>
namespace Incidents.Model
{

    public class Incident
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string ProductCode { get; set; }

        public int IncidentID { get; set; }

        public int TechID { get; set; }

        public string TechName { get; set; }

        public DateTime DateOpened { get; set; }
        
        public DateTime? DateClosed { get; set; }


        /// <summary>
        /// Constructor to create the Incident object
        /// </summary>
        /// <param UserName="Title"></param>            The Title of the incident
        /// <param UserName="Description"></param>      The Description of the incident
        /// <param CustomerID="CustomerID"></param> The customer id of the incident
        /// <exception cref="ArgumentNullException"></exception>
        public Incident(string Title, string Description, string prodName, int CustomerID)
        {
            if (string.IsNullOrEmpty(Title))
                throw new ArgumentNullException("UserName cannot be empty", "Title");

            if (string.IsNullOrEmpty(Description))
                throw new ArgumentNullException("Description cannot be empty", "Title");

            if (string.IsNullOrEmpty(CustomerID.ToString()))
                throw new ArgumentNullException("Customer ID cannot be empty", "Title");

            this.Title = Title;
            this.Description = Description;
            this.CustomerID = CustomerID;
            this.Pr

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Incident"/> class.
        /// Default constructor with no params
        /// </summary>
        public Incident() { }
    }


}
