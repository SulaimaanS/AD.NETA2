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

namespace AD.NETA2 { //TODO: Login function to check for multiple accounts that match input - probably have to loop through an array or smth
                     // Yoink it from A1
    public partial class LoginWindow : Form {
        public LoginWindow() {
            InitializeComponent();
        }

        private string UserInput, PassInput;
        NewAccountWindow AccountForm = new NewAccountWindow();
        TextEditorWindow TextEditor = new TextEditorWindow();

        private void storeUsers() {
            //Use this to store users in an array and then feed that into login and split for index 0 and 1

        }

        private void Login() {
            bool LoginComplete = false;
            string[] Users = File.ReadAllLines(@"login.txt"); //Store all user details in an array
            UserInput = LoginUserField.Text;
            PassInput = LoginPasswordField.Text;
            while (!LoginComplete) {

                for (int loop = 0; loop < Users.Length; loop++) {

                    string[] Login = new string[];
                    Users[loop].Split(Login,StringSplitOptions.None);
                }
                if (UserInput == Login[0] && PassInput == Login[1]) {

                    MessageBox.Show("Login Successful!", "Successful Login");
                    TextEditor.Show();
                    LoginComplete = true;
                }
            }

            DialogResult YesOrNo = MessageBox.Show("We couldn't find an account with these credentials!\nWould you like to create an account?", "Failed Login", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes) {
                if (AccountForm.IsDisposed) {
                    NewAccountWindow AccountForm = new NewAccountWindow();
                    AccountForm.Show();
                }
                else {
                    AccountForm.Show();
                }
            }

        }



        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void LoginButton_Click(object sender, EventArgs e) {
            Login();
            //storeUsers();
        }

        private void NewAccountButton_Click(object sender, EventArgs e) {
            if (AccountForm.IsDisposed) {
                NewAccountWindow AccountForm = new NewAccountWindow();
                AccountForm.Show();
            }
            else {
                AccountForm.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
