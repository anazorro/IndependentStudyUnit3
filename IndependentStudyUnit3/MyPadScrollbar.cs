using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentStudyUnit3
{
    public partial class MyPadScrollbar : Form
    {
        private VScrollBar vScrollBar1 = new VScrollBar();

        public MyPadScrollbar()
        {
            InitializeComponent();

            // Create and initialize a VScrollBar.
          

            // Dock the scroll bar to the right side of the form.
            vScrollBar1.Dock = DockStyle.Right;

            // Add the scroll bar to the form.
            Controls.Add(vScrollBar1);

            vScrollBar1.Maximum = 36;
            vScrollBar1.Minimum = 8;

            vScrollBar1.Click += new System.EventHandler(this.SetFontSize);
        }

        private void SetFontSize(object sender, EventArgs c)
        {
            Font font = new Font(mainRichTextBox.Font.Name, vScrollBar1.Value, FontStyle.Regular);
            mainRichTextBox.Font = font;
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CutText(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }

        private void PasteText(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void CopyText(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void UndoOperation(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        private void SelectBackColor(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainRichTextBox.BackColor = colorDialog1.Color;
        }

        private void SelectFont(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mainRichTextBox.SelectionFont = fontDialog1.Font;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            mainRichTextBox.LoadFile(openFileDialog1.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text (*.rtf)|";
            saveFileDialog1.FileName = "Document 1";
            saveFileDialog1.ShowDialog();
            mainRichTextBox.SaveFile(saveFileDialog1.FileName);
        }

        private void foregroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainRichTextBox.ForeColor = colorDialog1.Color;
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Font f = new Font(mainRichTextBox.Font.Name, hScrollBar.Value, FontStyle.Regular);
            mainRichTextBox.SelectionFont = f;
        }
    }
}
