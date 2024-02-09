namespace TechSupport.View
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
            IncidentsTabControl = new TabControl();
            AddIncidentTabPage = new TabPage();
            addIncidentsUserControl1 = new UserControls.AddIncidentsUserControl();
            LoadIncidentsTabPage = new TabPage();
            loadIncidentsUserControl1 = new UserControls.LoadIncidentsUserControl();
            SearchIncidentsTabPage = new TabPage();
            LogOutLinkLabel = new LinkLabel();
            IncidentsTabControl.SuspendLayout();
            AddIncidentTabPage.SuspendLayout();
            LoadIncidentsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // IncidentsTabControl
            // 
            IncidentsTabControl.Controls.Add(AddIncidentTabPage);
            IncidentsTabControl.Controls.Add(LoadIncidentsTabPage);
            IncidentsTabControl.Controls.Add(SearchIncidentsTabPage);
            IncidentsTabControl.Dock = DockStyle.Bottom;
            IncidentsTabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncidentsTabControl.Location = new Point(0, 81);
            IncidentsTabControl.Margin = new Padding(3, 4, 3, 4);
            IncidentsTabControl.Name = "IncidentsTabControl";
            IncidentsTabControl.SelectedIndex = 0;
            IncidentsTabControl.Size = new Size(569, 455);
            IncidentsTabControl.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            AddIncidentTabPage.Controls.Add(addIncidentsUserControl1);
            AddIncidentTabPage.Location = new Point(4, 34);
            AddIncidentTabPage.Margin = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Name = "AddIncidentTabPage";
            AddIncidentTabPage.Padding = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Size = new Size(561, 417);
            AddIncidentTabPage.TabIndex = 1;
            AddIncidentTabPage.Text = "Add Incidents";
            AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentsUserControl1
            // 
            addIncidentsUserControl1.AutoSize = true;
            addIncidentsUserControl1.Location = new Point(8, 4);
            addIncidentsUserControl1.Margin = new Padding(3, 4, 3, 4);
            addIncidentsUserControl1.Name = "addIncidentsUserControl1";
            addIncidentsUserControl1.Size = new Size(622, 500);
            addIncidentsUserControl1.TabIndex = 0;
            // 
            // LoadIncidentsTabPage
            // 
            LoadIncidentsTabPage.Controls.Add(loadIncidentsUserControl1);
            LoadIncidentsTabPage.Location = new Point(4, 34);
            LoadIncidentsTabPage.Name = "LoadIncidentsTabPage";
            LoadIncidentsTabPage.Size = new Size(561, 417);
            LoadIncidentsTabPage.TabIndex = 3;
            LoadIncidentsTabPage.Text = "Load Incidents";
            LoadIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // loadIncidentsUserControl1
            // 
            loadIncidentsUserControl1.AutoSize = true;
            loadIncidentsUserControl1.Location = new Point(3, 3);
            loadIncidentsUserControl1.Name = "loadIncidentsUserControl1";
            loadIncidentsUserControl1.Size = new Size(555, 406);
            loadIncidentsUserControl1.TabIndex = 0;
            // 
            // SearchIncidentsTabPage
            // 
            SearchIncidentsTabPage.Location = new Point(4, 34);
            SearchIncidentsTabPage.Margin = new Padding(3, 4, 3, 4);
            SearchIncidentsTabPage.Name = "SearchIncidentsTabPage";
            SearchIncidentsTabPage.Size = new Size(561, 417);
            SearchIncidentsTabPage.TabIndex = 2;
            SearchIncidentsTabPage.Text = "Search Incidents";
            SearchIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.Location = new Point(477, 33);
            LogOutLinkLabel.Name = "LogOutLinkLabel";
            LogOutLinkLabel.Size = new Size(76, 33);
            LogOutLinkLabel.TabIndex = 1;
            LogOutLinkLabel.TabStop = true;
            LogOutLinkLabel.Text = "Log Out";
            LogOutLinkLabel.LinkClicked += LogOutLinkLabel_LinkClicked;
            // 
            // DashboardTabMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 536);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(IncidentsTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardTabMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incidents Dashboard";
            Load += TabDashboardMainForm_Load;
            IncidentsTabControl.ResumeLayout(false);
            AddIncidentTabPage.ResumeLayout(false);
            AddIncidentTabPage.PerformLayout();
            LoadIncidentsTabPage.ResumeLayout(false);
            LoadIncidentsTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl IncidentsTabControl;
        private TabPage AddIncidentTabPage;
        private TabPage SearchIncidentsTabPage;
        private LinkLabel LogOutLinkLabel;
        private TabPage LoadIncidentsTabPage;
        private UserControls.AddIncidentsUserControl addIncidentsUserControl1;
        private UserControls.LoadIncidentsUserControl loadIncidentsUserControl1;
    }
}