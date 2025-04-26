using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ProjetoPI.Views
{
    public partial class telaPrincipal : Form
    {
        ControllerMetas controllerMetas;
        public telaPrincipal(Models.Usuarios.Usuarios user)
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            controllerMetas = new ControllerMetas(dataBaseService);

        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelMenu, 30);
            ArredondarPainel.Arredondar(painelMetas, 30);
            tabela.DataSource = controllerMetas.ObterTodasMetas();
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            // Abre uma janela para selecionar a imagem
            
            }
        

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
