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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            String username = usernameTB.Text;
            testL.Text = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
