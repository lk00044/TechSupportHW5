using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
