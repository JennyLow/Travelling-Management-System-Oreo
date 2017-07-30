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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection cnnOleDB = new OleDbConnection();
            OleDbCommand cmdOleDB = new OleDbCommand();

            cnnOleDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOP.accdb";
            cnnOleDB.Open();


            string bh = textBox1.Text;
            if (bh != "")
            {

                cmdOleDB.CommandText = "Select * From Flights where IC = " + int.Parse(bh);
                cmdOleDB.Connection = cnnOleDB;
                OleDbDataReader dr = cmdOleDB.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Please proceed to payments");
                    textBox2.Text = dr["price"].ToString();
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);

            int b = Convert.ToInt32(textBox2.Text);

            int c = a - b;

            textBox4.Text = Convert.ToString(c);
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

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
