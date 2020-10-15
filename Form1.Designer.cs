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
            this.LoginBox.Location = new System.Drawing.Point(12, 31);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(501, 126);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            // 
            // LoginPasswordField
            // 
            this.LoginPasswordField.Location = new System.Drawing.Point(124, 94);
            this.LoginPasswordField.Name = "LoginPasswordField";
            this.LoginPasswordField.Size = new System.Drawing.Size(191, 20);
            this.LoginPasswordField.TabIndex = 5;
            this.LoginPasswordField.UseSystemPasswordChar = true;
            // 
            // LoginUserField
            // 
            this.LoginUserField.Location = new System.Drawing.Point(124, 43);
            this.LoginUserField.Name = "LoginUserField";
            this.LoginUserField.Size = new System.Drawing.Size(191, 20);
            this.LoginUserField.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(28, 101);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(28, 50);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(171, 9);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(156, 13);
            this.LoginText.TabIndex = 1;
            this.LoginText.Text = "Please Enter Your Login Details";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(43, 231);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(104, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.Location = new System.Drawing.Point(208, 231);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(104, 23);
            this.NewAccountButton.TabIndex = 7;
            this.NewAccountButton.Text = "New Account";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(369, 231);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 305);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewAccountButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.LoginBox);
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

