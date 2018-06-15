using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezeciGumb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            Point miska = PointToClient(MousePosition);

            Point gumb = button1.Location;

            if (miska.X < gumb.X + button1.Width / 2)
                gumb.X += 25; //če miška levo od sredine gumba gumb v desno za 25 pik
            else
                gumb.X -= 25; //in obratno
            if (miska.Y < gumb.Y + button1.Height / 2)
                gumb.Y += 25; //če miška nad polovico gumba gumb dol za 25 pik
            else
                gumb.Y -= 25; //in obratno

            Point velKlientaForme = new Point(ClientSize); //velikost klienta forme

            if (gumb.X < 0) gumb.X = velKlientaForme.X - (button1.Width);
            else if (gumb.X > velKlientaForme.X - button1.Width) gumb.X = 0;

            //pazimo, da se gumb ne skrije za ProgressBar

            if (gumb.Y < 0) gumb.Y = velKlientaForme.Y - progressBar1.Height - button1.Height;
            else if (gumb.Y > velKlientaForme.Y - progressBar1.Height - button1.Height) gumb.Y = 0;

            button1.Location = gumb;
        }
    }
    }
}
