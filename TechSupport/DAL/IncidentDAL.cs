using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

    }



}
