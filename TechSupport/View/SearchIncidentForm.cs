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
using TechSupport.DAL;
using TechSupport.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechSupport.View
{
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController _incidentController;
        private readonly IncidentDAL _incidentDAL;
        private string UserName;


        public SearchIncidentForm(string Name)
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this._incidentDAL = new IncidentDAL();
            UserName = Name;
        }

        private void RefreshDataGrid(List<Incident> MatchingIncidents)
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = MatchingIncidents;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SearchIDText = this.CustomerIDTextBox.Text;

            try
            {
                if (string.IsNullOrEmpty(SearchIDText))
                    throw new ArgumentNullException("Customer ID cannot be empty", "Title");
                else
                {
                    int searchID = int.Parse(SearchIDText);
                    List<Incident> matchingIncidents = new List<Incident>();
                    matchingIncidents = this._incidentDAL.GetMatchingIncidents(searchID);
                    this.RefreshDataGrid(matchingIncidents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            using (Form MainForm = new MainForm(UserName))
            {
                this.Hide();
                MainForm.ShowDialog();
                this.Close();
            }
        }
    }
}
