using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                cmb.Items.Add(txt.Text);
                txt.Text = "";
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            cmb.Sorted = true;
            cmb.Sorted = false;
            txt.Focus();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt.Text += cmb.SelectedItem.ToString() + "\n";
        }
    }
}
