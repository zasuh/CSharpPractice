using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poizvedbe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try

            {

                sQL1TableAdapter.Fill(this.northwindDataSet.SQL1);

                sQL2TableAdapter.Fill(this.northwindDataSet.SQL2)

}

            catch

            {

                MessageBox.Show("Napaka pri povezovanju z bazo!\n\rProgram se bo zdaj zaprl.");

            }

            //dosežimo, da se bodo stolpci DataGridViewja avtomatično nastavljali

            sQL1TableAdapter.AutoGenerateColumns = true;

            //skrijmo vse vidne komponente razen menija

            SQLBindingNavigator.Visible = false;

            toolStrip1.Visible = false;

            SQLDataGridView.Visible = false;

        }

        private void sQL1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sQL1DataGridView.AutoGenerateColumns = true;
        }
    }
}
