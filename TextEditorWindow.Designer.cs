namespace AD.NETA2 {
    partial class TextEditorWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.FileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.TSNewFileButton = new System.Windows.Forms.ToolStripButton();
            this.TSOpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.TSSaveButton = new System.Windows.Forms.ToolStripButton();
            this.TSSaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBoldButton = new System.Windows.Forms.ToolStripButton();
            this.TSItalicButton = new System.Windows.Forms.ToolStripButton();
            this.TSUnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.TSInfoButton = new System.Windows.Forms.ToolStripButton();
            this.TSFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSUsername = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLeft = new System.Windows.Forms.ToolStrip();
            this.TSCopyButton = new System.Windows.Forms.ToolStripButton();
            this.TSPasteButton = new System.Windows.Forms.ToolStripButton();
            this.TSCutButton = new System.Windows.Forms.ToolStripButton();
            this.RTBTextEditor = new System.Windows.Forms.RichTextBox();
            this.FileMenuStrip.SuspendLayout();
            this.ToolStripTop.SuspendLayout();
            this.ToolStripLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.FileMenuStrip.Size = new System.Drawing.Size(533, 24);
            this.FileMenuStrip.TabIndex = 0;
            this.FileMenuStrip.Text = "TextEditorFileMenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.File_icon;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.OpenFolder_icon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Save_icon;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.SaveAs_icon;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Exit_icon;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Cut_icon;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Copy_icon;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Paste_icon;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Info_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ToolStripTop
            // 
            this.ToolStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNewFileButton,
            this.TSOpenFileButton,
            this.TSSaveButton,
            this.TSSaveAsButton,
            this.toolStripSeparator1,
            this.TSBoldButton,
            this.TSItalicButton,
            this.TSUnderlineButton,
            this.TSInfoButton,
            this.TSFontSize,
            this.toolStripSeparator2,
            this.TSUsername});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 24);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripTop.Size = new System.Drawing.Size(533, 31);
            this.ToolStripTop.TabIndex = 1;
            this.ToolStripTop.Text = "toolStrip1";
            // 
            // TSNewFileButton
            // 
            this.TSNewFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSNewFileButton.Image = global::AD.NETA2.Properties.Resources.File_icon;
            this.TSNewFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSNewFileButton.Name = "TSNewFileButton";
            this.TSNewFileButton.Size = new System.Drawing.Size(28, 28);
            this.TSNewFileButton.Text = "New File";
            this.TSNewFileButton.Click += new System.EventHandler(this.TSNewFileButton_Click);
            // 
            // TSOpenFileButton
            // 
            this.TSOpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSOpenFileButton.Image = global::AD.NETA2.Properties.Resources.OpenFolder_icon;
            this.TSOpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSOpenFileButton.Name = "TSOpenFileButton";
            this.TSOpenFileButton.Size = new System.Drawing.Size(28, 28);
            this.TSOpenFileButton.Text = "Open";
            this.TSOpenFileButton.Click += new System.EventHandler(this.TSOpenFileButton_Click);
            // 
            // TSSaveButton
            // 
            this.TSSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSaveButton.Image = global::AD.NETA2.Properties.Resources.Save_icon;
            this.TSSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSaveButton.Name = "TSSaveButton";
            this.TSSaveButton.Size = new System.Drawing.Size(28, 28);
            this.TSSaveButton.Text = "Save";
            this.TSSaveButton.Click += new System.EventHandler(this.TSSaveButton_Click);
            // 
            // TSSaveAsButton
            // 
            this.TSSaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSaveAsButton.Image = global::AD.NETA2.Properties.Resources.SaveAs_icon;
            this.TSSaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSaveAsButton.Name = "TSSaveAsButton";
            this.TSSaveAsButton.Size = new System.Drawing.Size(28, 28);
            this.TSSaveAsButton.Text = "SaveAs";
            this.TSSaveAsButton.Click += new System.EventHandler(this.TSSaveAsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // TSBoldButton
            // 
            this.TSBoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBoldButton.Image = global::AD.NETA2.Properties.Resources.Bold_icon;
            this.TSBoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBoldButton.Name = "TSBoldButton";
            this.TSBoldButton.Size = new System.Drawing.Size(28, 28);
            this.TSBoldButton.Text = "Bold";
            this.TSBoldButton.Click += new System.EventHandler(this.TSBoldButton_Click);
            // 
            // TSItalicButton
            // 
            this.TSItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSItalicButton.Image = global::AD.NETA2.Properties.Resources.Italic_icon;
            this.TSItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSItalicButton.Name = "TSItalicButton";
            this.TSItalicButton.Size = new System.Drawing.Size(28, 28);
            this.TSItalicButton.Text = "Italic";
            this.TSItalicButton.Click += new System.EventHandler(this.TSItalicButton_Click);
            // 
            // TSUnderlineButton
            // 
            this.TSUnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSUnderlineButton.Image = global::AD.NETA2.Properties.Resources.Underline_icon;
            this.TSUnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSUnderlineButton.Name = "TSUnderlineButton";
            this.TSUnderlineButton.Size = new System.Drawing.Size(28, 28);
            this.TSUnderlineButton.Text = "Underline";
            this.TSUnderlineButton.Click += new System.EventHandler(this.TSUnderlineButton_Click);
            // 
            // TSInfoButton
            // 
            this.TSInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSInfoButton.Image = global::AD.NETA2.Properties.Resources.Info_icon;
            this.TSInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSInfoButton.Name = "TSInfoButton";
            this.TSInfoButton.Size = new System.Drawing.Size(28, 28);
            this.TSInfoButton.Text = "Info";
            this.TSInfoButton.Click += new System.EventHandler(this.TSInfoButton_Click);
            // 
            // TSFontSize
            // 
            this.TSFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.TSFontSize.Name = "TSFontSize";
            this.TSFontSize.Size = new System.Drawing.Size(121, 31);
            this.TSFontSize.SelectedIndexChanged += new System.EventHandler(this.TSFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // TSUsername
            // 
            this.TSUsername.Name = "TSUsername";
            this.TSUsername.Size = new System.Drawing.Size(32, 28);
            this.TSUsername.Text = "Filler";
            // 
            // ToolStripLeft
            // 
            this.ToolStripLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolStripLeft.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCopyButton,
            this.TSPasteButton,
            this.TSCutButton});
            this.ToolStripLeft.Location = new System.Drawing.Point(0, 55);
            this.ToolStripLeft.Name = "ToolStripLeft";
            this.ToolStripLeft.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripLeft.Size = new System.Drawing.Size(30, 237);
            this.ToolStripLeft.TabIndex = 2;
            this.ToolStripLeft.Text = "toolStrip2";
            // 
            // TSCopyButton
            // 
            this.TSCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSCopyButton.Image = global::AD.NETA2.Properties.Resources.Copy_icon;
            this.TSCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCopyButton.Name = "TSCopyButton";
            this.TSCopyButton.Size = new System.Drawing.Size(25, 28);
            this.TSCopyButton.Text = "Copy";
            this.TSCopyButton.Click += new System.EventHandler(this.TSCopyButton_Click);
            // 
            // TSPasteButton
            // 
            this.TSPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSPasteButton.Image = global::AD.NETA2.Properties.Resources.Paste_icon;
            this.TSPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSPasteButton.Name = "TSPasteButton";
            this.TSPasteButton.Size = new System.Drawing.Size(25, 28);
            this.TSPasteButton.Text = "Paste";
            this.TSPasteButton.Click += new System.EventHandler(this.TSPasteButton_Click);
            // 
            // TSCutButton
            // 
            this.TSCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSCutButton.Image = global::AD.NETA2.Properties.Resources.Cut_icon;
            this.TSCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCutButton.Name = "TSCutButton";
            this.TSCutButton.Size = new System.Drawing.Size(25, 28);
            this.TSCutButton.Text = "Cut";
            this.TSCutButton.Click += new System.EventHandler(this.TSCutButton_Click);
            // 
            // RTBTextEditor
            // 
            this.RTBTextEditor.AcceptsTab = true;
            this.RTBTextEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBTextEditor.Location = new System.Drawing.Point(30, 55);
            this.RTBTextEditor.Margin = new System.Windows.Forms.Padding(2);
            this.RTBTextEditor.Name = "RTBTextEditor";
            this.RTBTextEditor.Size = new System.Drawing.Size(503, 237);
            this.RTBTextEditor.TabIndex = 3;
            this.RTBTextEditor.Text = "";
            this.RTBTextEditor.TextChanged += new System.EventHandler(this.RTBTextEditor_TextChanged);
            // 
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.RTBTextEditor);
            this.Controls.Add(this.ToolStripLeft);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.FileMenuStrip);
            this.MainMenuStrip = this.FileMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextEditorWindow";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.FileMenuStrip.ResumeLayout(false);
            this.FileMenuStrip.PerformLayout();
            this.ToolStripTop.ResumeLayout(false);
            this.ToolStripTop.PerformLayout();
            this.ToolStripLeft.ResumeLayout(false);
            this.ToolStripLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.ToolStripButton TSNewFileButton;
        private System.Windows.Forms.ToolStripButton TSOpenFileButton;
        private System.Windows.Forms.ToolStripButton TSSaveButton;
        private System.Windows.Forms.ToolStripButton TSSaveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBoldButton;
        private System.Windows.Forms.ToolStripButton TSItalicButton;
        private System.Windows.Forms.ToolStripButton TSUnderlineButton;
        private System.Windows.Forms.ToolStripButton TSInfoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel TSUsername;
        private System.Windows.Forms.ToolStrip ToolStripLeft;
        private System.Windows.Forms.ToolStripButton TSCopyButton;
        private System.Windows.Forms.ToolStripButton TSPasteButton;
        private System.Windows.Forms.ToolStripButton TSCutButton;
        private System.Windows.Forms.RichTextBox RTBTextEditor;
        private System.Windows.Forms.ToolStripComboBox TSFontSize;
    }
}