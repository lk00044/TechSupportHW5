
using DisplayIncidents.Controller;

/// <summary>
/// Main Dashboard
/// Leslie Keller
/// </summary>

namespace DisplayIncidents.View
{
    public partial class DashboardTabMainForm : Form
    {

        public DashboardTabMainForm()
        {
            InitializeComponent();
        }

        private void TabDashboardMainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form loginForm = new LoginForm())
            {
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
