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
        private List<Product> productList;

        private Product product;
        private Customer customer;

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
            this.productList = new List<Product>();

            this.customer = new Customer();
            this.product = new Product();

            this.LoadCustomersAndProducts();
        }


        private void LoadCustomersAndProducts()
        {
            try
            {

                this.customerList = this._customerController.GetCustomerNames();
                this.CustomerNameComboBox.DataSource = this.customerList;
                this.CustomerNameComboBox.DisplayMember = "Name";
                this.CustomerNameComboBox.ValueMember = "CustomerID";

                this.productList = this._productDBController.GetProductNames();
                this.ProductComboBox.DataSource = this.productList;
                this.ProductComboBox.DisplayMember = "ProductName";
                this.ProductComboBox.ValueMember= "ProductCode";

            }
            catch
            {
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
           try
            {
                string title = this.TitleTextBox.Text;
                string description = this.DescriptionRichTextBox.Text;
               
                string productCode = this.ProductComboBox.SelectedValue.ToString();
                int customerID = Convert.ToInt32(this.CustomerNameComboBox.SelectedValue);

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
