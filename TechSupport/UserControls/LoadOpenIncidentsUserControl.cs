using DisplayDBIncidents.Controller;
using Incidents.Model;

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
        private readonly IncidentDBController _incidentController;

        public LoadOpenIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentDBController();
            this.RefreshData();
        }

        private void DisplayOpenIncidentsTabPage_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            List <Incident> incidentList;

            try
            {
                incidentList = this._incidentController.GetIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];

                        Console.Write("Date Closed: " + incident.DateClosed);

                        if (incident.DateClosed == null || incident.DateClosed == DateTime.MinValue) { 
                            OpenIncidentsListView.Items[i].SubItems.Add(incident.ProductCode.ToString());
                            OpenIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                            OpenIncidentsListView.Items[i].SubItems.Add(incident.CustomerID.ToString());
                            OpenIncidentsListView.Items[i].SubItems.Add(incident.TechID.ToString());
                            OpenIncidentsListView.Items[i].SubItems.Add(incident.Title.ToString());
                        }
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
    }

}
