using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxRadioButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKopiraj_Click(object sender, EventArgs e)
        {
            string input1 = vnos1.Text;
            string input2 = vnos2.Text;
            vnos1.Text = input2;
            vnos2.Text = input1;
        }

        private void btnPobrisi_Click(object sender, EventArgs e)
        {
            vnos1.Text = "";
            vnos2.Text = "";
        }
    }
}
