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
    public partial class TextEditorWindow : Form {
        LoginWindow loginWindow;
        public TextEditorWindow(LoginWindow loginWindow) {
            InitializeComponent();
            this.loginWindow = loginWindow;
        }

        private void openFile() {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Open File";
            OpenFile.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*";
            DialogResult result = OpenFile.ShowDialog();
            if(result == DialogResult.OK) {
                string fileName = OpenFile.FileName;
            }
        }

        private void Form3_Load(object sender, EventArgs e) {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e) {
            openFile();
        }
    }
}
