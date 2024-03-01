
using Incidents.Controller;
using Incidents.UserControls;

/// <summary>
/// Main Dashboard
/// Leslie Keller
/// </summary>

namespace Incidents.View
{
    public partial class DashboardTabMainForm : Form
    {
        private string UserName = "";
        public DashboardTabMainForm(string Name)
        {
            InitializeComponent();
            UserName = Name;
            DisplayNameLabel.Text = UserName;
            this.loadOpenIncidentsUserControl.RefreshData();
            this.loadAllIncidentsUserControl.RefreshData();
        }

        private void TabDashboardMainForm_Load(object sender, EventArgs e)
        {            
             
        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TabDashboardMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void IncidentsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadOpenIncidentsUserControl.RefreshData();
            this.loadAllIncidentsUserControl.RefreshData();
        }

        private void DashboardTabMainForm_Load(object sender, EventArgs e)
        {
            this.loadOpenIncidentsUserControl.RefreshData();
            this.loadAllIncidentsUserControl.RefreshData();
        }

    }
}
