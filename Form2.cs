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

namespace AD.NETA2 { //TODO: Flesh out a better validation system to check if all input fields are complete and check for conflicting usernames
    public partial class NewAccountWindow : Form {
        public NewAccountWindow() {
            InitializeComponent();
        }

        private void newAccount() {
            if (!(NPassInput.Text == ConfirmPassInput.Text)) {
                MessageBox.Show("Please check that your passwords match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string[] UserData = { $"{NUserInput.Text},{NPassInput.Text},{NCBUserType.Text},{FNameInput.Text},{LNameInput.Text},{NDatePicker.Value.ToString("dd-MM-yyyy")}" };
                File.AppendAllLines(@"Login.txt", UserData);
                MessageBox.Show("Account Created!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
            this.Close();
        }

    }
}