// Leslie Keller

namespace DisplayIncidents.Model
{

    public class Incident
    /// <summary>
    /// Class that will keep the Incident objects
    /// </summary>
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public int CustomerID { get; set; }

        public string ProductCode { get; set; }

        public int IncidentID { get; set; }

        public int TechID { get; set; }
        
        public DateTime DateOpened { get; set; }
        
        public DateTime DateClosed { get; set; }


    }
}
