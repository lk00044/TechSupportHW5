using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        public MainForm(string userName)
        {
            InitializeComponent();
            this.DisplayUserNameLabel.Text = userName;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (Form loginForm = new LoginForm())
            {     
                this.Hide();
                loginForm.ShowDialog();
                   
            }

            
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
