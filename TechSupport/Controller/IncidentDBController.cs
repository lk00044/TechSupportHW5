﻿using Incidents.DAL;
using Incidents.Model;

// Leslie Keller

namespace DisplayDBIncidents.Controller
{
    /// <summary>
    /// Handles the interaction between the view and the Login Data Access Layer (LoginDAL)
    /// </summary>
    public class IncidentDBController
    {
        private IncidentDBDAL IncidentSource;

        /// <summary>
        /// Constructor to mediate between the IncidentDAL and the view.
        /// </summary>
        public IncidentDBController()
        {
            this.IncidentSource = new IncidentDBDAL();
        }



        /// <summary>
        /// Returns the incidents from the source 
        /// </summary>
        /// <returns> the indicents from the internal structore </returns>
        public List<Incident> GetIncidents()
        {
            return this.IncidentSource.GetIncidents();
        }

        public List<Incident> GetOpenIncidents()
        {
            return this.IncidentSource.GetOpenIncidents();

        }

        /// <summary>
        /// Add an incident to the internal structure 
        /// </summary>
        /// <param UserName="incident"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident incident)
        {
            if (incident == null)
                throw new ArgumentNullException("Incident cannot be null.");

            this.IncidentSource.AddIncident(incident);
        }
    }
}
