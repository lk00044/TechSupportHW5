using Incidents.Model;

// Leslie Keller


/// <summary>
/// Data Access for the Incidents Local
/// </summary>
namespace IncidentsLocal.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>();

        /// <summary>
        /// Add an AnIncident to the internal structure 
        /// </summary>
        /// <param UserName="AnIncident"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident AnIncident)
        {
            if (AnIncident == null)
                throw new ArgumentNullException("Incident cannot be null.");

            _incidents.Add(AnIncident);
        }

        /// <summary>
        /// Get the list of incidents 
        /// </summary>
        /// <returns> the list of incidents </returns>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Get the list of incidents tht match the SearchID 
        /// </summary>
        /// <param UserName="SearchID"></param>
        /// <returns>_matchingIncidents - the list that matches the SearchID </returns>
        public List<Incident> GetMatchingIncidents(int SearchID)
        {
            List<Incident> _matchingIncidents = new List<Incident>();

            foreach (Incident incident in _incidents)
            {
                if (incident.CustomerID == SearchID)
                {
                    _matchingIncidents.Add(incident);
                }
            }

            return _matchingIncidents;

        }


    }



}
