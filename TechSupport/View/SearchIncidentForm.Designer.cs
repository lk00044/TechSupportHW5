namespace Incidents.View
{
    partial class SearchIncidentForm
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
            SearchButton = new Button();
            IncidentsDataGridView = new DataGridView();
            SearchPromptLabel = new Label();
            CustomerIDTextBox = new TextBox();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(380, 33);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // IncidentsDataGridView
            // 
            IncidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncidentsDataGridView.Location = new Point(59, 89);
            IncidentsDataGridView.Name = "IncidentsDataGridView";
            IncidentsDataGridView.RowHeadersWidth = 51;
            IncidentsDataGridView.Size = new Size(415, 188);
            IncidentsDataGridView.TabIndex = 1;
            // 
            // SearchPromptLabel
            // 
            SearchPromptLabel.AutoSize = true;
            SearchPromptLabel.Location = new Point(59, 37);
            SearchPromptLabel.Name = "SearchPromptLabel";
            SearchPromptLabel.Size = new Size(132, 20);
            SearchPromptLabel.TabIndex = 2;
            SearchPromptLabel.Text = "Enter Customer ID:";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(200, 36);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(125, 27);
            CustomerIDTextBox.TabIndex = 1;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(215, 308);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // SearchIncidentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 365);
            Controls.Add(CloseButton);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(SearchPromptLabel);
            Controls.Add(IncidentsDataGridView);
            Controls.Add(SearchButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SearchIncidentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Incident Form";
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private DataGridView IncidentsDataGridView;
        private Label SearchPromptLabel;
        private TextBox CustomerIDTextBox;
        private Button CloseButton;
    }
}