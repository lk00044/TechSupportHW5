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
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController _incidentController;
        private IncidentController matchingIncidents;

        public SearchIncidentForm()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            this.matchingIncidents = new IncidentController();
        }

        private void RefreshDataGrid()
        {
            this.IncidentsDataGridView.DataSource = null;
            this.IncidentsDataGridView.DataSource = this.matchingIncidents.GetIncidents();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int searchID = int.Parse(this.CustomerIDTextBox.Text);
            List<Incident> allIncidents = this._incidentController.GetIncidents();            

            foreach(Incident inc in allIncidents)
            {
                if (inc.customerID == searchID)
                {
                    matchingIncidents.AddIncident(inc);
                }
            }
            this.RefreshDataGrid();
        }

 
    }
}
