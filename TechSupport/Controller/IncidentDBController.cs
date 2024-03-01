﻿using Incidents.DAL;
using Incidents.Model;

// Leslie Keller

namespace DisplayDBIncidents.Controller
{
    /// <summary>
    /// Handles the interaction between the view and the Incident Data Access Layer 
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
        /// Gets all incidents.
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetAllIncidents()
        {
            return this.IncidentSource.GetAllIncidents();

        }


        /// <summary>
        /// Gets the open incidents.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <param name="addToText">The add to text.</param>
        public void UpdateIncident(int customerID, string addToText)
        {
            this.IncidentSource.UpdateIncident(customerID, addToText);
        }


        /// <summary>
        /// Gets the customer incident.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <returns> the incident </returns>
        public Incident GetCustomerIncident(int customerID)
        {
            return this.IncidentSource.GetCustomerIncident(customerID);    
        }


     }
}
