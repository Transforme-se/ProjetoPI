using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Krypton.Toolkit;
using ProjetoPI.Controllers;
using ProjetoPI.Models.Metas;
using ProjetoPI.Services;
using System.Threading.Tasks;
using ProjetoPI.Models.Usuarios;

namespace ProjetoPI.Views
{
    public partial class TelaPrincipal : Form
    {
        private MetasRepository _metasRepository;
        private ControllerMetas _controllerMetas;
        private ControllerFiltro _controllerFiltro;
        private MensagemController _mensagemController;
        private ExcluirContaController _excluirContaController;
        private int idMetaSelecionada;
        public TelaPrincipal(Models.Usuarios.Usuarios user)
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            _metasRepository = new MetasRepository(dataBaseService);
            _controllerMetas = new ControllerMetas(dataBaseService);
            _mensagemController = new MensagemController(dataBaseService);
            _controllerFiltro = new ControllerFiltro(_controllerMetas);
            _excluirContaController = new ExcluirContaController(dataBaseService);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelFundo, 30);
            ArredondarPainel.Arredondar(painelMenu, 30);
            ArredondarPainel.Arredondar(painelMetas, 30);
            lbUser.Text = SessaoUsuario.usuarioLogado.Nome;
            AtualizarImagemUsuario();
            AtualizarMetas();
        }

        public void AtualizarImagemUsuario()
        {
            // Lógica para atualizar a imagem do usuário
            ControllerAlterarFoto.AtualizarFoto(imgUser, SessaoUsuario.usuarioLogado.FotoPerfil);
        }

        public void AtualizarMetas()
        {
            List<Metas> metas = _controllerMetas.ObterTodasMetas();
            tabela.DataSource = metas;
            if (metas == null || metas.Count == 0)
                painalMetaVazia.Visible = true;
            else
                painalMetaVazia.Visible = false;
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
        private async void Tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                if (meta.status == false)
                {
                    await _mensagemController.MostrarMensagem(0);
                    AtualizarMetas();
                }
                else
                {
                    AtualizarMetas();
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
            
            List<Metas> metasFiltradas = _controllerFiltro.ObterMetasFiltradasTexto(txtBusca.Text);
            if (_controllerFiltro.VerificarMetasVazias(metasFiltradas))
                  painalMetaVazia.Visible = true;
            else
                painalMetaVazia.Visible = false;
            tabela.DataSource = metasFiltradas;
          
            btnLimparFiltro.Visible = true;
        }

        private void BtnLimparFiltro_Click(object sender, EventArgs e)
        {
            _controllerFiltro.LimparFiltro();
            txtBusca.Text = string.Empty;
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
            painalMetaVazia.Visible = _controllerFiltro.VerificarMetasVazias(_controllerMetas.ObterTodasMetas());
            btnLimparFiltro.Visible = false;
        }

        // Filtro por data

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
                txtBusca.Text = string.Empty; // Limpa o campo de busca
                List<Metas> metasFiltradas = _controllerFiltro.ObterMetasFiltradasData(currentSelectedDate);
                tabela.DataSource = metasFiltradas;
                if (_controllerFiltro.VerificarMetasVazias(metasFiltradas))
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

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            new AlterarSenha().Show();
        }

        private void BtnAlterarFoto_Click(object sender, EventArgs e)
        {
            using (AlterarFotoPerfil alterarFoto = new AlterarFotoPerfil())
            {
                alterarFoto.ShowDialog(); // Isso faz a execução esperar até o form fechar
                AtualizarImagemUsuario(); // Chama a atualização diretamente após o fechamento
            }
        }

        private void btnAlterarNome_Click(object sender, EventArgs e)
        {
            AlterarNome alterarNome = new AlterarNome();
            alterarNome.ShowDialog();
            lbUser.Text = SessaoUsuario.usuarioLogado.Nome;

        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir sua conta? Esta ação não pode ser desfeita.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                _excluirContaController.ExcluirConta(SessaoUsuario.usuarioLogado.Id);
                MessageBox.Show("Conta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            Application.Exit();
        }
    }
}
