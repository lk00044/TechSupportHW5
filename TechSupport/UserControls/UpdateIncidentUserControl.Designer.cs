namespace TechSupport.UserControls
{
    partial class UpdateIncidentUserControl
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
            IDLabel = new Label();
            IncidentIDTtextBox = new TextBox();
            GetIncidentButton = new Button();
            CustomerTextBox = new TextBox();
            CustomerLabel = new Label();
            ProductLabel = new Label();
            TitleTextBox = new TextBox();
            TechnicianLabel = new Label();
            TechnicianComboBox = new ComboBox();
            TitleLabel = new Label();
            DateOpenedTtextBox = new TextBox();
            DateOpenedLabel = new Label();
            DescriptionLabel = new Label();
            TextToAddLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            TextToAddRichTextBox = new RichTextBox();
            ErrorMessageLabel = new Label();
            ProductTextBox = new TextBox();
            UpdateButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ClearButton = new Button();
            CloseIncidentButton = new Button();
            ResultErrorLabel = new Label();
            CurrentTechLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(3, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(88, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "Incident ID: ";
            // 
            // IncidentIDTtextBox
            // 
            IncidentIDTtextBox.Location = new Point(147, 3);
            IncidentIDTtextBox.Name = "IncidentIDTtextBox";
            IncidentIDTtextBox.Size = new Size(269, 27);
            IncidentIDTtextBox.TabIndex = 1;
            IncidentIDTtextBox.TextChanged += IncidentIDTtextBox_TextChanged;
            // 
            // GetIncidentButton
            // 
            GetIncidentButton.FlatStyle = FlatStyle.Popup;
            GetIncidentButton.Location = new Point(494, 3);
            GetIncidentButton.Name = "GetIncidentButton";
            GetIncidentButton.Size = new Size(272, 42);
            GetIncidentButton.TabIndex = 2;
            GetIncidentButton.Text = "Get Incident";
            GetIncidentButton.UseVisualStyleBackColor = true;
            GetIncidentButton.Click += GetIncidentButton_Click;
            // 
            // CustomerTextBox
            // 
            CustomerTextBox.Enabled = false;
            CustomerTextBox.Location = new Point(147, 118);
            CustomerTextBox.Name = "CustomerTextBox";
            CustomerTextBox.ReadOnly = true;
            CustomerTextBox.Size = new Size(269, 27);
            CustomerTextBox.TabIndex = 4;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(3, 115);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(72, 20);
            CustomerLabel.TabIndex = 3;
            CustomerLabel.Text = "Customer";
            // 
            // ProductLabel
            // 
            ProductLabel.AutoSize = true;
            ProductLabel.Location = new Point(3, 302);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(63, 20);
            ProductLabel.TabIndex = 5;
            ProductLabel.Text = "Product:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Enabled = false;
            TitleTextBox.Location = new Point(147, 351);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.ReadOnly = true;
            TitleTextBox.Size = new Size(269, 27);
            TitleTextBox.TabIndex = 8;
            // 
            // TechnicianLabel
            // 
            TechnicianLabel.AutoSize = true;
            TechnicianLabel.Location = new Point(3, 212);
            TechnicianLabel.Name = "TechnicianLabel";
            TechnicianLabel.Size = new Size(85, 20);
            TechnicianLabel.TabIndex = 7;
            TechnicianLabel.Text = "Technician: ";
            // 
            // TechnicianComboBox
            // 
            TechnicianComboBox.Enabled = false;
            TechnicianComboBox.FormattingEnabled = true;
            TechnicianComboBox.Location = new Point(147, 215);
            TechnicianComboBox.Name = "TechnicianComboBox";
            TechnicianComboBox.Size = new Size(269, 28);
            TechnicianComboBox.TabIndex = 9;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(3, 348);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Title:";
            // 
            // DateOpenedTtextBox
            // 
            DateOpenedTtextBox.Enabled = false;
            DateOpenedTtextBox.Location = new Point(147, 167);
            DateOpenedTtextBox.Name = "DateOpenedTtextBox";
            DateOpenedTtextBox.ReadOnly = true;
            DateOpenedTtextBox.Size = new Size(269, 27);
            DateOpenedTtextBox.TabIndex = 12;
            // 
            // DateOpenedLabel
            // 
            DateOpenedLabel.AutoSize = true;
            DateOpenedLabel.Location = new Point(3, 164);
            DateOpenedLabel.Name = "DateOpenedLabel";
            DateOpenedLabel.Size = new Size(101, 20);
            DateOpenedLabel.TabIndex = 11;
            DateOpenedLabel.Text = "Date Opened:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(3, 396);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 13;
            DescriptionLabel.Text = "Description:";
            // 
            // TextToAddLabel
            // 
            TextToAddLabel.AutoSize = true;
            TextToAddLabel.Location = new Point(494, 82);
            TextToAddLabel.Name = "TextToAddLabel";
            TextToAddLabel.Size = new Size(95, 20);
            TextToAddLabel.TabIndex = 15;
            TextToAddLabel.Text = "Text To Add: ";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(147, 399);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(DescriptionRichTextBox, 4);
            DescriptionRichTextBox.Size = new Size(275, 177);
            DescriptionRichTextBox.TabIndex = 16;
            DescriptionRichTextBox.Text = "";
            // 
            // TextToAddRichTextBox
            // 
            TextToAddRichTextBox.Enabled = false;
            TextToAddRichTextBox.Location = new Point(494, 118);
            TextToAddRichTextBox.Name = "TextToAddRichTextBox";
            tableLayoutPanel1.SetRowSpan(TextToAddRichTextBox, 4);
            TextToAddRichTextBox.Size = new Size(275, 177);
            TextToAddRichTextBox.TabIndex = 17;
            TextToAddRichTextBox.Text = "";
            TextToAddRichTextBox.TextChanged += TextToAddRichTextBox_TextChanged;
            // 
            // ErrorMessageLabel
            // 
            tableLayoutPanel1.SetColumnSpan(ErrorMessageLabel, 2);
            ErrorMessageLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorMessageLabel.Location = new Point(147, 48);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(256, 34);
            ErrorMessageLabel.TabIndex = 18;
            // 
            // ProductTextBox
            // 
            ProductTextBox.Enabled = false;
            ProductTextBox.Location = new Point(147, 305);
            ProductTextBox.Name = "ProductTextBox";
            ProductTextBox.ReadOnly = true;
            ProductTextBox.Size = new Size(269, 27);
            ProductTextBox.TabIndex = 19;
            // 
            // UpdateButton
            // 
            UpdateButton.FlatStyle = FlatStyle.Popup;
            UpdateButton.Location = new Point(494, 305);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(275, 39);
            UpdateButton.TabIndex = 20;
            UpdateButton.Text = "Update Incident";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.7469F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.2531052F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
            tableLayoutPanel1.Controls.Add(DateOpenedLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(TechnicianLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(DateOpenedTtextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(TechnicianComboBox, 1, 5);
            tableLayoutPanel1.Controls.Add(CustomerLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(CustomerTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(IDLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(IncidentIDTtextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(ClearButton, 3, 9);
            tableLayoutPanel1.Controls.Add(CloseIncidentButton, 3, 8);
            tableLayoutPanel1.Controls.Add(UpdateButton, 3, 7);
            tableLayoutPanel1.Controls.Add(TextToAddRichTextBox, 3, 3);
            tableLayoutPanel1.Controls.Add(TextToAddLabel, 3, 2);
            tableLayoutPanel1.Controls.Add(GetIncidentButton, 3, 0);
            tableLayoutPanel1.Controls.Add(ErrorMessageLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(ResultErrorLabel, 3, 10);
            tableLayoutPanel1.Controls.Add(DescriptionLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(DescriptionRichTextBox, 1, 9);
            tableLayoutPanel1.Controls.Add(TitleLabel, 0, 8);
            tableLayoutPanel1.Controls.Add(TitleTextBox, 1, 8);
            tableLayoutPanel1.Controls.Add(ProductLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(ProductTextBox, 1, 7);
            tableLayoutPanel1.Controls.Add(CurrentTechLabel, 1, 6);
            tableLayoutPanel1.Location = new Point(24, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.10811F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.89189F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(796, 579);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // ClearButton
            // 
            ClearButton.FlatStyle = FlatStyle.Popup;
            ClearButton.Location = new Point(494, 399);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(273, 38);
            ClearButton.TabIndex = 23;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CloseIncidentButton
            // 
            CloseIncidentButton.Enabled = false;
            CloseIncidentButton.FlatStyle = FlatStyle.Popup;
            CloseIncidentButton.Location = new Point(494, 351);
            CloseIncidentButton.Name = "CloseIncidentButton";
            CloseIncidentButton.Size = new Size(275, 40);
            CloseIncidentButton.TabIndex = 22;
            CloseIncidentButton.Text = "Close Incident";
            CloseIncidentButton.UseVisualStyleBackColor = true;
            CloseIncidentButton.Click += CloseIncidentButton_Click;
            // 
            // ResultErrorLabel
            // 
            ResultErrorLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultErrorLabel.Location = new Point(494, 449);
            ResultErrorLabel.Name = "ResultErrorLabel";
            tableLayoutPanel1.SetRowSpan(ResultErrorLabel, 3);
            ResultErrorLabel.Size = new Size(272, 130);
            ResultErrorLabel.TabIndex = 24;
            // 
            // CurrentTechLabel
            // 
            CurrentTechLabel.Location = new Point(147, 257);
            CurrentTechLabel.Name = "CurrentTechLabel";
            CurrentTechLabel.Size = new Size(275, 28);
            CurrentTechLabel.TabIndex = 25;
            // 
            // UpdateIncidentUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateIncidentUserControl";
            Size = new Size(848, 625);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label IDLabel;
        private TextBox IncidentIDTtextBox;
        private Button GetIncidentButton;
        private TextBox CustomerTextBox;
        private Label CustomerLabel;
        private TextBox textBox1;
        private Label ProductLabel;
        private TextBox TitleTextBox;
        private Label TechnicianLabel;
        private ComboBox TechnicianComboBox;
        private Label TitleLabel;
        private TextBox DateOpenedTtextBox;
        private Label DateOpenedLabel;
        private TextBox DescriptionTextBox;
        private Label DescriptionLabel;
        private Label TextToAddLabel;
        private RichTextBox DescriptionRichTextBox;
        private RichTextBox TextToAddRichTextBox;
        private Label ErrorMessageLabel;
        private TextBox ProductTextBox;
        private Button UpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button CloseIncidentButton;
        private Button ClearButton;
        private Label ResultErrorLabel;
        private Label CurrentTechLabel;
    }
}
