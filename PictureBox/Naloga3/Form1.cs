using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void odpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //DialogResult je v System.Windows.Forms.
                //Da dela kot zgoraj, je treba imeti zgoraj ustrezen using.
                {
                    
                    this.Text = "Slika - " + System.IO.Path.GetFileName(openFileDialog1.FileName);
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                else
                {
                    
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

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form form = new Form();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(pictureBox);

            form.ShowDialog();

            /*
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Dock = DockStyle.Fill;

            drugoOkno.Text = openFileDialog1.FileName;
            this.Text = "Slika - " + System.IO.Path.GetFileName(openFileDialog1.FileName);
            */
        }
    }
}
