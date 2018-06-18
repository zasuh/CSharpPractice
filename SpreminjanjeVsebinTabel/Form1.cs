using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreminjanjeVsebinTabel
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

            try

            {

                //konča,o z editiranjem trenutne vrstice, da se vidi, ali so bile spremembe,

                //ki jih HasChanges() drugače ne bi zaznal

                this.Validate();

                this.categoriesBindingSource.EndEdit();

                //shraniti poskušamo le, če je bilo kaj sprememb

                if (northwindDataSet.HasChanges())

                {

                    //v VisualStudio2008 je privzet nacin s tableAdapterManagerjem

                    this.tableAdapterManager.UpdateAll(this.northwindDataSet);

                    //tole pa deluje tako v VisualStudio2005 kot v VisualStudio2008

                    //this.categoriesTableAdapter.Update(this.northwindDataSet.Categories);

                    MessageBox.Show("Spremembe uspešno shranjene.", "",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Napaka pri shranjevanju: " + ex.Message +

                "\n\r\n\rNeshranjene spremembe bodo zavržene!", "Napaka",

                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.tabela.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
        }

        private void tabela_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(" Napaka pri spreminjanju vsebine: " + e.Exception.Message, "Pozor",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {

                //poskusimo dodati novo vrstico

                categoriesBindingSource.AddNew();

            }

            catch (Exception ex)

            {

                MessageBox.Show(" Napaka pri spreminjanju vsebine: " + ex.Message, "Pozor",

                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bindingNavigatorMoveNextItem1_Click(object sender, EventArgs e)
        {
            try

            {

                //poskusimo se premakniti na prejšnji oz. prvi zapis

                if (sender == bindingNavigatorMovePreviousItem) categoriesBindingSource.MovePrevious();

                else if (sender == bindingNavigatorMoveFirstItem) categoriesBindingSource.MoveFirst();

            }

            catch (Exception ex)

            {

                MessageBox.Show(" Napaka pri spreminjanju vsebine: " + ex.Message, "Pozor",

                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
