
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
        }

        private void TabDashboardMainForm_Load(object sender, EventArgs e)
        {
            DisplayNameLabel.Text = UserName;
            TabPage selectedTab = IncidentsTabControl.SelectedTab;
            LoadOpenIncidentsUserControl control = new LoadOpenIncidentsUserControl();

            if (selectedTab == DisplayOpenIncidentsTabPage)
            {
                control.RefreshData();
            }

        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TabDashboardMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DisplayOpenIncidentsTabPage_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = IncidentsTabControl.SelectedTab;
            LoadOpenIncidentsUserControl control = new LoadOpenIncidentsUserControl();

            if (selectedTab == DisplayOpenIncidentsTabPage)
            {
                control.RefreshData();
            }
        }

        private void loadOpenIncidentsUserControl2_Load(object sender, EventArgs e)
        {
            TabPage selectedTab = IncidentsTabControl.SelectedTab;
            LoadOpenIncidentsUserControl control = new LoadOpenIncidentsUserControl();

            if (selectedTab == DisplayOpenIncidentsTabPage)
            {
                control.RefreshData();
            }
        }

        private void OpenIncidentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = IncidentsTabControl.SelectedTab;
            LoadOpenIncidentsUserControl control = new LoadOpenIncidentsUserControl();

            if (selectedTab == DisplayOpenIncidentsTabPage)
            {
                control.RefreshData();
            }
        }

    }
}
