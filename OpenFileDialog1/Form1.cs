using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRaztegni_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Normal)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtPot.Text = openFileDialog1.FileName;
            this.Text = "Slika - " + System.IO.Path.GetFileName(openFileDialog1.FileName);

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
