using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace University
{
    public partial class Form1 : Form
    {
        HashCode hc = new HashCode();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string user = txtUserName.Text;
            string pass = txtPass.Text;

            if (user == username && pass == password)
            {
                MessageBox.Show("Have a good day", "Welcome Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ////message box has four parameters
                ////1 message
                ////2 title
                ////3 button
                //4 icon
                AddNew an = new AddNew();
                an.Show();
                this.Hide();

                ////used txtHash to find the encripitado password, adicionar uma txtBox, and name it after the same name here as well
                ////txtHash.Text = hc.passhash(pass);
                //lblPass.Enabled = false;
                //lblUser.Enabled = false;
                //txtPass.Enabled = false;
                //txtUser.Enabled = false;,
                //btnSubmit.Enabled = false;
                //txtUser.Clear();
                //txtPass.Clear();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }

            
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtUserName.Focus();
        }

        private void lbbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
