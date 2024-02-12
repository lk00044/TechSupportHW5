namespace TechSupport.UserControls
{
    partial class SearchIncidentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CustomerIDTextBox = new TextBox();
            SearchPromptLabel = new Label();
            IncidentsDataGridView = new DataGridView();
            SearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(211, 43);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(125, 27);
            CustomerIDTextBox.TabIndex = 4;
            // 
            // SearchPromptLabel
            // 
            SearchPromptLabel.AutoSize = true;
            SearchPromptLabel.Location = new Point(70, 44);
            SearchPromptLabel.Name = "SearchPromptLabel";
            SearchPromptLabel.Size = new Size(132, 20);
            SearchPromptLabel.TabIndex = 6;
            SearchPromptLabel.Text = "Enter Customer ID:";
            // 
            // IncidentsDataGridView
            // 
            IncidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncidentsDataGridView.Location = new Point(50, 98);
            IncidentsDataGridView.Name = "IncidentsDataGridView";
            IncidentsDataGridView.RowHeadersWidth = 51;
            IncidentsDataGridView.Size = new Size(471, 249);
            IncidentsDataGridView.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(391, 40);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchIncidentsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerIDTextBox);
            Controls.Add(SearchPromptLabel);
            Controls.Add(IncidentsDataGridView);
            Controls.Add(SearchButton);
            Name = "SearchIncidentsUserControl";
            Size = new Size(583, 379);
            ((System.ComponentModel.ISupportInitialize)IncidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox CustomerIDTextBox;
        private Label SearchPromptLabel;
        private DataGridView IncidentsDataGridView;
        private Button SearchButton;
    }
}
