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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OleDbConnection cnnOleDB = new OleDbConnection();
            OleDbCommand cmdOleDB = new OleDbCommand();

            cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
            cnnOleDB.Open();


            string si = textBox1.Text;
            if (si != "")
            {

                cmdOleDB.CommandText = "Select * From Holiday where IC = " + int.Parse(si);
                cmdOleDB.Connection = cnnOleDB;
                OleDbDataReader dr = cmdOleDB.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Result Found for the Customer");
                    PricePackage.Text = dr["Price"].ToString();
                    textBox4.Text = dr["ChosenPackage"].ToString();
                    textBox5.Text = dr["Points"].ToString();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);

            int b = Convert.ToInt32(PricePackage.Text);

            int c = a - b;

            textBox3.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
