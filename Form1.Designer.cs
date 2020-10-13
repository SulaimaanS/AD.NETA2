namespace AD.NETA2 {
    partial class LoginWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.LoginPasswordField = new System.Windows.Forms.TextBox();
            this.LoginUserField = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NewAccountButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.LoginPasswordField);
            this.LoginBox.Controls.Add(this.LoginUserField);
            this.LoginBox.Controls.Add(this.PasswordLabel);
            this.LoginBox.Controls.Add(this.UsernameLabel);
            this.LoginBox.Location = new System.Drawing.Point(18, 48);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBox.Size = new System.Drawing.Size(752, 194);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            // 
            // LoginPasswordField
            // 
            this.LoginPasswordField.Location = new System.Drawing.Point(186, 145);
            this.LoginPasswordField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPasswordField.Name = "LoginPasswordField";
            this.LoginPasswordField.Size = new System.Drawing.Size(284, 26);
            this.LoginPasswordField.TabIndex = 5;
            this.LoginPasswordField.UseSystemPasswordChar = true;
            // 
            // LoginUserField
            // 
            this.LoginUserField.Location = new System.Drawing.Point(186, 66);
            this.LoginUserField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginUserField.Name = "LoginUserField";
            this.LoginUserField.Size = new System.Drawing.Size(284, 26);
            this.LoginUserField.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(42, 155);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(42, 77);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(256, 14);
            this.LoginText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(234, 20);
            this.LoginText.TabIndex = 1;
            this.LoginText.Text = "Please Enter Your Login Details";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(64, 355);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(156, 35);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.Location = new System.Drawing.Point(312, 355);
            this.NewAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(156, 35);
            this.NewAccountButton.TabIndex = 3;
            this.NewAccountButton.Text = "New Account";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(554, 355);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 35);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 469);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewAccountButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.LoginBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button NewAccountButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox LoginUserField;
        private System.Windows.Forms.TextBox LoginPasswordField;
    }
}

