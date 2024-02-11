using Incidents.Controller;


/// <summary>
/// Class to diplay the data in the view
/// </summary>
namespace IncidentsLocal.UserControls
{
    public partial class LoadIncidentsUserControl : UserControl
    {
        private readonly IncidentController _incidentController;

        public LoadIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this.RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = this._incidentController.GetIncidents();
        }

        private void LoadIncidentsTabPage_Click(object sender, EventArgs e)
        {
            this.RefreshDataGrid(); 
        }
    }
}
