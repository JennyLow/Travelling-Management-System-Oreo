using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") && (textBox2.Text == ""))
                {
                    MessageBox.Show("Please enter a valid input!");
                    textBox1.Focus();
                }

            else if ((textBox1.Text != "admin") && (textBox2.Text != "abcd1234"))
                {
                    MessageBox.Show("Invalid user! Please enter valid login details");                   
                }

            else if ((textBox1.Text == "admin") && (textBox2.Text == "abcd1234"))
                {
                    MessageBox.Show("Login Successful! Welcome!");
                    Form1 newForm = new Form1();
                    newForm.Show();
                    this.Hide();
                }       
            
                    
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show();
            this.Hide();
        }
    }
}
