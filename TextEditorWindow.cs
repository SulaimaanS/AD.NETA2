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
        bool saved = true;  //Variable that acts as a flad for determining whether or not there are unsaved changes

        public TextEditorWindow(LoginWindow loginWindow, string name, string userType) {
            InitializeComponent();
            this.loginWindow = loginWindow;
            this.User = name;
            this.UserType = userType;
            RTBTextEditor.EnableContextMenu();  //Enables the context menu for editing in the richtextbox
        }

        private void Form3_Load(object sender, EventArgs e) {   //Initial load of the window checks the user type and disables items accordingly
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

        private void openFile() {   //Creates an openfile dialog box and loads the selected file into the richtextbox
            OpenFileDialog OpenFile = new OpenFileDialog();
            //Setting all properties for the openfile dialog
            OpenFile.Title = "Open File";
            OpenFile.RestoreDirectory = true;
            OpenFile.Filter = "RichText Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFile.FilterIndex = 1;

            DialogResult result = OpenFile.ShowDialog();
            if (result == DialogResult.OK) {
                saved = true;
                CurrentFile = OpenFile.FileName;    //Gets the name and path of the file that's selected in the dialog
                RTBTextEditor.LoadFile(CurrentFile, RichTextBoxStreamType.RichText);    //Loads file into the richtextbox
            }
        }

        private void saveFile() {
            if (string.IsNullOrEmpty(RTBTextEditor.Text)) { //Will not allow save to be performed if there's no content in the richtextbox
                MessageBox.Show("File contents cannot be empty", "  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((string.IsNullOrEmpty(CurrentFile))) {
                SaveFileDialog SaveFile = new SaveFileDialog();

                SaveFile.Title = "Save File";
                SaveFile.RestoreDirectory = true;
                SaveFile.Filter = "RichText Files (*.rtf)|*.rtf";
                SaveFile.FilterIndex = 1;
                DialogResult result = SaveFile.ShowDialog();
                if (result == DialogResult.OK) {
                    saved = true;   //Set saved to true to indicate all changes have been saved
                    CurrentFile = SaveFile.FileName;
                    File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
                }
            }
            else {  //If the current file already exists, save it without needing a savefile dialog
                saved = true;
                File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
            }
        }

        private void saveAs() { //Save function as save but will always create a savefile dialog
            SaveFileDialog SaveFile = new SaveFileDialog();

            SaveFile.Title = "Save File";
            SaveFile.RestoreDirectory = true;
            SaveFile.Filter = "RichText Files (*.rtf)|*.rtf";
            SaveFile.FilterIndex = 1;

            DialogResult result = SaveFile.ShowDialog();
            if (result == DialogResult.OK) {
                saved = true;
                CurrentFile = SaveFile.FileName;
                File.WriteAllText(CurrentFile, RTBTextEditor.Rtf);
            }
        }

        private void newFile() {    //Clears the richtextbox to begine writing to a new file
            if (saved) {
                CurrentFile = string.Empty;
                RTBTextEditor.Text = string.Empty;
            }
            else {  //Alerts the user that there are unsaved changes
                DialogResult result = MessageBox.Show("Unsaved changes! Would you like to save your changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) {   //Save the changes before clearing the richtextbox
                    saveFile();
                    CurrentFile = string.Empty;
                    RTBTextEditor.Text = string.Empty;
                }
                else if (result == DialogResult.No) {   //Do not save the changes before clearing the richtextbox
                    CurrentFile = string.Empty;
                    RTBTextEditor.Text = string.Empty;
                }
                else if (result == DialogResult.Cancel) {   //Cancel the function and return to what the user was doing before
                    return;
                }
            }
        }

        private void setFontSize() {    //Changes the font size of the selected text
            string SelectedFontName = RTBTextEditor.SelectionFont.Name;
            Font SelectedFont = RTBTextEditor.SelectionFont;
            for (int i = 8; i <= 20; i++) { //Changes the font size of the selected text depending on which value is selected in the combo box
                if (Convert.ToInt32(TSFontSize.SelectedItem.ToString()) == i) {
                    RTBTextEditor.SelectionFont = new Font(SelectedFontName, i, SelectedFont.Style);
                }
            }
        }

        private void copy() {
            if (RTBTextEditor.SelectionLength > 0) {
                RTBTextEditor.Copy();
            }
        }

        private void paste() {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) {
                if (RTBTextEditor.SelectionLength > 0) {    //Move the currently selected text position to the end of the selection
                    RTBTextEditor.SelectionStart = RTBTextEditor.SelectionStart + RTBTextEditor.SelectionLength;
                }
                RTBTextEditor.Paste();
            }
        }

        private void cut() {
            if (!string.IsNullOrEmpty(RTBTextEditor.SelectedText)) { //If the currently selected text isn't empty, cut it from the rich text box
                RTBTextEditor.Cut();
            }
        }

        private void about() {  //Displays information about the program
            MessageBox.Show("C# Text Editor v1.0\nAuthor: Sulaimaan Sharif", "About",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logout() {
            if (saved) {    //Checks if there are any unsaved changes and if there aren't, clear the richtextbox
                Close();
            }
            else {
                DialogResult result = MessageBox.Show("Unsaved changes! Would you like to save your changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) {
                    saveFile();
                    Close();
                }
                else if (result == DialogResult.No) {
                    Close();
                }
                else if (result == DialogResult.Cancel) {
                    return;
                }
            }
            loginWindow.Show();
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

        private void TSBoldButton_Click(object sender, EventArgs e) {   //Applies the bold style to the selected text
            RTBTextEditor.SelectionFont = new Font(RTBTextEditor.SelectionFont, FontStyle.Bold ^ RTBTextEditor.SelectionFont.Style);
        }

        private void TSItalicButton_Click(object sender, EventArgs e) { //Applies the italic style to the selected text
            RTBTextEditor.SelectionFont = new Font(RTBTextEditor.SelectionFont, FontStyle.Italic ^ RTBTextEditor.SelectionFont.Style);
        }
        private void TSUnderlineButton_Click(object sender, EventArgs e) {  //Applies the underline style to the selected text
            RTBTextEditor.SelectionFont = new Font(RTBTextEditor.SelectionFont, FontStyle.Underline ^ RTBTextEditor.SelectionFont.Style);
        }

        private void TSFontSize_SelectedIndexChanged(object sender, EventArgs e) {
            setFontSize();
        }

        private void TSCopyButton_Click(object sender, EventArgs e) {
            copy();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            copy();
        }

        private void TSPasteButton_Click(object sender, EventArgs e) {
            paste();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            paste();
        }

        private void TSCutButton_Click(object sender, EventArgs e) {
            cut();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            cut();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            about();

        }

        private void TSInfoButton_Click(object sender, EventArgs e) {
            about();
        }

        private void RTBTextEditor_MouseDown(object sender, MouseEventArgs e) {

        }
        private void DoNothing(object sender, EventArgs e) {
            return; //Does nothing for the context menu
        }


        private void RTBTextEditor_TextChanged(object sender, EventArgs e) {
            saved = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {    //Close the window and show the login window
            logout();
        }
        private void TSLogoutButton_Click(object sender, EventArgs e) {
            logout();
        }
    }
}
