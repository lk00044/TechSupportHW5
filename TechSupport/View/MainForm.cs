using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechSupport.View
{
    /// <summary>
    /// Class for the Main Form to add or search for an incident.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// The constructor for the main form
        /// </summary>
        /// <param name="userName"></param>
        public MainForm(string userName)
        {
            InitializeComponent();
            this.DisplayUserNameLabel.Text = userName;
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
            using (Form searchForm = new SearchIncidentForm())
            {
                this.Hide();
                searchForm.ShowDialog();
                this.Close();

            }
        }
    }
}
