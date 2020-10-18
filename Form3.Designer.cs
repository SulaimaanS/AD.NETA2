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
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
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
            this.FileMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.FileMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.FileMenuStrip.Size = new System.Drawing.Size(800, 36);
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
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.File_icon;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.OpenFolder_icon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Save_icon;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.SaveAs_icon;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Cut_icon;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Copy_icon;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Paste_icon;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::AD.NETA2.Properties.Resources.Info_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
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
            this.toolStripComboBox1,
            this.toolStripButton8,
            this.toolStripSeparator2,
            this.TSUsername});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 36);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStripTop.Size = new System.Drawing.Size(800, 38);
            this.ToolStripTop.TabIndex = 1;
            this.ToolStripTop.Text = "toolStrip1";
            // 
            // TSNewFileButton
            // 
            this.TSNewFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSNewFileButton.Image = global::AD.NETA2.Properties.Resources.File_icon;
            this.TSNewFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSNewFileButton.Name = "TSNewFileButton";
            this.TSNewFileButton.Size = new System.Drawing.Size(34, 33);
            this.TSNewFileButton.Text = "New File";
            // 
            // TSOpenFileButton
            // 
            this.TSOpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSOpenFileButton.Image = global::AD.NETA2.Properties.Resources.OpenFolder_icon;
            this.TSOpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSOpenFileButton.Name = "TSOpenFileButton";
            this.TSOpenFileButton.Size = new System.Drawing.Size(34, 33);
            this.TSOpenFileButton.Text = "Open";
            this.TSOpenFileButton.Click += new System.EventHandler(this.TSOpenFileButton_Click);
            // 
            // TSSaveButton
            // 
            this.TSSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSaveButton.Image = global::AD.NETA2.Properties.Resources.Save_icon;
            this.TSSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSaveButton.Name = "TSSaveButton";
            this.TSSaveButton.Size = new System.Drawing.Size(34, 33);
            this.TSSaveButton.Text = "Save";
            this.TSSaveButton.Click += new System.EventHandler(this.TSSaveButton_Click);
            // 
            // TSSaveAsButton
            // 
            this.TSSaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSaveAsButton.Image = global::AD.NETA2.Properties.Resources.SaveAs_icon;
            this.TSSaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSaveAsButton.Name = "TSSaveAsButton";
            this.TSSaveAsButton.Size = new System.Drawing.Size(34, 33);
            this.TSSaveAsButton.Text = "SaveAs";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // TSBoldButton
            // 
            this.TSBoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBoldButton.Image = global::AD.NETA2.Properties.Resources.Bold_icon;
            this.TSBoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBoldButton.Name = "TSBoldButton";
            this.TSBoldButton.Size = new System.Drawing.Size(34, 33);
            this.TSBoldButton.Text = "Bold";
            // 
            // TSItalicButton
            // 
            this.TSItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSItalicButton.Image = global::AD.NETA2.Properties.Resources.Italic_icon;
            this.TSItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSItalicButton.Name = "TSItalicButton";
            this.TSItalicButton.Size = new System.Drawing.Size(34, 33);
            this.TSItalicButton.Text = "Italic";
            // 
            // TSUnderlineButton
            // 
            this.TSUnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSUnderlineButton.Image = global::AD.NETA2.Properties.Resources.Underline_icon;
            this.TSUnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSUnderlineButton.Name = "TSUnderlineButton";
            this.TSUnderlineButton.Size = new System.Drawing.Size(34, 33);
            this.TSUnderlineButton.Text = "Underline";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 38);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::AD.NETA2.Properties.Resources.Info_icon;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton8.Text = "Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // TSUsername
            // 
            this.TSUsername.Name = "TSUsername";
            this.TSUsername.Size = new System.Drawing.Size(131, 33);
            this.TSUsername.Text = "toolStripLabel1";
            // 
            // ToolStripLeft
            // 
            this.ToolStripLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolStripLeft.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCopyButton,
            this.TSPasteButton,
            this.TSCutButton});
            this.ToolStripLeft.Location = new System.Drawing.Point(0, 74);
            this.ToolStripLeft.Name = "ToolStripLeft";
            this.ToolStripLeft.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStripLeft.Size = new System.Drawing.Size(37, 375);
            this.ToolStripLeft.TabIndex = 2;
            this.ToolStripLeft.Text = "toolStrip2";
            // 
            // TSCopyButton
            // 
            this.TSCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSCopyButton.Image = global::AD.NETA2.Properties.Resources.Copy_icon;
            this.TSCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCopyButton.Name = "TSCopyButton";
            this.TSCopyButton.Size = new System.Drawing.Size(30, 28);
            this.TSCopyButton.Text = "Copy";
            // 
            // TSPasteButton
            // 
            this.TSPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSPasteButton.Image = global::AD.NETA2.Properties.Resources.Paste_icon;
            this.TSPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSPasteButton.Name = "TSPasteButton";
            this.TSPasteButton.Size = new System.Drawing.Size(30, 28);
            this.TSPasteButton.Text = "Paste";
            // 
            // TSCutButton
            // 
            this.TSCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSCutButton.Image = global::AD.NETA2.Properties.Resources.Cut_icon;
            this.TSCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCutButton.Name = "TSCutButton";
            this.TSCutButton.Size = new System.Drawing.Size(30, 28);
            this.TSCutButton.Text = "Cut";
            // 
            // RTBTextEditor
            // 
            this.RTBTextEditor.Location = new System.Drawing.Point(46, 88);
            this.RTBTextEditor.Name = "RTBTextEditor";
            this.RTBTextEditor.Size = new System.Drawing.Size(742, 350);
            this.RTBTextEditor.TabIndex = 3;
            this.RTBTextEditor.Text = "";
            this.RTBTextEditor.TextChanged += new System.EventHandler(this.RTBTextEditor_TextChanged);
            // 
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.RTBTextEditor);
            this.Controls.Add(this.ToolStripLeft);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.FileMenuStrip);
            this.MainMenuStrip = this.FileMenuStrip;
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel TSUsername;
        private System.Windows.Forms.ToolStrip ToolStripLeft;
        private System.Windows.Forms.ToolStripButton TSCopyButton;
        private System.Windows.Forms.ToolStripButton TSPasteButton;
        private System.Windows.Forms.ToolStripButton TSCutButton;
        private System.Windows.Forms.RichTextBox RTBTextEditor;
    }
}