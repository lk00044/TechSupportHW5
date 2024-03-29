﻿using AllIncidents.DAL;
using Incidents.Model;

// Leslie Keller

namespace Incidents.Controller
{
    /// <summary>
    /// Handles the interaction between the view and the Login Data Access Layer (LoginDAL)
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL IncidentSource;

        /// <summary>
        /// Constructor to mediate between the IncidentDAL and the view.
        /// </summary>
        public IncidentController()
        {
            this.IncidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Returns the incidents from the source 
        /// </summary>
        /// <returns> the indicents from the internal structore </returns>
        public List<Incident> GetIncidents()
        {
            return this.IncidentSource.GetIncidents();
        }

        /// <summary>
        /// Returns the incidents from the source that match the search ID
        /// </summary>
        /// <returns> the indicents from the internal structure </returns>
        public List<Incident> GetMatchingIncidents (int searchID)
        {
            return this.IncidentSource.GetMatchingIncidents(searchID);
        }

        /// <summary>
        /// Add an AnIncident to the internal structure 
        /// </summary>
        /// <param UserName="AnIncident"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident incident)
        {
            if (incident == null)
                throw new ArgumentNullException("Incident cannot be null.");

            this.IncidentSource.AddIncident(incident);
        }
    }
}
