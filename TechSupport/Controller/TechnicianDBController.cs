﻿
using Technicians.DAL;
using Technicians.Model;

namespace TechSupport.Controller
{
    public class TechnicianDBController
    {
        private TechniciansDBDAL TechnicianSource;
        public TechnicianDBController()
        {
            this.TechnicianSource = new TechniciansDBDAL(); 
        }

        /// <summary>
        /// Returns the technicians from the source 
        /// </summary>
        /// <returns> the indicents from the internal structore </returns>
        public List<Technician> GetTechnicians()
        {
            return this.TechnicianSource.GetTechnicians();
        }
    }
}