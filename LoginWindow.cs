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
using System.Drawing.Drawing2D;

namespace AD.NETA2 {
    public partial class LoginWindow : Form {
        private string UserInput, PassInput;

        public LoginWindow() {
            InitializeComponent();
        }

        private void Login() {
            char[] Separators = new char[] { ',' };
            string[] Users = File.ReadAllLines(@"login.txt");   //Store all lines of Login file into array 'Users'
            bool LoginComplete = false; //Flag that is either true or false depending on whether or not the user has successfully logged in or not
            UserInput = LoginUserField.Text;
            PassInput = LoginPasswordField.Text;
            foreach (string user in Users) {    //For each entry in the array of users
                string[] Login = user.Split(Separators, StringSplitOptions.RemoveEmptyEntries); //Split the entry by the delimiters
                if ((UserInput == Login[0]) && (PassInput == Login[1])) { //Check if the values input are correct for any of the user details

                    MessageBox.Show("Login Successful!", "Successful Login");
                    LoginComplete = true;
                    Hide();
                    new TextEditorWindow(this, Login[0], Login[2]).Show();
                    break;
                }
            }
            if (!LoginComplete) { //If the login was unsuccessful, display this message
                DialogResult YesOrNo = MessageBox.Show("Incorrect Credentials!", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void LoginButton_Click(object sender, EventArgs e) {
            Login();
        }

        private void NewAccountButton_Click(object sender, EventArgs e) {
            Hide();
            new NewAccountWindow(this).Show();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
