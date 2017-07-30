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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Grand Hyatt Hotel";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Shangri-La Hotel";
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Grand Millenium Hotel";
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox6.Text = ("RM 775");
            textBox7.Text = ("RM 630");
            textBox8.Text = ("RM 550");
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox6.Text = ("RM 4000");
            textBox7.Text = ("RM 3000");
            textBox8.Text = ("RM 3200");
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox6.Text = ("RM 14000");
            textBox7.Text = ("RM 10000");
            textBox8.Text = ("RM 10500");
            
        }

        bool hasBeenClicked = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void NextPage1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                OleDbConnection cnnOleDB = new OleDbConnection();
                OleDbCommand cmdInsert = new OleDbCommand();
                cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
                cnnOleDB.Open();
                cmdInsert.CommandText = "Insert Into Hotels (Hotel, BookDate, IC, Price) values (\'" + textBox3.Text + "\', \'" + textBox1.Text + "\', \' " + textBox2.Text + "\', \' " + textBox5.Text + "\')";
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.Connection = cnnOleDB;
                cmdInsert.ExecuteNonQuery();


                Form14 newForm = new Form14();
                newForm.Show();
                this.Hide();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            textBox1.Text = dt.ToString("dd-MMM-yyyy");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ;
            textBox3.Text = ("Grand Hyatt Hotel");
            textBox4.Text = ("Triple Room");
            textBox5.Text = ("775");
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked) ;
            textBox3.Text = ("Shangri-La Hotel");
            textBox4.Text = ("Twin Room");
            textBox5.Text = ("630");
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked) ;
            textBox3.Text = ("Grand Millenium Hotel");
            textBox4.Text = ("Double Room");
            textBox5.Text = ("550");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
