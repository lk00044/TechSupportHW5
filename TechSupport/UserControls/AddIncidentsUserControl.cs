using Incidents.Controller;
using Incidents.Model;

/// <summary>
/// Add Incidents User Control
/// Adds an Incident t
/// Leslie Keller
/// </summary>
/// 

namespace Incidents.UserControls
{
    public partial class AddIncidentsUserControl : UserControl
    {
       private IncidentController _incidentController;

        /// <summary>o the Incident Controller
        /// Constructor to build the form and initialize the controller
        /// </summary>
        public AddIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
           try
            {
                var title = this.TitleTextBox.Text;
                var description = this.DescriptionRichTextBox.Text;
                var customerID = this.CustomerIDTextBox.Text;

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
                        this.CustomerIDErrorLabel.Text = "Customer ID must be a positive integer.";
                    }

                    if (string.IsNullOrEmpty(customerID))
                    {
                        this.CustomerIDErrorLabel.ForeColor = Color.Red;
                        this.CustomerIDErrorLabel.Text = "Invalid customer ID";
                    }                   

                }
                else
                {
                    int intCustomerID = int.Parse(this.CustomerIDTextBox.Text);                   
                    this._incidentController.AddIncident(new Incident());
                }
                this.TitleTextBox.Clear();
                this.DescriptionRichTextBox.Clear();
                this.CustomerIDTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("One of the inputs is missing or incorrect. \n" +
                    ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.TitleTextBox.Clear();
            this.DescriptionRichTextBox.Clear();
            this.CustomerIDTextBox.Clear();
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
