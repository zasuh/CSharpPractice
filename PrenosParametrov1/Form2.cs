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
    public partial class Form2 : Form
    {
        public Form2(String ime)
        {
            InitializeComponent();

            txtIme.Text = ime;
            txtPriimek.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtPriimek_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
