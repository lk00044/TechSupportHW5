using DisplayIncidents.Controller;

namespace DisplayIncidents.View
{
    /// <summary>
    /// Class for the Main Form to add or search for an incident.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController _incidentController;
        private string UserName;

        /// <summary>
        /// The constructor for the main form
        /// </summary>
        /// <param UserName="Name"></param>
        public MainForm(string Name)
        {
            InitializeComponent();
            UserName = Name;
            this.DisplayUserNameLabel.Text = UserName;
            this._incidentController = new IncidentController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form loginForm = new LoginForm())
            {
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void RefreshDataGrid()
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = this._incidentController.GetIncidents();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form incidentForm = new IncidentForm())
            {
                DialogResult result = incidentForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshDataGrid();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancelled");
                }

            }
        }
        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form SearchForm = new SearchIncidentForm(UserName))
            {
                this.Hide();
                SearchForm.ShowDialog();
                this.Close();

            }
        }
    }
}
