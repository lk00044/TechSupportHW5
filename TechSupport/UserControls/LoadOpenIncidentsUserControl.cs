using Customers.Model;
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

            this.OpenIncidentsListView.Columns[0].Width = 10;
            this.OpenIncidentsListView.Columns[1].Width = 15;
            this.OpenIncidentsListView.Columns[2].Width = 30;
            this.OpenIncidentsListView.Columns[3].Width = 30;
            this.OpenIncidentsListView.Columns[4].Width = 50;

            this.OpenIncidentsListView.Items.Clear();

            try
            {
                incidentList = this._incidentController.GetOpenIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        OpenIncidentsListView.Items.Add(incident.ProductCode.ToString());
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.CustomerName.ToString());
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.TechName.ToString());
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
    }

}
