using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMenuForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modelanoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void okno2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 drugoOkno = new Form2();
            drugoOkno.ShowDialog();
        }

        private void okno3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tretjeOkno = new Form3();
            tretjeOkno.Show();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About programOkno = new About();
            programOkno.Show();
        }

        private void okno2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 drugoOkno = new Form2();
            drugoOkno.ShowDialog();
        }

        private void okno3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 tretjeOkno = new Form3();
            tretjeOkno.Show();
        }

        private void oprogramuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About programOkno = new About();
            programOkno.Show();
        }
    }
}
