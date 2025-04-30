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
        private int idMetaSelecionada;

        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelMenu, 30);
            ArredondarPainel.Arredondar(painelMetas, 30);
            tabela.DataSource = new ControllerMetas(new DataBaseService()).ObterTodasMetas();
            lbUser.Text = SessaoUsuario.usuarioLogado.Nome;
        }

        private void Tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é da coluna "status"
            if (tabela.Columns[e.ColumnIndex].Name == "kryptonDataGridViewCheckBoxColumn1" && e.RowIndex >= 0)
            {
                // Obtém a meta correspondente
                Metas meta = (Metas)tabela.Rows[e.RowIndex].DataBoundItem;

                // Alterna o valor do status
                meta.status = !meta.status;
            }
        }

        private void BtnNovaMeta_Click(object sender, EventArgs e)
        {

        }

        private void Tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMetaSelecionada = (int)tabela.Rows[e.RowIndex].Cells["id"].Value;
        }
        private void BtnEditarMeta_Click(object sender, EventArgs e)
        {
           
        }
    }
}
