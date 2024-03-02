
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

        /// <summary>
        /// Gets the ATechnician.
        /// </summary>
        /// <returns></returns>
        public Technician GetTechnician(int techID)
        {
            return this.TechnicianSource.GetTechnician(techID);
        }

        /// <summary>
        /// Gets the ATechnician names.
        /// </summary>
        /// <returns></returns>
        public List<Technician> GetTechnicianNames()
        {
            return this.TechnicianSource.GetTechnicianNames();
        }
    }
}
