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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            payment newForm = new payment();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection cnnOleDB = new OleDbConnection();
            OleDbCommand cmdOleDB = new OleDbCommand();

            cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
            cnnOleDB.Open();


            string bh = textBox4.Text;
            if (bh != "")
            {

                cmdOleDB.CommandText = "Select * From Flights where IC = " + int.Parse(bh);
                cmdOleDB.Connection = cnnOleDB;
                OleDbDataReader dr = cmdOleDB.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Result Found for the Customer");
                    textBox2.Text = dr["DepartureDate"].ToString();
                    textBox3.Text = dr["Destination"].ToString();
                }
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            OleDbConnection cnnOleDB = new OleDbConnection();
            OleDbCommand cmdoLEDB = new OleDbCommand();
            OleDbCommand cmdDelete = new OleDbCommand();
            cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
            cnnOleDB.Open();
            cmdDelete.CommandText = "Delete From Flights Where IC = " + textBox4.Text + "";
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.Connection = cnnOleDB;
            cmdDelete.ExecuteNonQuery();
            MessageBox.Show("Flight successfully cancelled!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
