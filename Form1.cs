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
        public LoginWindow() {
            InitializeComponent();
        }

        private string UserInput, PassInput;
        NewAccountWindow AccountForm = new NewAccountWindow();
        TextEditorWindow TextEditor = new TextEditorWindow();

        private void Login() {
            string[] charSeparators = new string[] { "," };
            string[] Users = File.ReadAllLines(@"login.txt");
            bool LoginComplete = false;
            UserInput = LoginUserField.Text;
            PassInput = LoginPasswordField.Text;
            do {
                foreach (string user in Users) {

                    string[] Login = user.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                    if (UserInput == Login[0] && PassInput == Login[1]) {

                        MessageBox.Show("Login Successful!", "Successful Login");
                        LoginComplete = true;
                        Hide();
                        TextEditor.Show();
                        break;

                    }
                }
            }

            while (!LoginComplete);
            if (!LoginComplete) {
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
            Login();
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
            Close();
        }
    }
}
