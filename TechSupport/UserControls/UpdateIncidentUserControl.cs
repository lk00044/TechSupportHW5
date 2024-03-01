using DisplayDBIncidents.Controller;
using Incidents.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {

        private readonly IncidentDBController _incidentController;
        private int incidentID;

        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentDBController();
        }

        /// <summary>
        /// Handles the Click event of the GetIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void GetIncidentButton_Click(object sender, EventArgs e)
        {
            Incident incident;

            this.ErrorMessageLabel.ForeColor = Color.Black;
            this.ErrorMessageLabel.Text = "";            

            try
            {
                if (!int.TryParse(this.IncidentIDTtextBox.Text, out incidentID)) {
                    this.ErrorMessageLabel.ForeColor = Color.Red;
                    this.ErrorMessageLabel.Text = "Incident ID must be numeric only.";
                    this.IncidentIDTtextBox.Clear();
                }

                incident = this._incidentController.GetCustomerIncident(incidentID);

                if (incident == null)
                {
                    MessageBox.Show("No Incident with that ID. Please re-enter Incident ID.");
                    this.IncidentIDTtextBox.Clear();
                }
                else
                {
                    this.TitleTextBox.Text = incident.Title;
                    this.CustomerTextBox.Text = incident.CustomerName;
                    this.ProductTextBox.Text = incident.ProductCode;
                  // HERE  this.TechnicianComboBox.
                }

                

            }      
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }
    }
}
