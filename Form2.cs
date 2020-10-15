using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AD.NETA2 {
    public partial class NewAccountWindow : Form {
        LoginWindow loginWindow;
        public NewAccountWindow(LoginWindow loginWindow) {
            InitializeComponent();
            this.loginWindow = loginWindow;
        }

        private bool accountExists(string Input) {
            string[] Separators = new string[] { "," };
            string[] Users = File.ReadAllLines(@"login.txt");
            bool Exists = false;
            foreach (string user in Users) {
                string[] Login = user.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
                if (Login[0] == Input) {
                    return Exists = true;
                }
            }
            return Exists;
        }

        private void newAccount() {
            if (String.IsNullOrEmpty(NUserInput.Text)) {
                if (accountExists(NUserInput.Text)) {
                    MessageBox.Show("An account with this username already exists!", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Username cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (String.IsNullOrEmpty(NPassInput.Text)) {
                MessageBox.Show("Password cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else if (String.IsNullOrEmpty(ConfirmPassInput.Text)) {
                MessageBox.Show("Confirm password cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (String.IsNullOrEmpty(FNameInput.Text)) {
                MessageBox.Show("First name cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (String.IsNullOrEmpty(LNameInput.Text)) {
                MessageBox.Show("Last name cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (NCBUserType.SelectedIndex == -1) {
                MessageBox.Show("User type cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ConfirmPassInput.Text != NPassInput.Text) {
                MessageBox.Show("Passwords do not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string[] UserData = { $"{NUserInput.Text},{NPassInput.Text},{NCBUserType.Text},{FNameInput.Text},{LNameInput.Text},{NDatePicker.Value.ToString("dd-MM-yyyy")}" };
                File.AppendAllLines(@"Login.txt", UserData);
                MessageBox.Show("Account Created!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void NewAccountForm_Load(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void NewAccSubButton_Click(object sender, EventArgs e) {
            newAccount();
        }

        private void NewAccCancelButton_Click(object sender, EventArgs e) {
            Close();
            loginWindow.Show();
        }

    }
}