using Customers.Model;
using DisplayDBIncidents.Controller;
using Incidents.Controller;
using Incidents.Model;
using Technicians.Model;
using TechSupport.Controller;

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
        private IncidentDBController _incidentController;
        private CustomerDBController _customerController;
        private TechnicianDBController _technicianDBController;

        private List<Customer> customerList;
        private List<Technician> technicianList;
        private List<Incident> incidentList;

        /// <summary>o the Incident Controller
        /// Constructor to build the form and initialize the controller
        /// </summary>
        public AddIncidentsUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentDBController();
            this._customerController = new CustomerDBController();  
            this._technicianDBController = new TechnicianDBController(); 
            this.customerList = new List<Customer>();
            this.technicianList = new List<Technician>();
            this.incidentList = new List<Incident>();
        }

        public void loadCustomerNames()
        {
            this.customerList = this._customerController.GetCustomers();
            this.incidentList = this._incidentController.GetIncidents();
            this.technicianList = this._technicianDBController.GetTechnicians();
        }

        public void loadProducts()
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
           try
            {
                var title = this.TitleTextBox.Text;
                var description = this.DescriptionRichTextBox.Text;

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

                                   

                }
                else
                {                                     
                    this._incidentController.AddIncident(new Incident(title, description, intCustomerID));
                }
                this.TitleTextBox.Clear();
                this.DescriptionRichTextBox.Clear();
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
