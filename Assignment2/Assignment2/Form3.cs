using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form3 : Form
    {
        private String filename = "";
        private SaveFileDialog saveFile = new SaveFileDialog();
        private OpenFileDialog openFile = new OpenFileDialog();


        public Form3(string v)
        {
            InitializeComponent();
            richTB.ReadOnly = true;
            currentUserL.Text = v;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newRTF();
        }

        private void newRTF()
        {
            richTB.Clear();
            filename = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void open()
        {
            openFile.Filter = "Rich Text Format(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|All Files(.*.)|*.*";
            openFile.Title = "Open a File";
            DialogResult dr = openFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = openFile.FileName;
                richTB.LoadFile(openFile.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            //this is a try, because if a user saves and no save has been loaded or created before
            //then the program will be unable to locate the file, causing an exception.
            try
            {
                richTB.SaveFile(filename);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot save, no file selected.");
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            // SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save File";
            saveFile.Filter = "Rich Text Format(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|All Files(.*.)|*.*";
            DialogResult dr = saveFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                richTB.SaveFile(saveFile.FileName);
                filename = saveFile.FileName;

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Paste();
        }

        private void newSB_Click(object sender, EventArgs e)
        {
            richTB.Clear();
            filename = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            open();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTB.Font.Style != FontStyle.Bold)
                richTB.SelectionFont = new Font(this.Font, FontStyle.Bold);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTB.Font.Style != FontStyle.Italic)
                richTB.SelectionFont = new Font(this.Font, FontStyle.Italic);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (richTB.Font.Style != FontStyle.Underline)
                richTB.SelectionFont = new Font(this.Font, FontStyle.Underline);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(fontSizeSCB.SelectedText);
                int size = Convert.ToInt32(fontSizeSCB.Text);
                String fontname = richTB.SelectionFont.Name;
                richTB.SelectionFont = new Font(fontname, size);
            }
            catch (Exception)
            {
                Console.WriteLine("");
            }
        }

        private void usernameL_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTB.Cut();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTB.Copy();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTB.Paste();
        }
    }
}
