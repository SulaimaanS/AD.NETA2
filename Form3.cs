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
        string User, UserType, CurrentFile;

        public TextEditorWindow(LoginWindow loginWindow, string name, string userType) {
            InitializeComponent();
            this.loginWindow = loginWindow;
            this.User = name;
            this.UserType = userType;
        }

        private void openFile() {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Open File";
            OpenFile.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*";
            DialogResult result = OpenFile.ShowDialog();
            if (result == DialogResult.OK) {
                CurrentFile = File.ReadAllText(OpenFile.FileName); //Reads the text from file  
                RTBTextEditor.Text = CurrentFile; //Shows the reded text in the textbox  
            }
           /*else if(result == DialogResult.Cancel) {
                OpenFile.1
            }*/
            
        }

        private void saveFile() {
            SaveFileDialog SaveFile = new SaveFileDialog();
            DialogResult result = SaveFile.ShowDialog(); //Opens the Show File Dialog  
            if (result == DialogResult.OK) //Check if it's all ok  
            {
                string fileName = SaveFile.FileName + ".txt"; //Just to make sure the extension is .txt  
                File.WriteAllText(fileName, RTBTextEditor.Text); //Writes the text to the file and saves it               
            }
        }

        private void setFont() {
            FontDialog setFont = new FontDialog();
            DialogResult result = setFont.ShowDialog(); //Shows the font dialog   
            if (result == DialogResult.OK) {
                RTBTextEditor.Font = setFont.Font; //Sets the font to the one selected in the dialog  
            }
        }


        private void Form3_Load(object sender, EventArgs e) {
            TSUsername.Text = $"Current User: {User}";
            if (UserType == "View") {
                FileMenuStrip.Enabled = false;
                /*saveMenuStripItem.Enabled = false;
                saveAsMenuStripItem.Enabled = false;
                editMenuStripTab.Enabled = false;
                fontMenuStripTab.Enabled = false;*/
                RTBTextEditor.Enabled = false;
                ToolStripTop.Enabled = false;
                ToolStripLeft.Enabled = false;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e) {
            openFile();
        }

        private void TSOpenFileButton_Click(object sender, EventArgs e) {
            openFile();
        }

        private void RTBTextEditor_TextChanged(object sender, EventArgs e) {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFile();
        }

        private void TSSaveButton_Click(object sender, EventArgs e) {
            saveFile();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {
            setFont();
        }
    }
}
