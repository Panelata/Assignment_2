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
    public partial class Edit : Form
    {
        private String filename;

        public Edit()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save File";
            saveFile.Filter = "Rich Text Format(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|All Files(.*.)|*.*";
            DialogResult dr = saveFile.ShowDialog();

            if(dr == DialogResult.OK)
            {
                richTB.SaveFile(saveFile.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text Format(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|All Files(.*.)|*.*";
            openFile.Title = "Open a File";
            DialogResult dr = openFile.ShowDialog();

            if(dr == DialogResult.OK)
            {
                filename = openFile.FileName;
                richTB.LoadFile(openFile.FileName);
            }
        }
    }
}
