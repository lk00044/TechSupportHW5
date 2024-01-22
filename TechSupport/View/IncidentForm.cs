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
    public partial class IncidentForm : Form
    {

        private readonly IncidentController _incidentController;

        public IncidentForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = this.TitleTextBox.Text;
                var description = this.DescriptionLlabel.Text;
                var customerID = int.Parse(this.CustomerIDTextBox.Text);

                this._incidentController.AddIncident(new Incident(title, description, customerID));

                this.DialogResult = DialogResult.OK;

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
    }
}
