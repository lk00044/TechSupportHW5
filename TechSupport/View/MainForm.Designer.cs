namespace TechSupport.View
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
            DisplayUserNameLabel = new Label();
            LogoutLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // DisplayUserNameLabel
            // 
            DisplayUserNameLabel.Location = new Point(182, 25);
            DisplayUserNameLabel.Name = "DisplayUserNameLabel";
            DisplayUserNameLabel.Size = new Size(315, 38);
            DisplayUserNameLabel.TabIndex = 0;
            // 
            // LogoutLinkLabel
            // 
            LogoutLinkLabel.AutoSize = true;
            LogoutLinkLabel.Location = new Point(421, 87);
            LogoutLinkLabel.Name = "LogoutLinkLabel";
            LogoutLinkLabel.Size = new Size(56, 20);
            LogoutLinkLabel.TabIndex = 1;
            LogoutLinkLabel.TabStop = true;
            LogoutLinkLabel.Text = "Logout";
            LogoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 299);
            Controls.Add(LogoutLinkLabel);
            Controls.Add(DisplayUserNameLabel);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DisplayUserNameLabel;
        private LinkLabel LogoutLinkLabel;
    }
}