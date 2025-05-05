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
        MetasRepository _metasRepository;
        ControllerMetas _controllerMetas;
        public telaPrincipal(Models.Usuarios.Usuarios user)
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            _metasRepository = new MetasRepository(dataBaseService);
            _controllerMetas = new ControllerMetas(dataBaseService);
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelMenu, 30);
            ArredondarPainel.Arredondar(painelMetas, 30);
            lbUser.Text = SessaoUsuario.usuarioLogado.Nome;
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
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
            }
        }

        private void btnNovaMeta_Click(object sender, EventArgs e)
        {
            AdicionarMeta adicionarMeta = new AdicionarMeta();
            adicionarMeta.Show();
        }

        int idMetaSelecionada;
        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMetaSelecionada = (int)tabela.Rows[e.RowIndex].Cells["id"].Value;
        }
        private void btnEditarMeta_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusca.Text))
            {
                List<Metas> metasFiltradas = _controllerMetas.ObterMetasFiltradas(txtBusca.Text);
                tabela.DataSource = metasFiltradas;
            }
            else
            {
                tabela.DataSource = _controllerMetas.ObterTodasMetas();
            }
        }
    }
}
