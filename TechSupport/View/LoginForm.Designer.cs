namespace TechSupport
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserNameLabel = new Label();
            PassWordLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ErrorMessageLabel = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(81, 66);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(82, 20);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "Username: ";
            // 
            // PassWordLabel
            // 
            PassWordLabel.AutoSize = true;
            PassWordLabel.Location = new Point(81, 117);
            PassWordLabel.Name = "PassWordLabel";
            PassWordLabel.Size = new Size(73, 20);
            PassWordLabel.TabIndex = 1;
            PassWordLabel.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(221, 59);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(125, 27);
            UserNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(221, 117);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.Location = new Point(81, 168);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(274, 49);
            ErrorMessageLabel.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(252, 255);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 343);
            Controls.Add(LoginButton);
            Controls.Add(ErrorMessageLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(PassWordLabel);
            Controls.Add(UserNameLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private Label PassWordLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Label ErrorMessageLabel;
        private Button LoginButton;
    }
}
