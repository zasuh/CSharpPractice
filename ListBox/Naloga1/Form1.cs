using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txtVnos.Focus();
        }

        private void txtVnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = txtVnos.Text.Trim();
            if (listBox1.Items.Contains(val))
            {
                label1.Text = "Element je že v tabeli.";
                txtVnos.Text = "";
            }
            else
            {
                label1.Text = "Element ne obstaja in je dodan.";
                listBox1.Items.Add(txtVnos.Text);
            }
        }
    }
}
