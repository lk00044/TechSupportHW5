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
            SearchIncidentsTabPage = new TabPage();
            searchIncidentsUserControl1 = new TechSupport.UserControls.SearchIncidentsUserControl();
            DisplayOpenIncidentsTabPage = new TabPage();
            loadOpenIncidentsUserControl1 = new UserControls.LoadOpenIncidentsUserControl();
            AddIncidentTabPage = new TabPage();
            addIncidentsUserControl1 = new UserControls.AddIncidentsUserControl();
            IncidentsTabControl = new TabControl();
            SearchIncidentsTabPage.SuspendLayout();
            DisplayOpenIncidentsTabPage.SuspendLayout();
            AddIncidentTabPage.SuspendLayout();
            IncidentsTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.Location = new Point(631, 44);
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
            DisplayNameLabel.Location = new Point(561, 9);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(146, 26);
            DisplayNameLabel.TabIndex = 2;
            DisplayNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // SearchIncidentsTabPage
            // 
            SearchIncidentsTabPage.Controls.Add(searchIncidentsUserControl1);
            SearchIncidentsTabPage.Location = new Point(4, 34);
            SearchIncidentsTabPage.Margin = new Padding(3, 4, 3, 4);
            SearchIncidentsTabPage.Name = "SearchIncidentsTabPage";
            SearchIncidentsTabPage.Size = new Size(711, 417);
            SearchIncidentsTabPage.TabIndex = 2;
            SearchIncidentsTabPage.Text = "Search Incidents";
            SearchIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchIncidentsUserControl1
            // 
            searchIncidentsUserControl1.AutoSize = true;
            searchIncidentsUserControl1.Location = new Point(19, 3);
            searchIncidentsUserControl1.Name = "searchIncidentsUserControl1";
            searchIncidentsUserControl1.Size = new Size(684, 437);
            searchIncidentsUserControl1.TabIndex = 0;
            // 
            // DisplayOpenIncidentsTabPage
            // 
            DisplayOpenIncidentsTabPage.Controls.Add(loadOpenIncidentsUserControl1);
            DisplayOpenIncidentsTabPage.Location = new Point(4, 34);
            DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            DisplayOpenIncidentsTabPage.Padding = new Padding(3);
            DisplayOpenIncidentsTabPage.Size = new Size(711, 417);
            DisplayOpenIncidentsTabPage.TabIndex = 4;
            DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // loadOpenIncidentsUserControl1
            // 
            loadOpenIncidentsUserControl1.AutoSize = true;
            loadOpenIncidentsUserControl1.Location = new Point(8, 6);
            loadOpenIncidentsUserControl1.Name = "loadOpenIncidentsUserControl1";
            loadOpenIncidentsUserControl1.Size = new Size(695, 403);
            loadOpenIncidentsUserControl1.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            AddIncidentTabPage.Controls.Add(addIncidentsUserControl1);
            AddIncidentTabPage.Location = new Point(4, 34);
            AddIncidentTabPage.Margin = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Name = "AddIncidentTabPage";
            AddIncidentTabPage.Padding = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Size = new Size(711, 417);
            AddIncidentTabPage.TabIndex = 1;
            AddIncidentTabPage.Text = "Add Incidents";
            AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentsUserControl1
            // 
            addIncidentsUserControl1.AutoSize = true;
            addIncidentsUserControl1.Location = new Point(8, 4);
            addIncidentsUserControl1.Margin = new Padding(2, 4, 2, 4);
            addIncidentsUserControl1.Name = "addIncidentsUserControl1";
            addIncidentsUserControl1.Size = new Size(631, 409);
            addIncidentsUserControl1.TabIndex = 0;
            // 
            // IncidentsTabControl
            // 
            IncidentsTabControl.Controls.Add(AddIncidentTabPage);
            IncidentsTabControl.Controls.Add(DisplayOpenIncidentsTabPage);
            IncidentsTabControl.Controls.Add(SearchIncidentsTabPage);
            IncidentsTabControl.Dock = DockStyle.Bottom;
            IncidentsTabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncidentsTabControl.Location = new Point(0, 81);
            IncidentsTabControl.Margin = new Padding(3, 4, 3, 4);
            IncidentsTabControl.Name = "IncidentsTabControl";
            IncidentsTabControl.SelectedIndex = 0;
            IncidentsTabControl.Size = new Size(719, 455);
            IncidentsTabControl.TabIndex = 0;
            IncidentsTabControl.TabIndexChanged += TabDashboardMainForm_Load;
            IncidentsTabControl.Click += TabDashboardMainForm_Load;
            // 
            // DashboardTabMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 536);
            Controls.Add(DisplayNameLabel);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(IncidentsTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardTabMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incidents Dashboard";
            Load += TabDashboardMainForm_Load;
            SearchIncidentsTabPage.ResumeLayout(false);
            SearchIncidentsTabPage.PerformLayout();
            DisplayOpenIncidentsTabPage.ResumeLayout(false);
            DisplayOpenIncidentsTabPage.PerformLayout();
            AddIncidentTabPage.ResumeLayout(false);
            AddIncidentTabPage.PerformLayout();
            IncidentsTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel LogOutLinkLabel;
        private Label DisplayNameLabel;
        private TabPage SearchIncidentsTabPage;
        private TechSupport.UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
        private TabPage DisplayOpenIncidentsTabPage;
        private UserControls.LoadOpenIncidentsUserControl loadOpenIncidentsUserControl1;
        private TabPage AddIncidentTabPage;
        private UserControls.AddIncidentsUserControl addIncidentsUserControl1;
        private TabControl IncidentsTabControl;
    }
}