using Customers.Model;
using DisplayDBIncidents.Controller;
using Incidents.Model;
using Products.Model;
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
        private ProductDBController _productDBController;

        private List<Customer> customerList;
        private List<string> productList;

        /// <summary>o the Incident Controller
        /// Constructor to build the form and initialize the controller
        /// </summary>
        public AddIncidentsUserControl()
        {
            InitializeComponent();

            this._incidentController = new IncidentDBController();
            this._customerController = new CustomerDBController(); 
            this._productDBController = new ProductDBController();

            this.customerList = new List<Customer>();
            this.productList = new List<string>();

            this.loadCustomerNames();
            this.loadProductNames();
        }

        /// <summary>
        /// Loads the customer names.
        /// </summary>
        public void loadCustomerNames()
        {
            this.customerList = this._customerController.GetCustomers();
            foreach (Customer customer in this.customerList)
            {
                CustomerNameComboBox.Items.Add(customer.Name);
            }
        }

        /// <summary>
        /// Loads the product names.
        /// </summary>
        public void loadProductNames()
        {
            this.productList = this._productDBController.GetProductNames();
            foreach (string productName in this.productList)
            {
               ProductComboBox.Items.Add(productName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           try
            {
                string title = this.TitleTextBox.Text;
                string description = this.DescriptionRichTextBox.Text;
                string prodName = this.ProductComboBox.GetItemText(this.ProductComboBox.SelectedItem);
                string cusName = this.CustomerNameComboBox.GetItemText(this.CustomerNameComboBox.SelectedItem);

                string productCode = this._productDBController.GetProductCode(prodName);
                int customerID = this._customerController.GetCustomerID(cusName);

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
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
                    this._incidentController.AddIncident(new Incident(title, description, productCode, customerID));
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
        }

        private void TitleTextBox_Click(object sender, EventArgs e)
        {
            this.TitleErrorLabel.Text = "";
            this.DescriptionErrorLabel.Text = "";
        }

        private void DescriptionRichTextBox_Click(object sender, EventArgs e)
        {
            this.TitleErrorLabel.Text = "";
            this.DescriptionErrorLabel.Text = "";
        }
    }
}
