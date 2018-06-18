using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtriranje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cDjiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cDjiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.izposojaCDjevDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izposojaCDjevDataSet.CDji' table. You can move, or remove it, as needed.
            this.cDjiTableAdapter.Fill(this.izposojaCDjevDataSet.CDji);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cDjiBindingSource.Filter = "NASLOV LIKE '" + textBox1.Text + "'";
            cDjiBindingSource.Filter = null;
        }
    }
}
