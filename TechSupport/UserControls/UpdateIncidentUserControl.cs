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
        private int AnIncidentID;
        private int? ATechID;
        private string TextToAdd;
        Incident AnIncident;
        List<Technician> TechnicianList;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentUserControl"/> class.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentDBController();
            _technicianController = new TechnicianDBController();
            TechnicianList = new List<Technician>();
            TextToAdd = string.Empty;
            AnIncident = new Incident(); 
            Name = "";
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
                if (!int.TryParse(this.IncidentIDTtextBox.Text, out AnIncidentID))
                {
                    this.ErrorMessageLabel.ForeColor = Color.Red;
                    this.ErrorMessageLabel.Text = "Incident ID must be numeric only.";
                    this.IncidentIDTtextBox.Clear();
                }

                AnIncident = this._incidentController.GetCustomerIncident(AnIncidentID);

                if (AnIncident == null)
                {
                    this.ErrorMessageLabel.ForeColor = Color.Red;
                    this.ErrorMessageLabel.Text = "No Incident with that ID. Please re-enter Incident ID.";
                    this.IncidentIDTtextBox.Clear();
                }
                else
                {
                    this.LoadIncident(AnIncident);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void LoadIncident(Incident incident)
        {
            incident = this._incidentController.GetCustomerIncident(AnIncidentID);

            this.TitleTextBox.Text = incident.Title;
            this.CustomerTextBox.Text = incident.CustomerName;
            this.ProductTextBox.Text = incident.ProductCode;
            this.DescriptionRichTextBox.Text = incident.Description;
            this.DateOpenedTtextBox.Text = incident.DateOpened.ToShortDateString();
            this.TechnicianComboBox.Text = incident.TechName;
            this.ATechID = incident.TechID;
            this.TechnicianComboBox.Enabled = true;
            this.loadTechnicians();
        }

        private void loadTechnicians()
        {
            try
            {
                TechnicianList = this._technicianController.GetTechnicianNames();

                this.TechnicianComboBox.DataSource = TechnicianList;
                this.TechnicianComboBox.DisplayMember = "Name";
                this.TechnicianComboBox.ValueMember = "TechID";

                this.TechnicianComboBox.SelectedIndex = -1;

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
            this.TextToAdd = this.TextToAddRichTextBox.Text;
            this.ATechID = AnIncident.TechID;

            if (this.TechnicianComboBox.SelectedIndex > -1)
            {
                this.ATechID = Convert.ToInt32(this.TechnicianComboBox.SelectedValue);
            }
            //else
            //{
            //    this.ATechID = AnIncident.TechID;
            //}


            if (this.TextToAdd != "" || this.TechnicianComboBox.SelectedIndex > -1)
            {
                this.TextToAdd = "\n" + this.TextToAddRichTextBox.Text;
                this._incidentController.UpdateIncident(AnIncidentID, TextToAdd, this.ATechID);
                this.TextToAddRichTextBox.Text = "";               
                this.LoadIncident(AnIncident);
                this.TextToAddErrorLabel.ForeColor = Color.Blue;
                this.TextToAddErrorLabel.Text = "Updates have been made.";
            }
            else
            {
                this.TextToAddErrorLabel.ForeColor = Color.Red;
                this.TextToAddErrorLabel.Text = "There are no changes to be made.";
            }
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
        }

        private void CloseIncidentButton_Click(object sender, EventArgs e)
        {
            if (AnIncident.TechName == "")
            {
                this.TextToAddErrorLabel.ForeColor = Color.Red;
                this.TextToAddErrorLabel.Text = "You must first choose a ATechnician.";
            } 
            else
            {
                this._incidentController.CloseIncident(AnIncidentID);
                this.LoadIncident(AnIncident);
                this.TextToAddErrorLabel.ForeColor = Color.Blue;
                this.TextToAddErrorLabel.Text = "Incident closed.";
            }
        }

    }
}
