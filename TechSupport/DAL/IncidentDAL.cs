using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Controller;
using TechSupport.Model;

// Leslie Keller

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {

        };

        /// <summary>
        /// Add an incident to the internal structure 
        /// </summary>
        /// <param name="incident"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident incident)
        {
            if (incident == null)
                throw new ArgumentNullException("Incident cannot be null.");

            _incidents.Add(incident);
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
        /// Get the list of incidents tht match the searchID 
        /// </summary>
        /// <param name="searchID"></param>
        /// <returns>_matchingIncidents - the list that matches the searchID </returns>
        public List<Incident> GetMatchingIncidents(int searchID)
        {
            List<Incident> _matchingIncidents = new List<Incident>();

            foreach(Incident incident in _incidents)
            {
                if (incident.CustomerID == searchID)
                {
                    _matchingIncidents.Add(incident);
                }
            }

            return _matchingIncidents;

        }


    }



}
