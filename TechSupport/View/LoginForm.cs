using TechSupport.View;

namespace TechSupport

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
            try
            {
                var userName = this.UserNameTextBox.Text;
                var password = this.PasswordTextBox.Text;

                if(userName == "jane" && password == "test1234")
                {
                    using (Form mainForm = new MainForm(userName))
                    {
                        mainForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UserName or Password is incorrect.\n");
            }

        }
    }
}
