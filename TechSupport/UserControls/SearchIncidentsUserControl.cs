using Incidents.Controller;
using Incidents.Model;


/// <summary>
/// User Control class used to search incidents for matching incidents
/// based on the search customer id
/// </summary>
namespace TechSupport.UserControls
{
    public partial class SearchIncidentsUserControl : UserControl
    {

        private readonly IncidentController _incidentController;

        public SearchIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }


        private void RefreshDataGrid(List<Incident> MatchingIncidents)
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = MatchingIncidents;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SearchIDText = this.CustomerIDTextBox.Text;

            try
            {
                if (string.IsNullOrEmpty(SearchIDText))
                    throw new ArgumentNullException("Customer ID cannot be empty", "Title");
                else
                {
                    int searchID = int.Parse(SearchIDText);
                    List<Incident> matchingIncidents = new List<Incident>();
                    matchingIncidents = this._incidentController.GetMatchingIncidents(searchID);
                    this.RefreshDataGrid(matchingIncidents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
