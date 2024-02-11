using DisplayIncidents.Controller;


/// <summary>
/// Class to diplay the data in the view
/// </summary>
namespace TechSupport.UserControls
{
    public partial class LoadIncidentsUserControl : UserControl
    {
        private readonly IncidentController _incidentController;

        public LoadIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }
        private void RefreshDataGrid()
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = this._incidentController.GetIncidents();
        }

        private void IncidentsTabControl_Click(object sender, EventArgs e)
        {
            this.RefreshDataGrid(); 
        }
    }
}
