using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI.Views
{
    public partial class configuracoes : Form
    {
        public configuracoes()
        {
            InitializeComponent();
        }

        private void kryptonPictureBox2_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog janela = new OpenFileDialog();
                janela.Filter = "Imagens|*.jpg;*.png;*.bmp";

                if (janela.ShowDialog() == DialogResult.OK)
                {
                    // Carrega a imagem no PictureBox
                    kryptonPictureBox2.Image = Image.FromFile(janela.FileName);
                }
            }
        }
    }
}