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
using ProjetoPI.Controllers;
using ProjetoPI.Models.Metas;
using ProjetoPI.Services;

namespace ProjetoPI.Views
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelMenu, 30);
            ArredondarPainel.Arredondar(painelMetas, 30);
            tabela.DataSource = new ControllerMetas(new DataBaseService()).ObterTodasMetas();
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é da coluna "status"
            if (tabela.Columns[e.ColumnIndex].Name == "kryptonDataGridViewCheckBoxColumn1" && e.RowIndex >= 0)
            {
                // Obtém a meta correspondente
                Metas meta = (Metas)tabela.Rows[e.RowIndex].DataBoundItem;

                // Alterna o valor do status
                meta.status = !meta.status;

                // Atualiza o banco de dados
                //bool atualizado = new ControllerMetas(new DataBaseService()).AtualizarStatus(meta.Id, meta.status);

                //if (!atualizado)
                //{
                //    MessageBox.Show("Erro ao atualizar o status no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
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
    }
}
