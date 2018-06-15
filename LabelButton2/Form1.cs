using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Povrni.Enabled = false;
        }

        private void spremeni_Click(object sender, EventArgs e)
        {
            label1.Text = "Changed Text";
            Povrni.Enabled = true;
            spremeni.Enabled = false;
        }

        private void Povrni_Click(object sender, EventArgs e)
        {
            label1.Text = "Original Text";
            Povrni.Enabled = false;
            spremeni.Enabled = true;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                label1.Text = "Changed Text";
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                label1.Text = "Original Text";
            }
        }
    }
}
