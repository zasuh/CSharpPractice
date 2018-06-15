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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtPriimek.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void SetIme(string ime)

        {

            txtIme.Text = ime;

        }

        internal void SetIme(TextBox txtIme, string text)
        {
            throw new NotImplementedException();
        }

        public string GetPriimek()

        {

            return txtPriimek.Text;

        }
    }
}
