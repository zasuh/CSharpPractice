using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrenosParametrov1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVnesiPriimek_Click(object sender, EventArgs e)
        {

            //deluje, če preobložimo konstruktor (txtIme lahko ostane privaten)

            Form2 drugaForma = new Form2(txtIme.Text);

            //deluje, če je txtPriimek na drugi formi javen ali internal

            if (drugaForma.ShowDialog() == DialogResult.OK)

                txtPriimek.Text = drugaForma.txtPriimek.Text;

            //modalen obrazec se pri zapiranju le skrije, uniči pa se ne

            drugaForma.ShowDialog();
        }

        private void txtPriimek_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
