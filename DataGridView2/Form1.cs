using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabela.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            if (tabela.CurrentRow != null) {
                textBox1.Text = Convert.ToString(tabela.CurrentRow.Cells["colIme"].Value);
                textBox2.Text = Convert.ToString(tabela.CurrentRow.Cells["colPriimek"].Value);
                textBox3.Text = Convert.ToString(tabela.CurrentRow.Cells["colNaslov"].Value);
            }
        }
    }
}
