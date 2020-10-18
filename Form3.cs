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
            OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFile.FilterIndex = 2;
            OpenFile.RestoreDirectory = true;

            DialogResult result = OpenFile.ShowDialog();
            if (result == DialogResult.OK) {
                CurrentFile = OpenFile.FileName; //Reads the text from file
                string FileType = Path.GetExtension(CurrentFile);
                RTBTextEditor.LoadFile(CurrentFile, RichTextBoxStreamType.RichText);
            }
        }

        private void saveFile() {
            if (string.IsNullOrEmpty(CurrentFile)) {
                SaveFileDialog SaveFile = new SaveFileDialog();
                DialogResult result = SaveFile.ShowDialog();
                CurrentFile = SaveFile.FileName;
                if (result == DialogResult.OK) {
                    File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
                }
            }
            else {
                File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
            }
        }

        private void saveAs() {
            string FileType = Path.GetExtension(CurrentFile);
            SaveFileDialog SaveFile = new SaveFileDialog();

            SaveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFile.FilterIndex = 2;
            SaveFile.RestoreDirectory = true;

            DialogResult result = SaveFile.ShowDialog();
            SaveFile.Filter = "Rich Text Format file (*.rtf)|*.rtf|";
            if (result == DialogResult.OK) {
                File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
            }
        }

        private void newFile() {
            CurrentFile = string.Empty;
            Text = "Text editor";
            RTBTextEditor.Text = string.Empty;
        }

        private void setFontSize() {
            Font fileFont = RTBTextEditor.SelectionFont;
            for (int i = 8; i <= 20; i++) {
                if (Convert.ToInt32(TSFontSize.SelectedItem.ToString()) == i) {
                    RTBTextEditor.SelectionFont = new Font(fileFont.FontFamily, i, fileFont.Style);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e) {
            TSUsername.Text = $"Current User: {User}";
            if (UserType == "View") {
                newToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;

                TSNewFileButton.Enabled = false;
                TSSaveAsButton.Enabled = false;
                TSSaveButton.Enabled = false;
                TSFontSize.Enabled = false;

                RTBTextEditor.Enabled = false;
                ToolStripLeft.Enabled = false;
            }
        }

        private void about() {
            MessageBox.Show("C# Text Editor v1.0\nAuthor: Sulaimaan Sharif", "About",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            newFile();
        }
        private void TSNewFileButton_Click(object sender, EventArgs e) {
            newFile();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e) {
            openFile();
        }

        private void TSOpenFileButton_Click(object sender, EventArgs e) {
            openFile();
        }

        private void TSSaveButton_Click(object sender, EventArgs e) {
            saveFile();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFile();
        }

        private void TSSaveAsButton_Click(object sender, EventArgs e) {
            saveAs();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveAs();
        }

        private void TSBoldButton_Click(object sender, EventArgs e) {
            RTBTextEditor.SelectionFont = new Font(RTBTextEditor.SelectionFont, FontStyle.Bold ^ RTBTextEditor.SelectionFont.Style);
        }

        private void TSItalicButton_Click(object sender, EventArgs e) {
            RTBTextEditor.SelectionFont = new Font(RTBTextEditor.SelectionFont, FontStyle.Italic ^ RTBTextEditor.SelectionFont.Style);
        }
        private void TSUnderlineButton_Click(object sender, EventArgs e) {
            RTBTextEditor.SelectionFont = new Font(RTBTextEditor.SelectionFont, FontStyle.Underline ^ RTBTextEditor.SelectionFont.Style);
        }

        private void TSFontSize_SelectedIndexChanged(object sender, EventArgs e) {
            setFontSize();
        }

        private void TSCopyButton_Click(object sender, EventArgs e) {
            if (RTBTextEditor.SelectionLength > 0) {
                RTBTextEditor.Copy();
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (RTBTextEditor.SelectionLength > 0) {
                RTBTextEditor.Copy();
            }
        }

        private void TSPasteButton_Click(object sender, EventArgs e) {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) {
                // Determine if any text is selected in the text box.
                if (RTBTextEditor.SelectionLength > 0) {
                    // Move selection to the point after the current selection and paste.
                    RTBTextEditor.SelectionStart = RTBTextEditor.SelectionStart + RTBTextEditor.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                RTBTextEditor.Paste();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) {
                if (RTBTextEditor.SelectionLength > 0) {
                    RTBTextEditor.SelectionStart = RTBTextEditor.SelectionStart + RTBTextEditor.SelectionLength;
                }
                RTBTextEditor.Paste();
            }
        }

        private void TSCutButton_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(RTBTextEditor.SelectedText)) {
                RTBTextEditor.Cut();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            about();

        }

        private void TSInfoButton_Click(object sender, EventArgs e) {
            //about();
            setFontSize();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(RTBTextEditor.SelectedText)) {
                RTBTextEditor.Cut();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
            loginWindow.Show();
        }
    }
}
