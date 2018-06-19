using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poizvedbe1
{
    public partial class FormSQL1 : Form
    {
        public FormSQL1()
        {
            InitializeComponent();
        }

        private void FormSQL1_Load(object sender, EventArgs e)
        {

            {

                try

                {

                    this.sQL1TableAdapter.Fill(this.northwindDataSet.SQL1);

                }

                catch

                {

                    MessageBox.Show("Napaka pri povezovanju z bazo!");

                    this.Close();

                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try

            {

                this.sQL1TableAdapter.FillByCountry(this.northwindDataSet.SQL1, toolStripTextBox1.Text);

            }

            catch

            {

                MessageBox.Show("Napaka pri povezovanju z bazo!.");

                this.Close();

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try

            {

                this.sQL1TableAdapter.Fill(this.northwindDataSet.SQL1);

            }

            catch

            {

                MessageBox.Show("Napaka pri povezovanju z bazo!");

                this.Close();

            }
        }
    }
}
