using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ustvarimo Child formo
            Child newMDIChild = new Child();
            //nastavimo MdiParent na glavno formo
            newMDIChild.MdiParent = this;
            // Prikažemo Child formo
            newMDIChild.Show();


            try

            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
