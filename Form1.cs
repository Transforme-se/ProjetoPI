using ProjetoPI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AnimacaoLogin().TesteAnimacao(tableLayoutPanel1.Width - pictureBox1.Width+12, pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AnimacaoLogin().TesteAnimacao(12, pictureBox1);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Height = tableLayoutPanel1.Height;
            pictureBox1.Width = tableLayoutPanel1.Width/2;
            pictureBox1.Location = new Point(12, 12);
        }
    }
}
