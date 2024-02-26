namespace Incidents.UserControls
{
    partial class AddIncidentsUserControl
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
            TitleErrorLabel = new Label();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            CustomerIDLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            AddIncidentTableLayoutPanel = new TableLayoutPanel();
            DescriptionErrorLabel = new Label();
            ProductLabel = new Label();
            CustomerIDComboBox = new ComboBox();
            ProductComboBox = new ComboBox();
            CancelButton = new Button();
            AddButton = new Button();
            AddIncidentTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleErrorLabel
            // 
            TitleErrorLabel.Location = new Point(144, 169);
            TitleErrorLabel.Name = "TitleErrorLabel";
            TitleErrorLabel.Size = new Size(329, 29);
            TitleErrorLabel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(3, 132);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(144, 135);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(329, 27);
            TitleTextBox.TabIndex = 1;
            TitleTextBox.Click += TitleTextBox_Click;
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Location = new Point(3, 0);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(119, 20);
            CustomerIDLabel.TabIndex = 2;
            CustomerIDLabel.Text = "Customer Name:";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(144, 221);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(329, 154);
            DescriptionRichTextBox.TabIndex = 2;
            DescriptionRichTextBox.Text = "";
            DescriptionRichTextBox.Click += DescriptionRichTextBox_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(3, 218);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Description:";
            // 
            // AddIncidentTableLayoutPanel
            // 
            AddIncidentTableLayoutPanel.ColumnCount = 2;
            AddIncidentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8849564F));
            AddIncidentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.11504F));
            AddIncidentTableLayoutPanel.Controls.Add(CustomerIDLabel, 0, 0);
            AddIncidentTableLayoutPanel.Controls.Add(TitleLabel, 0, 2);
            AddIncidentTableLayoutPanel.Controls.Add(TitleErrorLabel, 1, 3);
            AddIncidentTableLayoutPanel.Controls.Add(TitleTextBox, 1, 2);
            AddIncidentTableLayoutPanel.Controls.Add(DescriptionLabel, 0, 4);
            AddIncidentTableLayoutPanel.Controls.Add(DescriptionRichTextBox, 1, 4);
            AddIncidentTableLayoutPanel.Controls.Add(DescriptionErrorLabel, 1, 5);
            AddIncidentTableLayoutPanel.Controls.Add(ProductLabel, 0, 1);
            AddIncidentTableLayoutPanel.Controls.Add(CustomerIDComboBox, 1, 0);
            AddIncidentTableLayoutPanel.Controls.Add(ProductComboBox, 1, 1);
            AddIncidentTableLayoutPanel.Location = new Point(42, 24);
            AddIncidentTableLayoutPanel.Name = "AddIncidentTableLayoutPanel";
            AddIncidentTableLayoutPanel.RowCount = 6;
            AddIncidentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7857132F));
            AddIncidentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2142868F));
            AddIncidentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            AddIncidentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            AddIncidentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 169F));
            AddIncidentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            AddIncidentTableLayoutPanel.Size = new Size(546, 438);
            AddIncidentTableLayoutPanel.TabIndex = 6;
            // 
            // DescriptionErrorLabel
            // 
            DescriptionErrorLabel.Location = new Point(144, 387);
            DescriptionErrorLabel.Name = "DescriptionErrorLabel";
            DescriptionErrorLabel.Size = new Size(329, 25);
            DescriptionErrorLabel.TabIndex = 6;
            // 
            // ProductLabel
            // 
            ProductLabel.AutoSize = true;
            ProductLabel.Location = new Point(3, 68);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(63, 20);
            ProductLabel.TabIndex = 7;
            ProductLabel.Text = "Product:";
            // 
            // CustomerIDComboBox
            // 
            CustomerIDComboBox.FormattingEnabled = true;
            CustomerIDComboBox.Location = new Point(144, 3);
            CustomerIDComboBox.Name = "CustomerIDComboBox";
            CustomerIDComboBox.Size = new Size(329, 28);
            CustomerIDComboBox.TabIndex = 8;
            // 
            // ProductComboBox
            // 
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(144, 71);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(329, 28);
            ProductComboBox.TabIndex = 9;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(365, 497);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(137, 29);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(117, 497);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(137, 29);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add Incident";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddIncidentsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(AddIncidentTableLayoutPanel);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddIncidentsUserControl";
            Size = new Size(635, 552);
            AddIncidentTableLayoutPanel.ResumeLayout(false);
            AddIncidentTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleErrorLabel;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label CustomerIDLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DescriptionLabel;
        private TableLayoutPanel AddIncidentTableLayoutPanel;
        private Label DescriptionErrorLabel;
        private Button CancelButton;
        private Button AddButton;
        private Label ProductLabel;
        private ComboBox CustomerIDComboBox;
        private ComboBox ProductComboBox;
    }
}
