using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShranjevanjeSlik2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try

            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                //DialogResult je v System.Windows.Forms

                {

                    //nalaganje v trenutno vrstico DataGridViewja v ustrezno celico

                    categoriesDataGridView.CurrentRow.Cells[3].Value =
                    Image.FromFile(openFileDialog1.FileName);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Izbrane datoteke ne morem prikazati v PictureBoxu. Napaka: " +

                ex.Message, "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void categoriesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",

            "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }
    }
}
