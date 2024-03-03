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
            this.CurrentTechLabel.Text = "";
            this.ResultErrorLabel.Text = "";

            try
            {
                if (!int.TryParse(this.IncidentIDTtextBox.Text, out AnIncidentID))
                {
                    this.ErrorMessageLabel.ForeColor = Color.Red;
                    this.ErrorMessageLabel.Text = "Incident ID must be numeric only.";
                    this.IncidentIDTtextBox.Clear();
                }

                this.AnIncident = this._incidentController.GetCustomerIncident(AnIncidentID);

                if (this.AnIncident == null)
                {
                    this.ErrorMessageLabel.ForeColor = Color.Red;
                    this.ErrorMessageLabel.Text = "No Incident with that ID. Please re-enter Incident ID.";
                    this.IncidentIDTtextBox.Clear();
                }
                else
                {
                    this.LoadIncident(this.AnIncident);
                    this.TextToAddRichTextBox.Enabled = true;
                    this.CloseIncidentButton.Enabled = true;
                    this.UpdateButton.Enabled = true;
                    this.DescriptionLabel.Enabled = true;
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
            this.ATechID = incident.TechID;
            this.TechnicianComboBox.Enabled = true;

            if (!string.IsNullOrEmpty(incident.TechName.ToString())) 
            {
                this.CurrentTechLabel.Text = "Current Technician: " + incident.TechName;
            }
            this.LoadTechnicians();
        }

        private void LoadTechnicians()
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
            this.ClearContents();
        }

        private void ClearContents()
        {
            this.TitleTextBox.Clear();
            this.CustomerTextBox.Clear();
            this.ProductTextBox.Clear();
            this.DescriptionRichTextBox.Clear();
            this.DateOpenedTtextBox.Clear();
            this.CurrentTechLabel.Text = "";
            this.ResultErrorLabel.Text = "";
            this.TextToAddRichTextBox.Clear();
        }

        /// <summary>
        /// Handles the Click event of the UpdateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void UpdateButton_Click(object sender, EventArgs e)
        {
            this.UpdateIncident();
        }

        private void UpdateIncident()
        {
            this.TextToAdd = this.TextToAddRichTextBox.Text;
            this.ATechID = AnIncident.TechID;

            if (this.AnIncident.Description.Length >= 200)
            {
                this.ResultErrorLabel.ForeColor = Color.Red;
                this.ResultErrorLabel.Text = "The description is already 200 characters and cannot be updated.";
                this.TextToAdd = "";
            }

            if (this.TechnicianComboBox.SelectedIndex > -1)
            {
                this.ATechID = Convert.ToInt32(this.TechnicianComboBox.SelectedValue);
            }
            

            if (this.TextToAdd != "")
            {
                this.TextToAdd = "\n<" + DateTime.Now.ToShortDateString() + "> " + this.TextToAddRichTextBox.Text;
                int totalLength = this.AnIncident.Description.Length + this.TextToAdd.Length;
                if (totalLength > 200)
                {
                   if( MessageBox.Show("The description will be truncated to the first 200 characters. \n" +
                        "Do you want to update your text to 200 or less? ", "Description Warning", MessageBoxButtons.YesNo)
                        == DialogResult.No)
                    {
                        int addLength = totalLength - this.AnIncident.Description.Length;
                        this.TextToAdd = this.TextToAdd[0..addLength];
                        
                    }

                }
            }

            if (this.TextToAdd != "" || this.TechnicianComboBox.SelectedIndex > -1)
            {

                this._incidentController.UpdateIncident(AnIncidentID, TextToAdd, this.ATechID);
                this.TextToAddRichTextBox.Text = "";
                this.LoadIncident(AnIncident);
                this.ResultErrorLabel.ForeColor = Color.Blue;
                this.ResultErrorLabel.Text = "Updates have been made.";               
            }
            else
            {
                this.ResultErrorLabel.Text += "\nThere are no changes to be made.";
                this.TextToAddRichTextBox.Clear();
            }
        }


        private void TextToAddRichTextBox_Click(object sender, EventArgs e)
        {
            this.ResultErrorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearContents();
        }

        private void CloseIncidentButton_Click(object sender, EventArgs e)
        {
            if (AnIncident.TechName == "")
            {
                this.ResultErrorLabel.ForeColor = Color.Red;
                this.ResultErrorLabel.Text = "You must first choose a Technician.";
            } 
            else
            {
                this.TextToAdd = this.TextToAddRichTextBox.Text;
                
                if (!string.IsNullOrEmpty(this.TextToAdd) || this.TechnicianComboBox.SelectedIndex > -1){
                    this.UpdateIncident();
                }                        

                this._incidentController.CloseIncident(AnIncidentID);
                this.LoadIncident(AnIncident);
                this.ResultErrorLabel.ForeColor = Color.Blue;
                this.ResultErrorLabel.Text = "Incident closed.";
            }
        }

    }
}
