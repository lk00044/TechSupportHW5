namespace TechSupport.View
{
    partial class IncidentForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            TitleLabel = new Label();
            DescriptionLlabel = new Label();
            CustomerIDLabel = new Label();
            TitleTextBox = new TextBox();
            DescriptionRichTextBox = new RichTextBox();
            CustomerIDTextBox = new TextBox();
            TitleErrorLabel = new Label();
            DescriptionErrorLabel = new Label();
            CustomerIDErrorLabel = new Label();
            AddButton = new Button();
            CancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8849564F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.11504F));
            tableLayoutPanel1.Controls.Add(TitleErrorLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(TitleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(TitleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(CustomerIDLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(CustomerIDTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(DescriptionRichTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(DescriptionLlabel, 0, 2);
            tableLayoutPanel1.Controls.Add(DescriptionErrorLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(CustomerIDErrorLabel, 1, 5);
            tableLayoutPanel1.Location = new Point(46, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(452, 315);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title:";
            // 
            // DescriptionLlabel
            // 
            DescriptionLlabel.AutoSize = true;
            DescriptionLlabel.Location = new Point(3, 74);
            DescriptionLlabel.Name = "DescriptionLlabel";
            DescriptionLlabel.Size = new Size(88, 20);
            DescriptionLlabel.TabIndex = 1;
            DescriptionLlabel.Text = "Description:";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Location = new Point(3, 240);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(94, 20);
            CustomerIDLabel.TabIndex = 2;
            CustomerIDLabel.Text = "Customer ID:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(120, 3);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(329, 27);
            TitleTextBox.TabIndex = 3;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(120, 77);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(329, 125);
            DescriptionRichTextBox.TabIndex = 4;
            DescriptionRichTextBox.Text = "";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(120, 243);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(329, 27);
            CustomerIDTextBox.TabIndex = 5;
            // 
            // TitleErrorLabel
            // 
            TitleErrorLabel.Location = new Point(120, 44);
            TitleErrorLabel.Name = "TitleErrorLabel";
            TitleErrorLabel.Size = new Size(329, 25);
            TitleErrorLabel.TabIndex = 1;
            // 
            // DescriptionErrorLabel
            // 
            DescriptionErrorLabel.Location = new Point(120, 205);
            DescriptionErrorLabel.Name = "DescriptionErrorLabel";
            DescriptionErrorLabel.Size = new Size(329, 25);
            DescriptionErrorLabel.TabIndex = 6;
            // 
            // CustomerIDErrorLabel
            // 
            CustomerIDErrorLabel.Location = new Point(120, 273);
            CustomerIDErrorLabel.Name = "CustomerIDErrorLabel";
            CustomerIDErrorLabel.Size = new Size(329, 25);
            CustomerIDErrorLabel.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(109, 389);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(137, 29);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add Incident";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(295, 389);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(137, 29);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // IncidentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 439);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(tableLayoutPanel1);
            Name = "IncidentForm";
            Text = "IncidentForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label TitleLabel;
        private Label DescriptionLlabel;
        private Label CustomerIDLabel;
        private TextBox TitleTextBox;
        private TextBox CustomerIDTextBox;
        private RichTextBox DescriptionRichTextBox;
        private Label TitleErrorLabel;
        private Label DescriptionErrorLabel;
        private Label CustomerIDErrorLabel;
        private Button AddButton;
        private Button CancelButton;
    }
}