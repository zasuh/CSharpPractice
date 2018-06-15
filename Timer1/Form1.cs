using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form1 : Form
    {
        private int stevec;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStej_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            stevec = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stevec == 10) timer1.Enabled = false;

            else textBox1.Text = Convert.ToString(++stevec);
        }
    }
}
