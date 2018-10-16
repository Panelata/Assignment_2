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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void submitB_Click(object sender, EventArgs e)
        {
            //Checks if all fields are compeleted
            if (typeCB.SelectedIndex > -1 && !String.IsNullOrEmpty(usernameTB.Text) && !String.IsNullOrEmpty(passwordTB.Text) && !String.IsNullOrEmpty(rePasswordTB.Text) && !String.IsNullOrEmpty(firstnameTB.Text) && !String.IsNullOrEmpty(lastnameTB.Text) && !String.IsNullOrEmpty(dobTB.Text))
            {
                //checks if passwords are matching
                if (passwordTB.Text.Equals(rePasswordTB.Text)) {
                    String newUser = usernameTB.Text + "," + passwordTB.Text + "," + typeCB.Text + "," + firstnameTB.Text + "," + lastnameTB.Text + "," + dobTB.Text;
                    System.IO.File.AppendAllText("login.txt", Environment.NewLine + newUser);
                    this.Dispose();
                } else
                {
                    MessageBox.Show("Passwords do not match.", "Error");
                }
            } else
            {
                MessageBox.Show("All fields are required.", "Error");
            }
        }

        private void typeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
