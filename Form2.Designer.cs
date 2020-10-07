namespace AD.NETA2 {
    partial class NewAccountForm {
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
            this.NewAccountLabel.Location = new System.Drawing.Point(215, 9);
            this.NewAccountLabel.Name = "NewAccountLabel";
            this.NewAccountLabel.Size = new System.Drawing.Size(72, 13);
            this.NewAccountLabel.TabIndex = 0;
            this.NewAccountLabel.Text = "New Account";
            // 
            // NewUsernameLabel
            // 
            this.NewUsernameLabel.AutoSize = true;
            this.NewUsernameLabel.Location = new System.Drawing.Point(13, 16);
            this.NewUsernameLabel.Name = "NewUsernameLabel";
            this.NewUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.NewUsernameLabel.TabIndex = 1;
            this.NewUsernameLabel.Text = "Username:";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(13, 52);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "Password:";
            // 
            // ReEnterPasswordLabel
            // 
            this.ReEnterPasswordLabel.AutoSize = true;
            this.ReEnterPasswordLabel.Location = new System.Drawing.Point(13, 101);
            this.ReEnterPasswordLabel.Name = "ReEnterPasswordLabel";
            this.ReEnterPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.ReEnterPasswordLabel.TabIndex = 3;
            this.ReEnterPasswordLabel.Text = "Re-enter Password:";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(280, 16);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FNameLabel.TabIndex = 4;
            this.FNameLabel.Text = "First Name:";
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(13, 148);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.UserTypeLabel.TabIndex = 5;
            this.UserTypeLabel.Text = "User-Type";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(280, 52);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LNameLabel.TabIndex = 6;
            this.LNameLabel.Text = "Last Name:";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(203, 148);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(69, 13);
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
            this.NewUserBox.Location = new System.Drawing.Point(12, 43);
            this.NewUserBox.Name = "NewUserBox";
            this.NewUserBox.Size = new System.Drawing.Size(500, 181);
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
            this.NCBUserType.Location = new System.Drawing.Point(75, 141);
            this.NCBUserType.Name = "NCBUserType";
            this.NCBUserType.Size = new System.Drawing.Size(78, 21);
            this.NCBUserType.TabIndex = 16;
            // 
            // NDatePicker
            // 
            this.NDatePicker.CustomFormat = "dd-MM-yyyy";
            this.NDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NDatePicker.Location = new System.Drawing.Point(278, 142);
            this.NDatePicker.MaxDate = new System.DateTime(2020, 10, 7, 21, 51, 42, 0);
            this.NDatePicker.Name = "NDatePicker";
            this.NDatePicker.Size = new System.Drawing.Size(200, 20);
            this.NDatePicker.TabIndex = 15;
            this.NDatePicker.Value = new System.DateTime(2020, 10, 7, 0, 0, 0, 0);
            // 
            // FNameInput
            // 
            this.FNameInput.Location = new System.Drawing.Point(359, 13);
            this.FNameInput.Name = "FNameInput";
            this.FNameInput.Size = new System.Drawing.Size(100, 20);
            this.FNameInput.TabIndex = 14;
            // 
            // LNameInput
            // 
            this.LNameInput.Location = new System.Drawing.Point(359, 52);
            this.LNameInput.Name = "LNameInput";
            this.LNameInput.Size = new System.Drawing.Size(100, 20);
            this.LNameInput.TabIndex = 13;
            // 
            // NPassInput
            // 
            this.NPassInput.Location = new System.Drawing.Point(120, 52);
            this.NPassInput.Name = "NPassInput";
            this.NPassInput.Size = new System.Drawing.Size(100, 20);
            this.NPassInput.TabIndex = 11;
            this.NPassInput.UseSystemPasswordChar = true;
            // 
            // ConfirmPassInput
            // 
            this.ConfirmPassInput.Location = new System.Drawing.Point(120, 98);
            this.ConfirmPassInput.Name = "ConfirmPassInput";
            this.ConfirmPassInput.Size = new System.Drawing.Size(100, 20);
            this.ConfirmPassInput.TabIndex = 10;
            this.ConfirmPassInput.UseSystemPasswordChar = true;
            // 
            // NUserInput
            // 
            this.NUserInput.Location = new System.Drawing.Point(120, 8);
            this.NUserInput.Name = "NUserInput";
            this.NUserInput.Size = new System.Drawing.Size(100, 20);
            this.NUserInput.TabIndex = 8;
            // 
            // NewAccSubButton
            // 
            this.NewAccSubButton.Location = new System.Drawing.Point(69, 247);
            this.NewAccSubButton.Name = "NewAccSubButton";
            this.NewAccSubButton.Size = new System.Drawing.Size(96, 23);
            this.NewAccSubButton.TabIndex = 9;
            this.NewAccSubButton.Text = "Submit";
            this.NewAccSubButton.UseVisualStyleBackColor = true;
            this.NewAccSubButton.Click += new System.EventHandler(this.NewAccSubButton_Click);
            // 
            // NewAccCancelButton
            // 
            this.NewAccCancelButton.Location = new System.Drawing.Point(350, 247);
            this.NewAccCancelButton.Name = "NewAccCancelButton";
            this.NewAccCancelButton.Size = new System.Drawing.Size(96, 23);
            this.NewAccCancelButton.TabIndex = 10;
            this.NewAccCancelButton.Text = "Cancel";
            this.NewAccCancelButton.UseVisualStyleBackColor = true;
            this.NewAccCancelButton.Click += new System.EventHandler(this.NewAccCancelButton_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 294);
            this.Controls.Add(this.NewAccCancelButton);
            this.Controls.Add(this.NewAccSubButton);
            this.Controls.Add(this.NewUserBox);
            this.Controls.Add(this.NewAccountLabel);
            this.Name = "NewAccountForm";
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