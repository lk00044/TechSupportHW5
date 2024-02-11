using DisplayIncidents.View;

namespace DisplayIncidents

{/// <summary>
/// Class for the LoginForm for the user to log in
/// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Constructor for form  for user to use to login
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = "";

            try
            {
                userName = this.UserNameTextBox.Text;
                var password = this.PasswordTextBox.Text;

                if (userName == "jane" && password == "test1234")
                {
                    using (Form dashboardTabForm = new DashboardTabMainForm(userName))
                    {
                        this.Hide();
                        dashboardTabForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    this.ErrorMessageLabel.ForeColor = Color.Red;
                    this.ErrorMessageLabel.Text = "Invalid username/password";
                    this.UserNameTextBox.Clear();
                    this.PasswordTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserNameTextBox_Click(object sender, EventArgs e)
        {
            this.ErrorMessageLabel.Text = "";
        }


    }
}
