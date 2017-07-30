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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void LangkawiIsButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Langkawi Island Tour";
        }

        private void CameronButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Cameron Highland Tour";
        }

        private void TiomanButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Tioman Island Tour";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Langkawi Island Tour";
            if (radioButton1.Checked) ;
            textBox3.Text = ("Langkawi Island Tour");
            textBox4.Text = ("1200");
            textBox5.Text = ("240");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Cameron Highland Tour";
            if (radioButton2.Checked) ;
            textBox3.Text = ("Cameron Highland Tour");
            textBox4.Text = ("800");
            textBox5.Text = ("160");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Tioman Island Tour";
            if (radioButton3.Checked) ;
            textBox3.Text = ("Tioman Island Tour");
            textBox4.Text = ("1000");
            textBox5.Text = ("200");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            textBox1.Text = dt.ToString("dd-MMM-yyyy");
        }

        private void PreviousPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void NextPage1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                OleDbConnection cnnOleDB = new OleDbConnection();
                OleDbCommand cmdInsert = new OleDbCommand();
                cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
                cnnOleDB.Open();
                cmdInsert.CommandText = "Insert Into Holiday(IC, ChosenPackage, BookingDate, Price, Points) values (\'" + textBox2.Text + "\', \'" + textBox3.Text + "\', \' " + textBox1.Text + "\', \'" + textBox4.Text + "\', \'" + textBox5.Text + "\')";
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.Connection = cnnOleDB;
                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Please proceed to payments");

                Form10 newForm = new Form10();
                newForm.Show();
                this.Hide();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
    }
}
