using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametri3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void customersDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //poiskati moramo CustomerID v izbrani vrstici in ga uporabiti za parameter poizvedbe,

            //ki izpiše naročila izbrane stranke

            //to poizvedbo kličemo v funkciji LoadOrders (ki se nahaja na drugi formi)


            //do trenutne vrstice lahko pridemo preko DataGridViewja ali BindingSourca


            //prek trenutne vrstice DataGridViewja:

            //skličemo se na stolpec 0 (dataGridViewTextBoxColumn1) trenutne vrstice

            string s;

            //s = CustomersDataGridView.CurrentRow.Cells[0].Value.ToString();

            s = customersDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();


            //Pri načinu prek BindingSourca moramo do vrstice preko pogleda nanjo (DataRowView)

            System.Data.DataRowView SelectedRowView;

            //izbrana vrstica je tipa vrstice v Customers v northwndDataSet

            NorthwindDataSet.CustomersRow SelectedRow;


            //pridemo do pogleda na trenutno izbrano vrstico in preko njega do dejanske vrstice

            SelectedRowView = (System.Data.DataRowView)this.customersBindingSource.Current;

            SelectedRow = (NorthwindDataSet.CustomersRow)SelectedRowView.Row;


            //ustvarimo nov primerek druge forme, napolnimo ga z ustreznimi podatki

            //in ga odpremo modalno (kot dialog)

            Form2 OrdersForm = new Form2();

            //prek DataGridViewja

            OrdersForm.LoadOrders(s);

            //prek BindingSourca

            //OrdersForm.LoadOrders(SelectedRow.CustomerID);

            OrdersForm.ShowDialog();
        }
    }
}
