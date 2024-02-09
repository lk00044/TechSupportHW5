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
            LoadIncidentsTabPage = new TabPage();
            AddIncidentTabPage = new TabPage();
            SearchIncidentsTabPage = new TabPage();
            LogOutLinkLabel = new LinkLabel();
            IncidentsTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // IncidentsTabControl
            // 
            IncidentsTabControl.Controls.Add(LoadIncidentsTabPage);
            IncidentsTabControl.Controls.Add(AddIncidentTabPage);
            IncidentsTabControl.Controls.Add(SearchIncidentsTabPage);
            IncidentsTabControl.Dock = DockStyle.Bottom;
            IncidentsTabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncidentsTabControl.Location = new Point(0, 36);
            IncidentsTabControl.Name = "IncidentsTabControl";
            IncidentsTabControl.SelectedIndex = 0;
            IncidentsTabControl.Size = new Size(484, 325);
            IncidentsTabControl.TabIndex = 0;
            // 
            // LoadIncidentsTabPage
            // 
            LoadIncidentsTabPage.Location = new Point(4, 28);
            LoadIncidentsTabPage.Name = "LoadIncidentsTabPage";
            LoadIncidentsTabPage.Padding = new Padding(3);
            LoadIncidentsTabPage.Size = new Size(476, 293);
            LoadIncidentsTabPage.TabIndex = 0;
            LoadIncidentsTabPage.Text = "Load Incidents";
            LoadIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddIncidentTabPage
            // 
            AddIncidentTabPage.Location = new Point(4, 28);
            AddIncidentTabPage.Name = "AddIncidentTabPage";
            AddIncidentTabPage.Padding = new Padding(3);
            AddIncidentTabPage.Size = new Size(476, 293);
            AddIncidentTabPage.TabIndex = 1;
            AddIncidentTabPage.Text = "Add Incidents";
            AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchIncidentsTabPage
            // 
            SearchIncidentsTabPage.Location = new Point(4, 28);
            SearchIncidentsTabPage.Name = "SearchIncidentsTabPage";
            SearchIncidentsTabPage.Size = new Size(476, 268);
            SearchIncidentsTabPage.TabIndex = 2;
            SearchIncidentsTabPage.Text = "Search Incidents";
            SearchIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.Location = new Point(388, 36);
            LogOutLinkLabel.Name = "LogOutLinkLabel";
            LogOutLinkLabel.Size = new Size(89, 25);
            LogOutLinkLabel.TabIndex = 1;
            LogOutLinkLabel.TabStop = true;
            LogOutLinkLabel.Text = "Log Out";
            // 
            // DashboardTabMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(IncidentsTabControl);
            Name = "DashboardTabMainForm";
            Text = "Incidents Dashboard";
            Load += TabDashboardMainForm_Load;
            IncidentsTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl IncidentsTabControl;
        private TabPage LoadIncidentsTabPage;
        private TabPage AddIncidentTabPage;
        private TabPage SearchIncidentsTabPage;
        private LinkLabel LogOutLinkLabel;
    }
}