using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication15
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                OleDbConnection cnnOleDB = new OleDbConnection();
                OleDbCommand cmdInsert = new OleDbCommand();
                cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
                cnnOleDB.Open();
                cmdInsert.CommandText = "Insert Into NewCust(CustName, IC, ContactNo) values (\'" + textBox1.Text + "\', \' " + textBox2.Text + "\', \'" + textBox3.Text + "\')";
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.Connection = cnnOleDB;
                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("New customer profile successfuly created!");
                Form4 newForm = new Form4();
                newForm.Show();
                this.Hide();


            }     
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
        }
    }
}
