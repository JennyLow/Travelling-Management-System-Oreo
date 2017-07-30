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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotels newForm = new Hotels();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection cnnOleDB = new OleDbConnection();
            OleDbCommand cmdOleDB = new OleDbCommand();

            cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
            cnnOleDB.Open();


            string bh = textBox1.Text;
            if (bh != "")
            {

                cmdOleDB.CommandText = "Select * From Hotels where IC = " + int.Parse(bh);
                cmdOleDB.Connection = cnnOleDB;
                OleDbDataReader dr = cmdOleDB.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Result Found for the Customer");
                    textBox2.Text = dr["BookDate"].ToString();
                    textBox3.Text = dr["Hotel"].ToString();
                    textBox10.Text = dr["Price"].ToString();

                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) ;
            textBox4.Text = "Per night";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) ;
            textBox4.Text = "Per week";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) ;
            textBox4.Text = "Per month";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                OleDbConnection cnnOleDB = new OleDbConnection();
                OleDbCommand cmdInsert = new OleDbCommand();
                cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
                cnnOleDB.Open();
                cmdInsert.CommandText = "Insert Into Hotels(Hotel, Duration, IC, RoomNo, Points) values (\'" + textBox3.Text + "\', \'" + textBox4.Text + "\', \' " + textBox1.Text + "\', \'" + textBox9.Text + "\', \'" + textBox5.Text + "\')";
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.Connection = cnnOleDB;
                cmdInsert.ExecuteNonQuery();
            }
            
            if (MessageBox.Show("Do you want to go back to main menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes

                Form4 newForm = new Form4();
                newForm.Show();
                this.Hide();
            }
            else
            {
                // user clicked no
                if (MessageBox.Show("Do you want to exit system?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes

                    this.Close();
                }
                else
                {
                    // user clicked no
                }
            }


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
