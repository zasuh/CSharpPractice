using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarTimer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnUstavi.Enabled = false;
            btnNadaljuj.Enabled = false;

            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNalozi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nalagam...";
            progressBar1.Value = progressBar1.Minimum;
            timer1.Start();

            btnUstavi.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                textBox1.Text = "Naloženo!";
            }
            label1.Text = progressBar1.Value.ToString() + "%";
        }

        private void btnUstavi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnNadaljuj.Enabled = true;
        }

        private void btnNadaljuj_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
