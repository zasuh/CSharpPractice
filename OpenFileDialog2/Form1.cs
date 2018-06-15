using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    this.Text = "Slika - " + System.IO.Path.GetFileName(openFileDialog1.FileName);
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                else
                {
                    textBox1.Text = "Datoteka ni bila izbrana!";
                    this.Text = "Slika";
                    pictureBox1.Image = null;
                }
            }
                catch (Exception ex)

                {
                    this.Text = "Slika";
                    pictureBox1.Image = null;
                    MessageBox.Show("Izbrane datoteke ne morem prikazati v PictureBoxu.", "Napaka",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        

        private void btnRaztegni_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Normal)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            } else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
