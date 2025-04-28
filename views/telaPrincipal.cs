using System;
using System.Windows.Forms;
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
            tabela.DataSource = _controllerMetas.ObterTodasMetas();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            // Abre uma janela para selecionar a imagem
            
        }

        private void btnNovaMeta_Click(object sender, EventArgs e)
        {
            AdicionarMeta adicionarMeta = new AdicionarMeta();
            adicionarMeta.Show();
        }

        private void btnEditarMeta_Click(object sender, EventArgs e)
        {

        }
    }
}
