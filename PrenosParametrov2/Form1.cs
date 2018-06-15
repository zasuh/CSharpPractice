using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrenosParametrov2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPriimek_Click(object sender, EventArgs e)
        {
            //deluje, če je na drugi formi javna ali interna metoda SetIme

            Form2 drugaForma = new Form2();

            drugaForma.SetIme(txtIme.Text);

            //deluje, če je na drugi formi javna ali interna metoda getPriimek

            if (drugaForma.ShowDialog() == DialogResult.OK)

                txtPriimek.Text = drugaForma.GetPriimek();
        }
    }
}
