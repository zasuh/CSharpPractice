using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowHideTextBox3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pokazi_Click(object sender, EventArgs e)
        {
            besedilo.Visible = true;
        }

        private void gumb_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name = skrij)
            {
                besedilo.Visible = false;
            } else
            {
                besedilo.Visible = true;
            }
        }

        private void skrij_Click(object sender, EventArgs e)
        {

        }
    }
}
