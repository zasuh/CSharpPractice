using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezeciGumb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Uspeh!";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label2.Text = "Fail!";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

            int x, y;

            Random rndm = new Random();
            Point velKlientaForme = new Point(ClientSize);

            do
            {
                x = rndm.Next(velKlientaForme.X - button1.Width); //tako da bo cel gumb v klientu forme
            }
            while ((x >= (button1.Left - button1.Width)) && (x <= button1.Right));

            do
            {
                y = rndm.Next(velKlientaForme.Y - button1.Height); //tako da bo cel gumb v klientu forme
            }
            while ((y >= (button1.Top - button1.Height)) && (y <= button1.Bottom));

            button1.Location = new Point(x, y);
        }
    }
}
