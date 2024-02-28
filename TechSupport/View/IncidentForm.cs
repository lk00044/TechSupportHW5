using DisplayDBIncidents.Controller;
using Incidents.Model;

/// <summary>
/// Class to display the Incident Form
/// 
/// </summary>
namespace Incidents.View

{
    public partial class IncidentForm : Form
    {

        private readonly IncidentDBController _incidentController;

        /// <summary>
        /// Constructor to build the form and initialize the controller
        /// </summary>
        public IncidentForm()
        {
            InitializeComponent();
            _incidentController = new IncidentDBController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = this.TitleTextBox.Text;
                var description = this.DescriptionRichTextBox.Text;
                var customerID = this.CustomerIDTextBox.Text;
                string prodCode = "";

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(customerID) || (int.TryParse(customerID, out _) == false))
                {

                    if (string.IsNullOrEmpty(title))
                    {
                        this.TitleErrorLabel.ForeColor = Color.Red;
                        this.TitleErrorLabel.Text = "Invalid Title";
                    }

                    if (string.IsNullOrEmpty(description))
                    {
                        this.DescriptionErrorLabel.ForeColor = Color.Red;
                        this.DescriptionErrorLabel.Text = "Invalid Description";
                    }

                    if (int.TryParse(customerID, out _) == false)
                    {
                        this.CustomerIDErrorLabel.ForeColor = Color.Red;
                        this.CustomerIDErrorLabel.Text = "Customer ID must be numeric.";
                    }

                    if (string.IsNullOrEmpty(customerID))
                    {
                        this.CustomerIDErrorLabel.ForeColor = Color.Red;
                        this.CustomerIDErrorLabel.Text = "Invalid customer ID";
                    }

                    this.TitleTextBox.Clear();
                    this.DescriptionRichTextBox.Clear();
                    this.CustomerIDTextBox.Clear();

                }
                else
                {
                    int intCustomerID = int.Parse(this.CustomerIDTextBox.Text);
                    this._incidentController.AddIncident(new Incident(title, description, prodCode, intCustomerID));
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("One of the inputs is missing or incorrect. \n" +
                    ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TitleTextBox_Click(object sender, EventArgs e)
        {
            this.TitleErrorLabel.Text = "";
            this.CustomerIDErrorLabel.Text = "";
            this.DescriptionErrorLabel.Text = "";
        }

        private void DescriptionRichTextBox_Click(object sender, EventArgs e)
        {
            this.TitleErrorLabel.Text = "";
            this.CustomerIDErrorLabel.Text = "";
            this.DescriptionErrorLabel.Text = "";
        }

        private void CustomerIDTextBox_Click(object sender, EventArgs e)
        {
            this.TitleErrorLabel.Text = "";
            this.CustomerIDErrorLabel.Text = "";
            this.DescriptionErrorLabel.Text = "";
        }

    }
}
