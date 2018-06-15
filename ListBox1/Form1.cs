using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtVnos.Focus();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtVnos.Text != "")
            {
                listSeznam.Items.Add(txtVnos.Text);
                txtVnos.Text = "";
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            listSeznam.Sorted = true;
            listSeznam.Sorted = false;
            txtVnos.Focus();
        }

        private void btnPobrisiVse_Click(object sender, EventArgs e)
        {
            listSeznam.Items.Clear();
        }

        private void btnPobrisiIzbran_Click(object sender, EventArgs e)
        {
            listSeznam.Items.SelectedIndex = -1;
        }
    }
}
