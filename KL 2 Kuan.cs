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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            departtextBox.Text = ("");
            textBox2.Text = ("");
            seattextBox.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flights newForm = new Flights();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            departtextBox.Text = dt.ToString("dd-MMM-yyyy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (seattextBox.Text != "" && departtextBox.Text != "" && pricetextBox.Text != "" && pointstextBox.Text !="" && textBox7.Text !="")
                {
                    OleDbConnection cnnOleDB = new OleDbConnection();
                    OleDbCommand cmdInsert = new OleDbCommand();
                    cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
                    cnnOleDB.Open();
                    cmdInsert.CommandText = "Insert Into Flights(SeatID, Destination, DepartureDate, price, points, IC) values (\'" + seattextBox.Text + "\', \'" + textBox7.Text + "\', \' " + departtextBox.Text + "\', \'" + pricetextBox.Text + "\', \'" + pointstextBox.Text + "\',  \'" + textBox1.Text + "\')";
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.Connection = cnnOleDB;
                    cmdInsert.ExecuteNonQuery();

                    Form5 newForm = new Form5();
                    newForm.Show();
                    this.Hide();
                }
            else if (seattextBox.Text == "" && departtextBox.Text == "" && pricetextBox.Text == "" && pointstextBox.Text =="" && textBox7.Text =="")
            {
                MessageBox.Show("Please make valid selections!");
            }
        }
            


            

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Add more :")
            {
                button5.Text = "Hide";
            }
            else if (button5.Text == "Hide")
            {
                button5.Text = "Add more :";
            }
            textBox2.Visible = !textBox2.Visible;
            textBox4.Visible = !textBox4.Visible;
            textBox5.Visible = !textBox5.Visible;
            textBox6.Visible = !textBox6.Visible;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void seattextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void departtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pointstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        bool hasBeenClicked = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
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
