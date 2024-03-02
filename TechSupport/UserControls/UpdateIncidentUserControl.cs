using AllIncidents.UserControls;
using DisplayDBIncidents.Controller;
using Incidents.Model;
using Technicians.Model;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {

        private readonly IncidentDBController _incidentController;
        private readonly TechnicianDBController _technicianController;
        private int incidentID;
        private int? techID;
        private string textToAdd;
        private string Name;
        Incident incident;
        List<Technician> technicianList;
        Technician technician;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentUserControl"/> class.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentDBController();
            _technicianController = new TechnicianDBController();
            technicianList = new List<Technician>();
            textToAdd = string.Empty;
            incident = new Incident();
            technician = new Technician();
            Name = "";
            techID = -1;
            this.TechnicianComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Handles the Click event of the GetIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void GetIncidentButton_Click(object sender, EventArgs e)
        {
            this.ErrorMessageLabel.ForeColor = Color.Black;
            this.ErrorMessageLabel.Text = "";

            try
            {
                if (!int.TryParse(this.IncidentIDTtextBox.Text, out incidentID))
                {
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
                    this.LoadIncident(incident);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void LoadIncident(Incident incident)
        {
            incident = this._incidentController.GetCustomerIncident(incidentID);

            this.TitleTextBox.Text = incident.Title;
            this.CustomerTextBox.Text = incident.CustomerName;
            this.ProductTextBox.Text = incident.ProductCode;
            this.DescriptionRichTextBox.Text = incident.Description;
            this.DateOpenedTtextBox.Text = incident.DateOpened.ToShortDateString();
            this.TechnicianComboBox.Text = incident.TechName;
            this.techID = incident.TechID;

            // No tech assigned - load all techs so customer can choose one.
            if (incident.TechName == "")
            {
                this.TechnicianComboBox.Enabled = true;
                this.loadTechnicians();
            }
        }

        private void loadTechnicians()
        {
            try
            {
                technicianList = this._technicianController.GetTechnicianNames();

                this.TechnicianComboBox.DataSource = technicianList;
                this.TechnicianComboBox.DisplayMember = "Name";
                this.TechnicianComboBox.ValueMember = "TechID";
            }
            catch
            {
            }
        }

        private void IncidentIDTtextBox_TextChanged(object sender, EventArgs e)
        {
            this.TitleTextBox.Clear();
            this.CustomerTextBox.Clear();
            this.ProductTextBox.Clear();
            this.DescriptionRichTextBox.Clear();
            this.DateOpenedTtextBox.Clear();
        }

        /// <summary>
        /// Handles the Click event of the UpdateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void UpdateButton_Click(object sender, EventArgs e)
        {
            this.textToAdd = this.TextToAddRichTextBox.Text;
          
            if (this.TechnicianComboBox.SelectedIndex > -1)
            {
                this.techID = Convert.ToInt32(this.TechnicianComboBox.SelectedValue);
            }
            

            if (this.ValidateUpdateInfo())
            {
                this.textToAdd = "\n" + this.TextToAddRichTextBox.Text;
                this._incidentController.UpdateIncident(incidentID, textToAdd, this.techID);
                this.TextToAddRichTextBox.Text = "";
                this.TechnicianComboBox.Enabled = false;
                this.LoadIncident(incident);
            }
        }

        private Boolean ValidateUpdateInfo()
        {
            if (this.textToAdd == "" || this.techID == -1)
            {
                if (textToAdd == "")
                {
                    this.TextToAddErrorLabel.ForeColor = Color.Red;
                    this.TextToAddErrorLabel.Text += "Enter information to be added to the incident description.";
                }
                if (this.techID == -1)
                {

                    this.TextToAddErrorLabel.ForeColor = Color.Red;
                    this.TextToAddErrorLabel.Text += "\nPlease choose a technician.";
                }
                return false;
            }

            return true;
        }

        private void TextToAddRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.TextToAddErrorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.TitleTextBox.Clear();
            this.CustomerTextBox.Clear();
            this.ProductTextBox.Clear();
            this.DescriptionRichTextBox.Clear();
            this.DateOpenedTtextBox.Clear();
            //  this.TechnicianComboBox.Items.Clear();
        }

        private void CloseIncidentButton_Click(object sender, EventArgs e)
        {

        }

    }
}
