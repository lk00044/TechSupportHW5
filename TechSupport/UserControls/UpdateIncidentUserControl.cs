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
        private string techName;
        private string textToAdd;
        List<Technician> technicianList;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentUserControl"/> class.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentDBController();
            _technicianController = new TechnicianDBController();
            technicianList = new List<Technician>();
            techName = string.Empty;
            textToAdd = string.Empty;
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
                    this.TitleTextBox.Text = incident.Title;
                    this.CustomerTextBox.Text = incident.CustomerName;
                    this.ProductTextBox.Text = incident.ProductCode;
                    this.DescriptionRichTextBox.Text = incident.Description;
                    this.DateOpenedTtextBox.Text = incident.DateOpened.ToShortDateString();
                    this.TechnicianComboBox.Text = incident.TechName;

                    // No tech assigned - load all techs so customer can choose one.
                    if (TechnicianComboBox.Text == "")
                    {
                        this.TechnicianComboBox.Enabled = true;
                        technicianList = this._technicianController.GetTechnicianNames();
                        foreach (Technician technician in technicianList)
                        {
                            this.TechnicianComboBox.Items.Add(technician.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void IncidentIDTtextBox_TextChanged(object sender, EventArgs e)
        {
            this.TitleTextBox.Clear();
            this.CustomerTextBox.Clear();
            this.ProductTextBox.Clear();
            this.DescriptionRichTextBox.Clear();
            this.DateOpenedTtextBox.Clear();
            this.TechnicianComboBox.Items.Clear();
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
                techName = TechnicianComboBox.SelectedValue.ToString();
            }
            if (this.ValidateUpdateInfo())
            {

            }


        }

        private Boolean ValidateUpdateInfo()
        {

            if (this.textToAdd == "")
            {
                this.TextToAddErrorLabel.ForeColor = Color.Red;
                this.TextToAddErrorLabel.Text = "Enter information to be added to the incident description.";
                return false;
            }

            if (string.IsNullOrEmpty(TechnicianComboBox.Text))
            {
                if (MessageBox.Show("A technician was not selected. Did you mean to select one?", "Technician", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    return false;
                }
            }

            return true;
        }

        private void TextToAddRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.TextToAddErrorLabel.Text = "";
        }
    }
}
