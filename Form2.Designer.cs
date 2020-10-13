namespace AD.NETA2 {
    partial class NewAccountWindow {
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
            this.NewAccountLabel = new System.Windows.Forms.Label();
            this.NewUsernameLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ReEnterPasswordLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.NewUserBox = new System.Windows.Forms.GroupBox();
            this.NCBUserType = new System.Windows.Forms.ComboBox();
            this.NDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FNameInput = new System.Windows.Forms.TextBox();
            this.LNameInput = new System.Windows.Forms.TextBox();
            this.NPassInput = new System.Windows.Forms.TextBox();
            this.ConfirmPassInput = new System.Windows.Forms.TextBox();
            this.NUserInput = new System.Windows.Forms.TextBox();
            this.NewAccSubButton = new System.Windows.Forms.Button();
            this.NewAccCancelButton = new System.Windows.Forms.Button();
            this.NewUserBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewAccountLabel
            // 
            this.NewAccountLabel.AutoSize = true;
            this.NewAccountLabel.Location = new System.Drawing.Point(322, 14);
            this.NewAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewAccountLabel.Name = "NewAccountLabel";
            this.NewAccountLabel.Size = new System.Drawing.Size(103, 20);
            this.NewAccountLabel.TabIndex = 0;
            this.NewAccountLabel.Text = "New Account";
            // 
            // NewUsernameLabel
            // 
            this.NewUsernameLabel.AutoSize = true;
            this.NewUsernameLabel.Location = new System.Drawing.Point(20, 25);
            this.NewUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewUsernameLabel.Name = "NewUsernameLabel";
            this.NewUsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.NewUsernameLabel.TabIndex = 1;
            this.NewUsernameLabel.Text = "Username:";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(20, 80);
            this.NewPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "Password:";
            // 
            // ReEnterPasswordLabel
            // 
            this.ReEnterPasswordLabel.AutoSize = true;
            this.ReEnterPasswordLabel.Location = new System.Drawing.Point(20, 155);
            this.ReEnterPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReEnterPasswordLabel.Name = "ReEnterPasswordLabel";
            this.ReEnterPasswordLabel.Size = new System.Drawing.Size(149, 20);
            this.ReEnterPasswordLabel.TabIndex = 3;
            this.ReEnterPasswordLabel.Text = "Re-enter Password:";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(420, 25);
            this.FNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FNameLabel.TabIndex = 4;
            this.FNameLabel.Text = "First Name:";
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(20, 228);
            this.UserTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.UserTypeLabel.TabIndex = 5;
            this.UserTypeLabel.Text = "User-Type";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(420, 80);
            this.LNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LNameLabel.TabIndex = 6;
            this.LNameLabel.Text = "Last Name:";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(304, 228);
            this.DOBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(103, 20);
            this.DOBLabel.TabIndex = 7;
            this.DOBLabel.Text = "Date of Birth:";
            // 
            // NewUserBox
            // 
            this.NewUserBox.Controls.Add(this.NCBUserType);
            this.NewUserBox.Controls.Add(this.NDatePicker);
            this.NewUserBox.Controls.Add(this.FNameInput);
            this.NewUserBox.Controls.Add(this.LNameInput);
            this.NewUserBox.Controls.Add(this.NPassInput);
            this.NewUserBox.Controls.Add(this.ConfirmPassInput);
            this.NewUserBox.Controls.Add(this.NUserInput);
            this.NewUserBox.Controls.Add(this.DOBLabel);
            this.NewUserBox.Controls.Add(this.LNameLabel);
            this.NewUserBox.Controls.Add(this.UserTypeLabel);
            this.NewUserBox.Controls.Add(this.FNameLabel);
            this.NewUserBox.Controls.Add(this.ReEnterPasswordLabel);
            this.NewUserBox.Controls.Add(this.NewPasswordLabel);
            this.NewUserBox.Controls.Add(this.NewUsernameLabel);
            this.NewUserBox.Location = new System.Drawing.Point(18, 66);
            this.NewUserBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewUserBox.Name = "NewUserBox";
            this.NewUserBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewUserBox.Size = new System.Drawing.Size(750, 278);
            this.NewUserBox.TabIndex = 8;
            this.NewUserBox.TabStop = false;
            this.NewUserBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NCBUserType
            // 
            this.NCBUserType.FormattingEnabled = true;
            this.NCBUserType.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.NCBUserType.Location = new System.Drawing.Point(112, 217);
            this.NCBUserType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NCBUserType.Name = "NCBUserType";
            this.NCBUserType.Size = new System.Drawing.Size(115, 28);
            this.NCBUserType.TabIndex = 16;
            // 
            // NDatePicker
            // 
            this.NDatePicker.CustomFormat = "dd-MM-yyyy";
            this.NDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NDatePicker.Location = new System.Drawing.Point(417, 218);
            this.NDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NDatePicker.MaxDate = new System.DateTime(2020, 10, 7, 21, 51, 42, 0);
            this.NDatePicker.Name = "NDatePicker";
            this.NDatePicker.Size = new System.Drawing.Size(298, 26);
            this.NDatePicker.TabIndex = 15;
            this.NDatePicker.Value = new System.DateTime(2020, 10, 7, 0, 0, 0, 0);
            // 
            // FNameInput
            // 
            this.FNameInput.Location = new System.Drawing.Point(538, 20);
            this.FNameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FNameInput.Name = "FNameInput";
            this.FNameInput.Size = new System.Drawing.Size(148, 26);
            this.FNameInput.TabIndex = 14;
            // 
            // LNameInput
            // 
            this.LNameInput.Location = new System.Drawing.Point(538, 80);
            this.LNameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LNameInput.Name = "LNameInput";
            this.LNameInput.Size = new System.Drawing.Size(148, 26);
            this.LNameInput.TabIndex = 13;
            // 
            // NPassInput
            // 
            this.NPassInput.Location = new System.Drawing.Point(180, 80);
            this.NPassInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NPassInput.Name = "NPassInput";
            this.NPassInput.Size = new System.Drawing.Size(148, 26);
            this.NPassInput.TabIndex = 11;
            this.NPassInput.UseSystemPasswordChar = true;
            // 
            // ConfirmPassInput
            // 
            this.ConfirmPassInput.Location = new System.Drawing.Point(180, 151);
            this.ConfirmPassInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmPassInput.Name = "ConfirmPassInput";
            this.ConfirmPassInput.Size = new System.Drawing.Size(148, 26);
            this.ConfirmPassInput.TabIndex = 10;
            this.ConfirmPassInput.UseSystemPasswordChar = true;
            // 
            // NUserInput
            // 
            this.NUserInput.Location = new System.Drawing.Point(180, 12);
            this.NUserInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUserInput.Name = "NUserInput";
            this.NUserInput.Size = new System.Drawing.Size(148, 26);
            this.NUserInput.TabIndex = 8;
            // 
            // NewAccSubButton
            // 
            this.NewAccSubButton.Location = new System.Drawing.Point(104, 380);
            this.NewAccSubButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewAccSubButton.Name = "NewAccSubButton";
            this.NewAccSubButton.Size = new System.Drawing.Size(144, 35);
            this.NewAccSubButton.TabIndex = 9;
            this.NewAccSubButton.Text = "Submit";
            this.NewAccSubButton.UseVisualStyleBackColor = true;
            this.NewAccSubButton.Click += new System.EventHandler(this.NewAccSubButton_Click);
            // 
            // NewAccCancelButton
            // 
            this.NewAccCancelButton.Location = new System.Drawing.Point(525, 380);
            this.NewAccCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewAccCancelButton.Name = "NewAccCancelButton";
            this.NewAccCancelButton.Size = new System.Drawing.Size(144, 35);
            this.NewAccCancelButton.TabIndex = 10;
            this.NewAccCancelButton.Text = "Cancel";
            this.NewAccCancelButton.UseVisualStyleBackColor = true;
            this.NewAccCancelButton.Click += new System.EventHandler(this.NewAccCancelButton_Click);
            // 
            // NewAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 452);
            this.Controls.Add(this.NewAccCancelButton);
            this.Controls.Add(this.NewAccSubButton);
            this.Controls.Add(this.NewUserBox);
            this.Controls.Add(this.NewAccountLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewAccountWindow";
            this.Text = "Create a New Account";
            this.Load += new System.EventHandler(this.NewAccountForm_Load);
            this.NewUserBox.ResumeLayout(false);
            this.NewUserBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewAccountLabel;
        private System.Windows.Forms.Label NewUsernameLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label ReEnterPasswordLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.GroupBox NewUserBox;
        private System.Windows.Forms.Button NewAccSubButton;
        private System.Windows.Forms.Button NewAccCancelButton;
        private System.Windows.Forms.TextBox FNameInput;
        private System.Windows.Forms.TextBox LNameInput;
        private System.Windows.Forms.TextBox NPassInput;
        private System.Windows.Forms.TextBox ConfirmPassInput;
        private System.Windows.Forms.TextBox NUserInput;
        private System.Windows.Forms.DateTimePicker NDatePicker;
        private System.Windows.Forms.ComboBox NCBUserType;
    }
}