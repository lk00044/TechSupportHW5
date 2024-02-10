namespace DisplayIncidents.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param UserName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            DisplayUserNameLabel = new Label();
            LogoutLinkLabel = new LinkLabel();
            AddIncidentButton = new Button();
            SearchIncidentButton = new Button();
            IncidentsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DisplayUserNameLabel
            // 
            DisplayUserNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DisplayUserNameLabel.Location = new Point(486, 16);
            DisplayUserNameLabel.Name = "DisplayUserNameLabel";
            DisplayUserNameLabel.Size = new Size(315, 33);
            DisplayUserNameLabel.TabIndex = 0;
            DisplayUserNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // LogoutLinkLabel
            // 
            LogoutLinkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Location = new Point(745, 49);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new Size(56, 20);
            LogoutLinkLabel.TabIndex = 1;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // AddIncidentButton
            // 
            AddIncidentButton.Location = new Point(188, 258);
            AddIncidentButton.Name = "AddIncidentButton";
            AddIncidentButton.Size = new Size(146, 29);
            AddIncidentButton.TabIndex = 2;
            AddIncidentButton.Text = "Add Incident";
            AddIncidentButton.UseVisualStyleBackColor = true;
            AddIncidentButton.Click += AddIncidentButton_Click;
            // 
            // SearchIncidentButton
            // 
            SearchIncidentButton.Location = new Point(463, 258);
            SearchIncidentButton.Name = "SearchIncidentButton";
            SearchIncidentButton.Size = new Size(128, 29);
            SearchIncidentButton.TabIndex = 3;
            SearchIncidentButton.Text = "Search Incident";
            SearchIncidentButton.UseVisualStyleBackColor = true;
            SearchIncidentButton.Click += SearchIncidentButton_Click;
            // 
            // IncidentsDataGridView
            // 
            IncidentsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IncidentsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            IncidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncidentsDataGridView.Location = new Point(87, 83);
            IncidentsDataGridView.Name = "IncidentsDataGridView";
            IncidentsDataGridView.RowHeadersWidth = 51;
            IncidentsDataGridView.Size = new Size(622, 155);
            IncidentsDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 299);
            Controls.Add(IncidentsDataGridView);
            Controls.Add(SearchIncidentButton);
            Controls.Add(AddIncidentButton);
            Controls.Add(LogoutLinkLabel);
            Controls.Add(DisplayUserNameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Search Incidents Form";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DisplayUserNameLabel;
        private LinkLabel LogoutLinkLabel;
        private Button AddIncidentButton;
        private Button SearchIncidentButton;
        private DataGridView IncidentsDataGridView;
    }
}