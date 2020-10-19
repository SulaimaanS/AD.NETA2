using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AD.NETA2 {
    public static class ExtensionMethods { //Class to enable the context menu for editing text in the richtextbox
        public static void EnableContextMenu(this RichTextBox rtb) {
            if (rtb.ContextMenuStrip == null) {
                //Create a ContextMenuStrip without icons
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.ShowImageMargin = false;

                //Add the Cut option (cuts the selected text inside the richtextbox)
                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => rtb.Cut();
                cms.Items.Add(tsmiCut);

                //Add the Copy option (copies the selected text inside the richtextbox)
                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => rtb.Copy();
                cms.Items.Add(tsmiCopy);

                //Add the Paste option (adds the text from the clipboard into the richtextbox)
                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => rtb.Paste();
                cms.Items.Add(tsmiPaste);

                //When opening the menu, check if the condition is fulfilled 
                //in order to enable the action
                cms.Opening += (sender, e) =>
                {
                    tsmiCut.Enabled = !rtb.ReadOnly && rtb.SelectionLength > 0;
                    tsmiCopy.Enabled = rtb.SelectionLength > 0;
                    tsmiPaste.Enabled = !rtb.ReadOnly && Clipboard.ContainsText();
                };
                rtb.ContextMenuStrip = cms;
            }
        }
    }
}
