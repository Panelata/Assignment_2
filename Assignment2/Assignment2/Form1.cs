using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        LinkedList<Login> loginList = new LinkedList<Login>();
        int listSize = 0;

        public Form1()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines("login.txt");
            foreach(string set in lines)
            {
                string[] splits = set.Split(',');
                loginList.AddFirst(new Login(splits[0], splits[1], splits[2], splits[3], splits[4], splits[5]));
                listSize++;
            }
           // Console.WriteLine(listSize);
           // Login test = loginList.ElementAt(0);
           // Console.WriteLine(test.ToString());
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            String usernameInput = usernameTB.Text;
            String passwordInput = passwordTB.Text;

            //Loops through the linkedlist checking to see if the password and username matches.
            for (int i = 0; i < listSize; i++)
            {
                Login check = loginList.ElementAt(i);
                if (usernameInput.Equals(check.getUsername()) && passwordInput.Equals(check.getPassword()))
                {
                    //Add function here to open a new window, that window will be the actual text editor
                    Console.WriteLine("IT WORKS");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newUserB_Click(object sender, EventArgs e)
        {

        }
    }
}
