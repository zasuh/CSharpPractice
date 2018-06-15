using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowHideTextBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            besedilo.Text = "Neki";
        }

        private void pokazi_Click(object sender, EventArgs e)
        {
            besedilo.Visible = true;
        }

        private void skrij_Click(object sender, EventArgs e)
        {
            besedilo.Visible = false;
        }

        private void besedilo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
