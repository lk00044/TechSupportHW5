namespace Incidents.View
{
    partial class DashboardTabMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogOutLinkLabel = new LinkLabel();
            DisplayNameLabel = new Label();
            DisplayOpenIncidentsTabPage = new TabPage();
            loadOpenIncidentsUserControl = new UserControls.LoadOpenIncidentsUserControl();
            IncidentsTabControl = new TabControl();
            DisplayAllIncidentsTabPage = new TabPage();
            loadAllIncidentsUserControl = new AllIncidents.UserControls.LoadAllIncidentsUserControl();
            AddIncidentTabPage = new TabPage();
            addIncidentsUserControl1 = new UserControls.AddIncidentsUserControl();
            UpdateIncidentTabPage = new TabPage();
            updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            DisplayOpenIncidentsTabPage.SuspendLayout();
            IncidentsTabControl.SuspendLayout();
            DisplayAllIncidentsTabPage.SuspendLayout();
            AddIncidentTabPage.SuspendLayout();
            UpdateIncidentTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.Location = new Point(876, 42);
            LogOutLinkLabel.Name = "LogOutLinkLabel";
            LogOutLinkLabel.Size = new Size(76, 33);
            LogOutLinkLabel.TabIndex = 1;
            LogOutLinkLabel.TabStop = true;
            LogOutLinkLabel.Text = "Log Out";
            LogOutLinkLabel.TextAlign = ContentAlignment.TopRight;
            LogOutLinkLabel.LinkClicked += LogOutLinkLabel_LinkClicked;
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(806, 9);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(146, 26);
            DisplayNameLabel.TabIndex = 2;
            DisplayNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DisplayOpenIncidentsTabPage
            // 
            DisplayOpenIncidentsTabPage.Controls.Add(loadOpenIncidentsUserControl);
            DisplayOpenIncidentsTabPage.Location = new Point(4, 29);
            DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            DisplayOpenIncidentsTabPage.Padding = new Padding(3);
            DisplayOpenIncidentsTabPage.Size = new Size(192, 67);
            DisplayOpenIncidentsTabPage.TabIndex = 4;
            DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // loadOpenIncidentsUserControl
            // 
            loadOpenIncidentsUserControl.Location = new Point(2, 2);
            loadOpenIncidentsUserControl.Margin = new Padding(2);
            loadOpenIncidentsUserControl.Name = "loadOpenIncidentsUserControl";
            loadOpenIncidentsUserControl.Size = new Size(948, 615);
            loadOpenIncidentsUserControl.TabIndex = 0;
            // 
            // IncidentsTabControl
            // 
            IncidentsTabControl.Controls.Add(DisplayAllIncidentsTabPage);
            IncidentsTabControl.Controls.Add(DisplayOpenIncidentsTabPage);
            IncidentsTabControl.Controls.Add(AddIncidentTabPage);
            IncidentsTabControl.Controls.Add(UpdateIncidentTabPage);
            IncidentsTabControl.Dock = DockStyle.Bottom;
            IncidentsTabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncidentsTabControl.Location = new Point(0, 41);
            IncidentsTabControl.Margin = new Padding(3, 4, 3, 4);
            IncidentsTabControl.Name = "IncidentsTabControl";
            IncidentsTabControl.SelectedIndex = 0;
            IncidentsTabControl.Size = new Size(979, 662);
            IncidentsTabControl.TabIndex = 0;
            IncidentsTabControl.SelectedIndexChanged += IncidentsTabControl_SelectedIndexChanged;
            IncidentsTabControl.TabIndexChanged += TabDashboardMainForm_Load;
            IncidentsTabControl.Click += TabDashboardMainForm_Load;
            // 
            // DisplayAllIncidentsTabPage
            // 
            DisplayAllIncidentsTabPage.Controls.Add(loadAllIncidentsUserControl);
            DisplayAllIncidentsTabPage.Location = new Point(4, 34);
            DisplayAllIncidentsTabPage.Name = "DisplayAllIncidentsTabPage";
            DisplayAllIncidentsTabPage.Padding = new Padding(3);
            DisplayAllIncidentsTabPage.Size = new Size(971, 624);
            DisplayAllIncidentsTabPage.TabIndex = 5;
            DisplayAllIncidentsTabPage.Text = "Display All Incidents";
            DisplayAllIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // loadAllIncidentsUserControl
            // 
            loadAllIncidentsUserControl.Dock = DockStyle.Fill;
            loadAllIncidentsUserControl.Location = new Point(3, 3);
            loadAllIncidentsUserControl.Name = "loadAllIncidentsUserControl";
            loadAllIncidentsUserControl.Size = new Size(965, 618);
            loadAllIncidentsUserControl.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            AddIncidentTabPage.Controls.Add(addIncidentsUserControl1);
            AddIncidentTabPage.Location = new Point(4, 29);
            AddIncidentTabPage.Margin = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Name = "AddIncidentTabPage";
            AddIncidentTabPage.Padding = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Size = new Size(192, 67);
            AddIncidentTabPage.TabIndex = 1;
            AddIncidentTabPage.Text = "Add Incident";
            AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentsUserControl1
            // 
            addIncidentsUserControl1.AutoSize = true;
            addIncidentsUserControl1.Dock = DockStyle.Fill;
            addIncidentsUserControl1.Location = new Point(3, 4);
            addIncidentsUserControl1.Margin = new Padding(2, 4, 2, 4);
            addIncidentsUserControl1.Name = "addIncidentsUserControl1";
            addIncidentsUserControl1.Size = new Size(186, 59);
            addIncidentsUserControl1.TabIndex = 1;
            // 
            // UpdateIncidentTabPage
            // 
            UpdateIncidentTabPage.Controls.Add(updateIncidentUserControl1);
            UpdateIncidentTabPage.Location = new Point(4, 34);
            UpdateIncidentTabPage.Name = "UpdateIncidentTabPage";
            UpdateIncidentTabPage.Padding = new Padding(3);
            UpdateIncidentTabPage.Size = new Size(971, 624);
            UpdateIncidentTabPage.TabIndex = 6;
            UpdateIncidentTabPage.Text = "Update Incident";
            UpdateIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // updateIncidentUserControl1
            // 
            updateIncidentUserControl1.Dock = DockStyle.Fill;
            updateIncidentUserControl1.Location = new Point(3, 3);
            updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            updateIncidentUserControl1.Size = new Size(965, 618);
            updateIncidentUserControl1.TabIndex = 0;
            // 
            // DashboardTabMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 703);
            Controls.Add(DisplayNameLabel);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(IncidentsTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardTabMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incidents Dashboard";
            Load += DashboardTabMainForm_Load;
            DisplayOpenIncidentsTabPage.ResumeLayout(false);
            IncidentsTabControl.ResumeLayout(false);
            DisplayAllIncidentsTabPage.ResumeLayout(false);
            AddIncidentTabPage.ResumeLayout(false);
            AddIncidentTabPage.PerformLayout();
            UpdateIncidentTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel LogOutLinkLabel;
        private Label DisplayNameLabel;
        private TechSupport.UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
        private TabPage DisplayOpenIncidentsTabPage;
        private UserControls.LoadOpenIncidentsUserControl loadOpenIncidentsUserControl;
        private UserControls.AddIncidentsUserControl addIncidentsUserControl1;
        private TabControl IncidentsTabControl;
        private TabPage AddIncidentTabPage;
        private TabPage UpdateIncidentTabPage;
        private AllIncidents.UserControls.LoadAllIncidentsUserControl loadAllIncidentsUserControl;
        private TabPage DisplayAllIncidentsTabPage;
        private TechSupport.UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
    }
}