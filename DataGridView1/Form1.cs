using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPriimek.Text != "")
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;
            }
        }

        private void txtPriimek_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            tabela.Rows.Add(txtIme.Text, txtPriimek.Text, datumIzpita.Text, ocenaIzpita.Text);
            txtIme.Text = "";
            txtPriimek.Text = "";
            txtIme.Focus();
            btnBrisi.Enabled = true;
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            tabela.Rows.Remove(tabela.CurrentRow);
            if (tabela.RowCount == 0)
            {
                btnBrisi.Enabled = false;
            }
        }
    }
}
