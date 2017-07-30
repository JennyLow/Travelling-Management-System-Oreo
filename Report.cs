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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IOOPDataSet1.Flights' table. You can move, or remove it, as needed.
            this.FlightsTableAdapter.Fill(this.IOOPDataSet1.Flights);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 newForm = new Form13();
            newForm.Show();
            this.Hide();
        }
    }
}
