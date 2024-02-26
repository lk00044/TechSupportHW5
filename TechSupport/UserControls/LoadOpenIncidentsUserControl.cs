using Customers.Model;
using DisplayDBIncidents.Controller;
using Incidents.Model;
using System;
using Technicians.Model;
using TechSupport.Controller;

/// <summary>
/// Load Incidents User Control
/// Uses Incidents in the DB
/// Gets Incidents from the Incidents model and displays them
/// Leslie Keller
/// </summary>
/// 
namespace Incidents.UserControls
{
    public partial class LoadOpenIncidentsUserControl : UserControl
    {
        private IncidentDBController _incidentController;

        public LoadOpenIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentDBController();
            this.RefreshData();
        }

        private void DisplayOpenIncidentsTabPage_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        public void RefreshData()
        {
            List<Incident> incidentList;
            Customer customer;
            Technician tech;

            try
            {
                incidentList = this._incidentController.GetOpenIncidents();
                customer = new Customer();
                tech = new Technician();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        OpenIncidentsListView.Items.Add(incident.IncidentID.ToString());
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.ProductCode.ToString());
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        OpenIncidentsListView.Items[i].SubItems.Add(customer.GetCustomerName(incident.CustomerID));
                        OpenIncidentsListView.Items[i].SubItems.Add(tech.GetTechName(incident.TechID));
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.Title.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("All incidents are closed.", "No Open Incidents");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }

        private void OpenIncidentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshData();
        }
    }

}
