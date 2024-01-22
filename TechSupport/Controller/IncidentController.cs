﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

// Leslie Keller

namespace TechSupport.Controller
{
    /// <summary>
    /// Handles the interaction between the view and the Login Data Access Layer (LoginDAL)
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL incidentSource;

        /// <summary>
        /// Constructor to mediate between the IncidentDAL and the view.
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Returns the incidents from the source 
        /// </summary>
        /// <returns> the indicents from the internal structore </returns>
        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
        }

        /// <summary>
        /// Add an incident to the internal structure 
        /// </summary>
        /// <param name="incident"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident incident)
        {
            if (incident == null)
                throw new ArgumentNullException("Incident cannot be null.");

            this.incidentSource.AddIncident(incident);
        }
    }
}