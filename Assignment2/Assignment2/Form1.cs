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
            readFile();
           /* string[] lines = System.IO.File.ReadAllLines("login.txt");
            foreach(string set in lines)
            {
                string[] splits = set.Split(',');
                loginList.AddFirst(new Login(splits[0], splits[1], splits[2], splits[3], splits[4], splits[5]));
                listSize++;
            }*/
        }

        //This reads the file and stores the login details in linkedlist
        private void readFile()
        {
            listSize = 0;
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            foreach (string set in lines)
            {
                string[] splits = set.Split(',');
                loginList.AddFirst(new Login(splits[0], splits[1], splits[2], splits[3], splits[4], splits[5]));
                listSize++;
            }
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            String usernameInput = usernameTB.Text;
            String passwordInput = passwordTB.Text;
            int match = 0; //will be used to matech the user.
            int intCheck = 0; //Used to check whether the user has been found or not.
            Login check;

            //Loops through the linkedlist checking to see if the password and username matches and sets intCheck to 1 if a match is found.
            for (int i = 0; i < listSize; i++)
            {
                check = loginList.ElementAt(i);
                if (usernameInput.Equals(check.getUsername()) && passwordInput.Equals(check.getPassword()))
                {
                    intCheck = 1;
                    match = i;
                    break;
                }
            }

            //if match is 0, then message box states that the username or password is incorrect. Else it will open a form depending on the userType.
            if (intCheck == 0)
                MessageBox.Show("Incorrect username or password.", "Incorrect login");
            else
            {
                check = loginList.ElementAt(match);
                if (check.getUserType().Equals("View"))
                {
                    Console.WriteLine("THIS USER IS VIEW ONLY");
                    this.Hide();
                    Form3 form3 = new Form3(check.getUsername());
                    form3.ShowDialog();
                    this.Show();
                } else
                {
                    Console.WriteLine("THIS USER CAN EDIT");
                    this.Hide();
                    Edit editForm = new Edit(check.getUsername());
                    editForm.ShowDialog();
                    this.Show();
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
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            readFile();
            this.Show();
        }
    }
}
