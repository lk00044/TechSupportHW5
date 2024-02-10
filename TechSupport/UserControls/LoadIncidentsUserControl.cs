using DisplayIncidents.Controller;
using DisplayIncidents.Model;

/// <summary>
/// Load Incidents User Control
/// Gets Incidents from the Incidents model and displays them
/// Leslie Keller
/// </summary>
/// 
namespace DisplayIncidents.UserControls
{
    public partial class LoadIncidentsUserControl : UserControl
    {
        private readonly IncidentController _incidentController;

        public LoadIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this.RefreshData();
        }

        private void RefreshData()
        {
            List <Incident> incidentList;

            try
            {
                //instead of using the following line of code, which couples the 
                //DAL with the view, we ask the controller to get the data for us 
                //so that the view does not have to know where the data comes from
                //(the line after the commented line)

                //invoiceList = InvoiceDB.GetInvoicesDue();
                incidentList = this._incidentController.GetIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        if (incident.DateClosed == null) { 
                            //  OpenIncidentsListView.Items.Add(incident.IncidentID);
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
                    MessageBox.Show("All incidents are closed.",
                        "No Open Incidents");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
        }
    }

}
