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
            NDatePicker.MaxDate = DateTime.Today;
            NDatePicker.Format = DateTimePickerFormat.Custom;
        }

        private bool accountExists(string Input) {  //Store all lines of Login file into array 'Users' and checks 
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

        private void newAccount() { //Creates a new account by putting input values into their respective fields and appending the Login file
            if (string.IsNullOrEmpty(NUserInput.Text)) {    //Checks if username field is empty
                if (accountExists(NUserInput.Text)) {   //Checks if the username provided already exists
                    MessageBox.Show("An account with this username already exists!", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Username cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(NPassInput.Text)) {   //Checks if password field is empty
                MessageBox.Show("Password cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(ConfirmPassInput.Text)) { //Checks if confirm password field is empty
                MessageBox.Show("Confirm password cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(FNameInput.Text)) {   //Checks if first name field is empty
                MessageBox.Show("First name cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(LNameInput.Text)) {   //Checks if last name field is empty
                MessageBox.Show("Last name cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (NCBUserType.SelectedIndex == -1) { //Checks if the user type field is empty
                MessageBox.Show("User type cannot be empty", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ConfirmPassInput.Text != NPassInput.Text) { //Checks if both passwords provided are the same
                MessageBox.Show("Passwords do not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {  //If all checks are completed and there are no errors, append the login file with the new account details and return to login
                NDatePicker.CustomFormat = "dd-MM-yyyy";
                string[] UserData = { $"{NUserInput.Text},{NPassInput.Text},{NCBUserType.Text},{FNameInput.Text},{LNameInput.Text},{NDatePicker.Text}" };
                File.AppendAllLines(@"Login.txt", UserData);
                MessageBox.Show("Account Created!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                loginWindow.Show();
            }
        }

        private void NewAccountForm_Load(object sender, EventArgs e) {

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