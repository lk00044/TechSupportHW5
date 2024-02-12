
using Incidents.Controller;

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
        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form loginForm = new LoginForm())
            {
                this.Hide();
                loginForm.ShowDialog();
               // this.Close();
            }
        }

        private void TabDashboardMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
