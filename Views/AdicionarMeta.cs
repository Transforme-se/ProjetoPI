using ProjetoPI.Controllers;
using ProjetoPI.Services;
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
    public partial class AdicionarMeta: Form
    {
        private readonly DataBaseService _dataBaseService;
        private TelaPrincipal _telaPrincipal;
        private ControllerMetas _controllerMetas;
        private MensagemController _MensagemController;
        public AdicionarMeta(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            _dataBaseService = new DataBaseService();
            _controllerMetas = new ControllerMetas(_dataBaseService);
            _MensagemController = new MensagemController(_dataBaseService);
            _telaPrincipal = telaPrincipal;
        }

        private void FormatacaoDataMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres não permitidos
            }
        }

        private void FormatacaoDataMeta_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja número
            string texto = new string(txtDataConclusao.Text.Where(char.IsDigit).ToArray());

            // Aplica a formatação "dd/MM/yyyy" conforme o comprimento do texto
            if (texto.Length >= 2)
            {
                texto = texto.Insert(2, "/");
            }
            if (texto.Length >= 5)
            {
                texto = texto.Insert(5, "/");
            }

            // Atualiza o texto no KryptonTextBox
            txtDataConclusao.Text = texto;

            // Mantém o cursor no final do texto
            txtDataConclusao.SelectionStart = txtDataConclusao.Text.Length;
        }

        private async void btnSalvarMeta_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloMeta.Text;
            string descricao = txtDescricaoMeta.Text;

            // Tenta converter a data, mas permite que ela seja nula
            DateTime? dataConclusao = null;
            if (DateTime.TryParse(txtDataConclusao.Text, out DateTime dataValida))
            {
                dataConclusao = dataValida;
            }

            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("Por favor, preencha o título da meta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var meta = _controllerMetas.CadastrarMetas(titulo, descricao, dataConclusao);
            if (meta != null)
            {
                this.Close();

                await _MensagemController.MostrarMensagem(0);
                _telaPrincipal.AtualizarMetas();

                await Task.Delay(900);
            }
        }
    }
}
