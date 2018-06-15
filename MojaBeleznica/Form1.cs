using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaBeleznica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string datoteka { get; private set; }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = datoteka;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    //ime datoteke s polno potjo shranimo v datoteka
                    datoteka = saveFileDialog1.FileName;
                    this.Text = "Moja beležnica - " + datoteka;
                    richTextBox1.Modified = false;
                }

                catch (Exception ex)
                {
                    String imeDatoteke;
                    imeDatoteke = System.IO.Path.GetFileName(datoteka);
                    //če damo using namespace System.IO, lahko samo Path.
                    MessageBox.Show("Datoteke " + imeDatoteke + " ni bilo mogoče shraniti.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datoteka != "")
            {
                try
                {
                    richTextBox1.SaveFile(datoteka, RichTextBoxStreamType.PlainText);
                    richTextBox1.Modified = false;
                }

                catch (Exception ex)
                {
                    String imeDatoteke;
                    imeDatoteke = System.IO.Path.GetFileName(datoteka);
                    //če damo using namespace System.IO, lahko samo Path.
                    MessageBox.Show("Datoteke " + imeDatoteke + " ni bilo mogoče shraniti.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else saveAsToolStripMenuItem_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)

            {
                DialogResult res;
                res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",
                "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes) saveToolStripMenuItem_Click(sender, e);
                else if (res == DialogResult.Cancel) return;
            }

            richTextBox1.Clear();
            this.Text = "Moja beležnica";
            datoteka = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)

            {

.DialogResult res;

                res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",

                "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res ==.DialogResult.Cancel) return;

                else if (res ==.DialogResult.Yes) saveToolStripMenuItem_Click(sender, e);

            }

            openFileDialog1.FileName = "";

            try

            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                {

                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                    datoteka = openFileDialog1.FileName;

                    this.Text = "Moja beležnica - " + datoteka;

                    richTextBox1.Modified = false;

                }

            }

            catch (Exception ex)

            {

                String imeDatoteke;

                imeDatoteke = System.IO.Path.GetFileName(datoteka);

                //če damo using namespace System.IO, lahko samo Path.

                MessageBox.Show("Datoteke " + imeDatoteke + " ni bilo mogoče odpreti.",

                "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified)

            {

                DialogResult res;

                res = MessageBox.Show("Trenutna datoteka se je spremenila. Shranim spremembe?",

                "Moja beležnica", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Cancel) e.Cancel = true;

                else if (res == DialogResult.Yes) saveToolStripMenuItem_Click(sender, e);

            }
        }
    }
}
