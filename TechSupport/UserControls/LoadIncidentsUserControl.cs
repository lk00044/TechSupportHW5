using TechSupport.Controller;

/// <summary>
/// Load Incidents User Control
/// Gets Incidents from the Incidents model and displays them
/// Leslie Keller
/// </summary>
/// 
namespace TechSupport.UserControls
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
            this.OpenIncidentsListView.Items.Clear();
          //  this.OpenIncidentsListView.Items.Add(this._incidentController.GetIncidents());
           
           // this.IncidentsDataGridView.DataSource = this._incidentController.GetIncidents();
        }
    }
}
