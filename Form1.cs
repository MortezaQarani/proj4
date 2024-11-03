using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = usernamebox.Text;
            string password = passwordbox.Text;
            if(userName.ToLower() == "morteza" && password.ToLower() == "12345")
            {
                MessageBox.Show("Valid user.");
            }
            else
            {
                usernamebox.Text = string.Empty;
                passwordbox.Text= string.Empty;
                MessageBox.Show("Invalid user.");
            }
        }
    }
}
