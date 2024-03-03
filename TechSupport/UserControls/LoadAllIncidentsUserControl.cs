using DisplayDBIncidents.Controller;
using Incidents.Model;


/// <summary>
/// Class to diplay the data in the view
/// </summary>
namespace AllIncidents.UserControls
{
    public partial class LoadAllIncidentsUserControl : UserControl
    {
        private readonly IncidentDBController _incidentController;

        public LoadAllIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentDBController();
            this.RefreshData();
        }
        public void RefreshData()
        {
            List<Incident> incidentList;
            incidentList = new List<Incident>();
            this.DisplayAllListView.Items.Clear();

            try
            {
                incidentList = this._incidentController.GetAllIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        DisplayAllListView.Items.Add(incident.ProductCode.ToString());
                        DisplayAllListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        DisplayAllListView.Items[i].SubItems.Add(incident.DateClosed.ToString());
                        DisplayAllListView.Items[i].SubItems.Add(incident.CustomerName.ToString());
                        DisplayAllListView.Items[i].SubItems.Add(incident.TechName.ToString());
                        DisplayAllListView.Items[i].SubItems.Add(incident.Title.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no incidents, open or closed.", "No Incidents");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }

}
