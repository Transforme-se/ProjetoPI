using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoPI.Controllers;
using ProjetoPI.Models.Metas;
using ProjetoPI.Services;

namespace ProjetoPI.Views
{
    public partial class TelaPrincipal : Form
    {
        private MetasRepository _metasRepository;
        private ControllerMetas _controllerMetas;
        private int idMetaSelecionada;
        public TelaPrincipal(Models.Usuarios.Usuarios user)
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            _metasRepository = new MetasRepository(dataBaseService);
            _controllerMetas = new ControllerMetas(dataBaseService);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelMenu, 30);
            ArredondarPainel.Arredondar(painelMetas, 30);
            lbUser.Text = SessaoUsuario.usuarioLogado.Nome;
            AtualizarMetas();
        }

        public void AtualizarMetas()
        {
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
        }

        private void BtnNovaMeta_Click(object sender, EventArgs e)
        {
            AdicionarMeta adicionarMeta = new AdicionarMeta(this);
            adicionarMeta.Show();
        }


        private void BtnEditarMeta_Click(object sender, EventArgs e)
        {
            if (idMetaSelecionada <= 0)
            {
                MessageBox.Show("Por favor, selecione uma meta para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca a meta pelo ID
            var meta = _controllerMetas.ObterMetasPorId(idMetaSelecionada);
            if (meta == null)
            {
                MessageBox.Show("Meta não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre o formulário de edição com os dados da meta
            EditarMeta editarMeta = new EditarMeta(_controllerMetas, meta);
            editarMeta.ShowDialog();

            // Atualiza a tabela após a edição
            AtualizarMetas();
        }

        //Editar status da meta
        private void Tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é da coluna "status"
            if (tabela.Columns[e.ColumnIndex].Name == "status" && e.RowIndex >= 0)
            {
                // Obtém a meta correspondente
                Metas meta = (Metas)tabela.Rows[e.RowIndex].DataBoundItem;

                // Alterna o valor do status
                bool novoStatus = !meta.status;

                bool sucesso = _controllerMetas.EditarStatus(new Metas
                {
                    Id = meta.Id,
                    status = novoStatus
                });

                if (sucesso)
                {
                    MessageBox.Show("Status atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarMetas(); // Atualiza a tabela
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o status.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Verifica qual é a linha selecionada
        private void Tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMetaSelecionada = (int)tabela.Rows[e.RowIndex].Cells["id"].Value;
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusca.Text))
            {
                List<Metas> metasFiltradas = _controllerMetas.ObterMetasFiltradas(txtBusca.Text);
                if (VerificarMetasVazias(metasFiltradas))
                    painalMetaVazia.Visible = true;
                else
                    painalMetaVazia.Visible = false;
                tabela.DataSource = metasFiltradas;
                btnLimparFiltro.Visible = true;
            }
            else
            {
                tabela.DataSource = _controllerMetas.ObterTodasMetas();
                btnLimparFiltro.Visible = false;
            }
        }

        private bool VerificarMetasVazias(List<Metas> metas)
        {
            if (metas == null || metas.Count == 0)
                return true;
            return false;
        }

        private void BtnLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBusca.Text = string.Empty;
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
            painalMetaVazia.Visible = false;
            btnLimparFiltro.Visible = false;
        }

        private DateTime? lastSelectedDate = null;
        private bool ignoreNextChange = false;

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (ignoreNextChange)
            {
                ignoreNextChange = false;
                return;
            }

            DateTime currentSelectedDate = calendario.SelectionStart;

            if (!lastSelectedDate.HasValue || currentSelectedDate != lastSelectedDate.Value)
            {
                lastSelectedDate = currentSelectedDate;
                List<Metas> metasFiltradas = _controllerMetas.ObterMetasFiltradasData(currentSelectedDate);
                tabela.DataSource = metasFiltradas;
                if (VerificarMetasVazias(metasFiltradas))
                    painalMetaVazia.Visible = true;
                else
                    painalMetaVazia.Visible = false;
                btnLimparFiltro.Visible = true;
            }
        }

        private void Calendario_MouseDown(object sender, MouseEventArgs e)
        {
            // Verifica se o clique foi nos botões de navegação
            // Isso é uma aproximação, pois não temos HitTest no Krypton
            ignoreNextChange = true;
        }

        private void Calendario_MouseUp(object sender, MouseEventArgs e)
        {
            ignoreNextChange = false;
        }
    }
}
