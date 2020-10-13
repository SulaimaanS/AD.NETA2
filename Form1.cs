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

        private string username, password;
        NewAccountWindow AccountForm = new NewAccountWindow();
        TextEditorWindow TextEditor = new TextEditorWindow();

        private void storeUsers() {
            string[] Users = File.ReadAllLines(@"login.txt");
            //Use this to store users in an array and then feed that into login and split for index 0 and 1

        }

        private void Login() {
            username = LoginUserField.Text;
            password = LoginPasswordField.Text;
            string[] Logins = File.ReadAllText(@"login.txt").Split(',');
            if (username == Logins[0] && password == Logins[1]) {
                MessageBox.Show("Login Successful!", "Successful Login");
                TextEditor.Show();
            }
            else {
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
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void LoginButton_Click(object sender, EventArgs e) {
            //Login();
            storeUsers();
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
