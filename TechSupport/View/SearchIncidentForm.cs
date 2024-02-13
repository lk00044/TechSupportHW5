using Incidents.Controller;
using Incidents.DAL;
using Incidents.Model;

namespace Incidents.View
{ 
    /// <summary>
    /// Search Incident Form to look for matching incidents
    /// based on Customer ID
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController _incidentController;
        private readonly IncidentDBDAL _incidentDAL;
        private string UserName;


        public SearchIncidentForm(string Name)
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this._incidentDAL = new IncidentDBDAL();
            UserName = Name;
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
