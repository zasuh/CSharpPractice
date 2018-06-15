using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxLabelButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPovrni_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Lep pozdrav";
            btnPovrni.Enabled = false;
            btnPobrisi.Enabled = true;
        }

        private void btnPobrisi_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            btnPovrni.Enabled = true;
            btnPobrisi.Enabled = false;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender == this)
            {
                if ((e as MouseEventArgs).Button == MouseButtons.Left)
                {
                    textBox1.Text = "Lep pozdrav";
                }
                if ((e as MouseEventArgs).Button == MouseButtons.Right)
                {
                    textBox1.Clear();
                }
            }
        }
    }
}
