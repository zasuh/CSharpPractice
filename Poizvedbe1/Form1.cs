using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poizvedbe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sQL1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL1 drugoOkno = new FormSQL1();

            drugoOkno.ShowDialog();

        }
    }

        private void sQL2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL2 tretjeOkno = new FormSQL2();

            tretjeOkno.ShowDialog();
        }
    }
}
