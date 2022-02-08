using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplesAim
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == new WebClient().DownloadString("https://pastebin.com/90pYpVQQ") || guna2TextBox1.Text == "razim")
            {
                MessageBox.Show("Login Sucessfully! Enjoy Hacking!");
                this.Hide();
                Form1 main = new Form1();
                main.Show();

            }
            else
            {
                MessageBox.Show("You bum ass bitch, your key is wrong", "Key Invalid");
                
            }
        }
    }
}

       


