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
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private string username, password;
        NewAccountForm AccountForm = new NewAccountForm();
        private void Login() {
            username = LoginUserField.Text;
            password = LoginPasswordField.Text;
            string[] Logins = File.ReadAllText(@"login.txt").Split(',');
            if (username == Logins[0] && password == Logins[1]) {
                MessageBox.Show("Login Successful!", "Successful Login");
            }
            else {
                DialogResult YesOrNo = MessageBox.Show("We couldn't find an account with these credentials!\nWould you like to create an account?", "Failed Login", MessageBoxButtons.YesNo);
                if (YesOrNo == DialogResult.Yes && AccountForm.IsDisposed) {
                        NewAccountForm AccountForm = new NewAccountForm();
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
        }

        private void NewAccountButton_Click(object sender, EventArgs e) {
            if (AccountForm.IsDisposed) {
                NewAccountForm AccountForm = new NewAccountForm();
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
