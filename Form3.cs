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
            string FileType = Path.GetExtension(CurrentFile);
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Open File";
            OpenFile.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*";
            DialogResult result = OpenFile.ShowDialog();
            if (result == DialogResult.OK) {
                CurrentFile = File.ReadAllText(OpenFile.FileName); //Reads the text from file  
                Text = CurrentFile; //Shows the read text in the textbox\
                if (FileType == ".rtf") {
                    RTBTextEditor.LoadFile(CurrentFile, RichTextBoxStreamType.RichText);
                }
                else if (FileType == ".txt") {
                    RTBTextEditor.LoadFile(CurrentFile, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void saveFile() {
            string FileType = Path.GetExtension(CurrentFile);
            while (string.IsNullOrEmpty(CurrentFile)) {
                SaveFileDialog SaveFile = new SaveFileDialog();
                DialogResult result = SaveFile.ShowDialog();
                if (result == DialogResult.OK) {
                    if (FileType == ".rtf") {
                        File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
                    }
                    else if (FileType == ".txt") {
                        File.WriteAllText(CurrentFile, RTBTextEditor.Text);
                    }
                }
            }
            if (FileType == ".rtf") {
                File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
            }
            else if (FileType == ".txt") {
                File.WriteAllText(CurrentFile, RTBTextEditor.Text);
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
