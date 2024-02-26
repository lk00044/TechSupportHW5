﻿namespace Incidents.View
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
            OpenIncidentsListView = new ListView();
            ProductCodeColumnHeader = new ColumnHeader();
            DateOpenedColumnHeader = new ColumnHeader();
            CustomerColumnHeader = new ColumnHeader();
            TechnicianColumnHeader = new ColumnHeader();
            TitleColumnHeader = new ColumnHeader();
            IncidentsTabControl = new TabControl();
            AddIncidentTabPage = new TabPage();
            addIncidentsUserControl1 = new UserControls.AddIncidentsUserControl();
            addIncidentsUserControl2 = new UserControls.AddIncidentsUserControl();
            DisplayOpenIncidentsTabPage.SuspendLayout();
            IncidentsTabControl.SuspendLayout();
            AddIncidentTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.Location = new Point(631, 39);
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
            // DisplayOpenIncidentsTabPage
            // 
            DisplayOpenIncidentsTabPage.Controls.Add(OpenIncidentsListView);
            DisplayOpenIncidentsTabPage.Location = new Point(4, 34);
            DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            DisplayOpenIncidentsTabPage.Padding = new Padding(3);
            DisplayOpenIncidentsTabPage.Size = new Size(711, 624);
            DisplayOpenIncidentsTabPage.TabIndex = 4;
            DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // OpenIncidentsListView
            // 
            OpenIncidentsListView.Columns.AddRange(new ColumnHeader[] { ProductCodeColumnHeader, DateOpenedColumnHeader, CustomerColumnHeader, TechnicianColumnHeader, TitleColumnHeader });
            OpenIncidentsListView.Dock = DockStyle.Fill;
            OpenIncidentsListView.Location = new Point(3, 3);
            OpenIncidentsListView.Name = "OpenIncidentsListView";
            OpenIncidentsListView.Size = new Size(705, 618);
            OpenIncidentsListView.TabIndex = 0;
            OpenIncidentsListView.UseCompatibleStateImageBehavior = false;
            OpenIncidentsListView.SelectedIndexChanged += OpenIncidentsListView_SelectedIndexChanged;
            OpenIncidentsListView.TabIndexChanged += loadOpenIncidentsUserControl2_Load;
            OpenIncidentsListView.Click += DisplayOpenIncidentsTabPage_Click;
            // 
            // ProductCodeColumnHeader
            // 
            ProductCodeColumnHeader.Text = "Product Code";
            // 
            // DateOpenedColumnHeader
            // 
            DateOpenedColumnHeader.Text = "Date Opened";
            // 
            // CustomerColumnHeader
            // 
            CustomerColumnHeader.Text = "Customer";
            // 
            // TechnicianColumnHeader
            // 
            TechnicianColumnHeader.Text = "Technician";
            // 
            // TitleColumnHeader
            // 
            TitleColumnHeader.Text = "Title";
            // 
            // IncidentsTabControl
            // 
            IncidentsTabControl.Controls.Add(DisplayOpenIncidentsTabPage);
            IncidentsTabControl.Controls.Add(AddIncidentTabPage);
            IncidentsTabControl.Dock = DockStyle.Bottom;
            IncidentsTabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncidentsTabControl.Location = new Point(0, 57);
            IncidentsTabControl.Margin = new Padding(3, 4, 3, 4);
            IncidentsTabControl.Name = "IncidentsTabControl";
            IncidentsTabControl.SelectedIndex = 0;
            IncidentsTabControl.Size = new Size(719, 662);
            IncidentsTabControl.TabIndex = 0;
            IncidentsTabControl.TabIndexChanged += TabDashboardMainForm_Load;
            IncidentsTabControl.Click += TabDashboardMainForm_Load;
            // 
            // AddIncidentTabPage
            // 
            AddIncidentTabPage.Controls.Add(addIncidentsUserControl1);
            AddIncidentTabPage.Controls.Add(addIncidentsUserControl2);
            AddIncidentTabPage.Location = new Point(4, 29);
            AddIncidentTabPage.Margin = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Name = "AddIncidentTabPage";
            AddIncidentTabPage.Padding = new Padding(3, 4, 3, 4);
            AddIncidentTabPage.Size = new Size(192, 67);
            AddIncidentTabPage.TabIndex = 1;
            AddIncidentTabPage.Text = "Add";
            AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentsUserControl1
            // 
            addIncidentsUserControl1.AutoSize = true;
            addIncidentsUserControl1.Location = new Point(6, 0);
            addIncidentsUserControl1.Margin = new Padding(3, 4, 3, 4);
            addIncidentsUserControl1.Name = "addIncidentsUserControl1";
            addIncidentsUserControl1.Size = new Size(739, 661);
            addIncidentsUserControl1.TabIndex = 1;
            // 
            // addIncidentsUserControl2
            // 
            addIncidentsUserControl2.AutoSize = true;
            addIncidentsUserControl2.Location = new Point(3, 4);
            addIncidentsUserControl2.Margin = new Padding(3, 4, 3, 4);
            addIncidentsUserControl2.Name = "addIncidentsUserControl2";
            addIncidentsUserControl2.Size = new Size(738, 661);
            addIncidentsUserControl2.TabIndex = 0;
            // 
            // DashboardTabMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 719);
            Controls.Add(DisplayNameLabel);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(IncidentsTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardTabMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incidents Dashboard";
            Load += TabDashboardMainForm_Load;
            DisplayOpenIncidentsTabPage.ResumeLayout(false);
            IncidentsTabControl.ResumeLayout(false);
            AddIncidentTabPage.ResumeLayout(false);
            AddIncidentTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel LogOutLinkLabel;
        private Label DisplayNameLabel;
        private TechSupport.UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
        private TabPage DisplayOpenIncidentsTabPage;
        private UserControls.LoadOpenIncidentsUserControl loadOpenIncidentsUserControl1;
        private UserControls.AddIncidentsUserControl addIncidentsUserControl1;
        private TabControl IncidentsTabControl;
        private TabPage AddIncidentTabPage;
        private UserControls.AddIncidentsUserControl addIncidentsUserControl2;
        private ListView OpenIncidentsListView;
        private ColumnHeader ProductCodeColumnHeader;
        private ColumnHeader DateOpenedColumnHeader;
        private ColumnHeader CustomerColumnHeader;
        private ColumnHeader TechnicianColumnHeader;
        private ColumnHeader TitleColumnHeader;
    }
}