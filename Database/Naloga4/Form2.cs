using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            try
            {
                // TODO: This line of code loads data into the 'northwndDataSet.Orders' table. You can move, or remove it, as needed.
                this.ordersTableAdapter.Fill(this.northwndDataSet.Orders);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Podatki se niso naložili! :", ex);
            }

        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
