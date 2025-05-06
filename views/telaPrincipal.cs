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
    public partial class TelaPrincipal : Form
    {
        MetasRepository _metasRepository;
        ControllerMetas _controllerMetas;
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
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
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
            AdicionarMeta adicionarMeta = new AdicionarMeta();
            adicionarMeta.Show();
        }

        int idMetaSelecionada;
        private void Tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMetaSelecionada = (int)tabela.Rows[e.RowIndex].Cells["id"].Value;
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusca.Text))
            {
                List<Metas> metasFiltradas = _controllerMetas.ObterMetasFiltradas(txtBusca.Text);
                tabela.DataSource = metasFiltradas;
                btnLimparFiltro.Visible = true;
            }
            else
            {
                tabela.DataSource = _controllerMetas.ObterTodasMetas();
                btnLimparFiltro.Visible = false;
            }
        }

        private void BtnLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBusca.Text = string.Empty;
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
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
