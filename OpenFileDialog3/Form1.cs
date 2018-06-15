using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog3
{
    public partial class Form1 : Form
    {
        String imeDatoteke;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imeDatoteke = openFileDialog1.FileName;
                    richTextBox1.LoadFile(imeDatoteke, RichTextBoxStreamType.PlainText);
                    this.Text = "Moja beležnica - " + imeDatoteke;
                }
            }
            catch (Exception ex)
            {
                imeDatoteke = System.IO.Path.GetFileName(imeDatoteke);
                MessageBox.Show("Datoteke " + imeDatoteke + " ni bilo mogoče odpreti.",
                "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
