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

namespace TechSupport.View
{
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController _incidentController;
        private readonly IncidentDAL _incidentDAL;
        

        public SearchIncidentForm()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this._incidentDAL = new IncidentDAL();
        }

        private void RefreshDataGrid(List<Incident> matchingIncidents)
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = matchingIncidents;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchIDText = this.CustomerIDTextBox.Text;

            try
            {
                if (string.IsNullOrEmpty(searchIDText))
                    throw new ArgumentNullException("Customer ID cannot be empty", "Title");
                else
                {
                    int searchID = int.Parse(searchIDText);
                    List<Incident> matchingIncidents = new List<Incident>();
                    matchingIncidents = this._incidentDAL.GetMatchingIncidents(searchID);
                    this.RefreshDataGrid(matchingIncidents);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

 
    }
}
