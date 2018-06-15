using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            povrni.Enabled = false;
        }

        private void spremeni_Click(object sender, EventArgs e)
        {
            label1.Text = "Nov Napis";
            povrni.Enabled = true;
            spremeni.Enabled = false;
        }

        private void povrni_Click(object sender, EventArgs e)
        {
            label1.Text = "Originalen Napis";
            povrni.Enabled = false;
            spremeni.Enabled = true;
        }
    }
}
