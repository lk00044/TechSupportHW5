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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(3, 53);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(88, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "Incident ID: ";
            // 
            // IncidentIDTtextBox
            // 
            IncidentIDTtextBox.Location = new Point(147, 56);
            IncidentIDTtextBox.Name = "IncidentIDTtextBox";
            IncidentIDTtextBox.Size = new Size(269, 27);
            IncidentIDTtextBox.TabIndex = 1;
            // 
            // GetIncidentButton
            // 
            GetIncidentButton.Location = new Point(147, 3);
            GetIncidentButton.Name = "GetIncidentButton";
            GetIncidentButton.Size = new Size(272, 29);
            GetIncidentButton.TabIndex = 2;
            GetIncidentButton.Text = "Get Incident";
            GetIncidentButton.UseVisualStyleBackColor = true;
            GetIncidentButton.Click += GetIncidentButton_Click;
            // 
            // CustomerTextBox
            // 
            CustomerTextBox.Enabled = false;
            CustomerTextBox.Location = new Point(147, 138);
            CustomerTextBox.Name = "CustomerTextBox";
            CustomerTextBox.Size = new Size(269, 27);
            CustomerTextBox.TabIndex = 4;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(3, 135);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(72, 20);
            CustomerLabel.TabIndex = 3;
            CustomerLabel.Text = "Customer";
            // 
            // ProductLabel
            // 
            ProductLabel.AutoSize = true;
            ProductLabel.Location = new Point(3, 277);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(63, 20);
            ProductLabel.TabIndex = 5;
            ProductLabel.Text = "Product:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Enabled = false;
            TitleTextBox.Location = new Point(147, 325);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(269, 27);
            TitleTextBox.TabIndex = 8;
            // 
            // TechnicianLabel
            // 
            TechnicianLabel.AutoSize = true;
            TechnicianLabel.Location = new Point(3, 232);
            TechnicianLabel.Name = "TechnicianLabel";
            TechnicianLabel.Size = new Size(85, 20);
            TechnicianLabel.TabIndex = 7;
            TechnicianLabel.Text = "Technician: ";
            // 
            // TechnicianComboBox
            // 
            TechnicianComboBox.Enabled = false;
            TechnicianComboBox.FormattingEnabled = true;
            TechnicianComboBox.Location = new Point(147, 235);
            TechnicianComboBox.Name = "TechnicianComboBox";
            TechnicianComboBox.Size = new Size(269, 28);
            TechnicianComboBox.TabIndex = 9;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(3, 322);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Title:";
            // 
            // DateOpenedTtextBox
            // 
            DateOpenedTtextBox.Enabled = false;
            DateOpenedTtextBox.Location = new Point(147, 187);
            DateOpenedTtextBox.Name = "DateOpenedTtextBox";
            DateOpenedTtextBox.Size = new Size(269, 27);
            DateOpenedTtextBox.TabIndex = 12;
            // 
            // DateOpenedLabel
            // 
            DateOpenedLabel.AutoSize = true;
            DateOpenedLabel.Location = new Point(3, 184);
            DateOpenedLabel.Name = "DateOpenedLabel";
            DateOpenedLabel.Size = new Size(101, 20);
            DateOpenedLabel.TabIndex = 11;
            DateOpenedLabel.Text = "Date Opened:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(3, 368);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 13;
            DescriptionLabel.Text = "Description:";
            // 
            // TextToAddLabel
            // 
            TextToAddLabel.AutoSize = true;
            TextToAddLabel.Location = new Point(494, 53);
            TextToAddLabel.Name = "TextToAddLabel";
            TextToAddLabel.Size = new Size(95, 20);
            TextToAddLabel.TabIndex = 15;
            TextToAddLabel.Text = "Text To Add: ";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Enabled = false;
            DescriptionRichTextBox.Location = new Point(147, 371);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            tableLayoutPanel1.SetRowSpan(DescriptionRichTextBox, 4);
            DescriptionRichTextBox.Size = new Size(275, 180);
            DescriptionRichTextBox.TabIndex = 16;
            DescriptionRichTextBox.Text = "";
            // 
            // TextToAddRichTextBox
            // 
            TextToAddRichTextBox.Location = new Point(494, 97);
            TextToAddRichTextBox.Name = "TextToAddRichTextBox";
            tableLayoutPanel1.SetRowSpan(TextToAddRichTextBox, 4);
            TextToAddRichTextBox.Size = new Size(275, 177);
            TextToAddRichTextBox.TabIndex = 17;
            TextToAddRichTextBox.Text = "";
            // 
            // ErrorMessageLabel
            // 
            tableLayoutPanel1.SetColumnSpan(ErrorMessageLabel, 2);
            ErrorMessageLabel.Location = new Point(147, 94);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(256, 25);
            ErrorMessageLabel.TabIndex = 18;
            // 
            // ProductTextBox
            // 
            ProductTextBox.Enabled = false;
            ProductTextBox.Location = new Point(147, 280);
            ProductTextBox.Name = "ProductTextBox";
            ProductTextBox.Size = new Size(269, 27);
            ProductTextBox.TabIndex = 19;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(494, 280);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(273, 29);
            UpdateButton.TabIndex = 20;
            UpdateButton.Text = "Update Incident";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.7469F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.2531052F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
            tableLayoutPanel1.Controls.Add(IncidentIDTtextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(IDLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(DescriptionLabel, 0, 8);
            tableLayoutPanel1.Controls.Add(DescriptionRichTextBox, 1, 8);
            tableLayoutPanel1.Controls.Add(TitleLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(TitleTextBox, 1, 7);
            tableLayoutPanel1.Controls.Add(ProductLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(ProductTextBox, 1, 6);
            tableLayoutPanel1.Controls.Add(DateOpenedLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(TechnicianLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(DateOpenedTtextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(TechnicianComboBox, 1, 5);
            tableLayoutPanel1.Controls.Add(CustomerLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(CustomerTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(GetIncidentButton, 1, 0);
            tableLayoutPanel1.Controls.Add(ErrorMessageLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(TextToAddLabel, 3, 1);
            tableLayoutPanel1.Controls.Add(TextToAddRichTextBox, 3, 2);
            tableLayoutPanel1.Controls.Add(UpdateButton, 3, 6);
            tableLayoutPanel1.Location = new Point(24, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.38298F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.61702F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(796, 579);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // UpdateIncidentUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateIncidentUserControl";
            Size = new Size(848, 613);
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
    }
}
