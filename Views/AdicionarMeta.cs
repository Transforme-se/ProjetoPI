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
        private bool _backspacePressionado = false;
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

        private void txtDataConclusao_KeyDown(object sender, KeyEventArgs e)
        {
            // Detecta se o backspace foi pressionado
            if (e.KeyCode == Keys.Back)
            {
                _backspacePressionado = true;
            }
        }

        private void txtDataConclusao_KeyUp(object sender, KeyEventArgs e)
        {
            // Reseta o estado do backspace após a tecla ser liberada
            if (e.KeyCode == Keys.Back)
            {
                _backspacePressionado = false;
            }
        }

        private void FormatacaoDataMeta_TextChanged(object sender, EventArgs e)
        {
            // Salva a posição atual do cursor
            int posicaoCursor = txtDataConclusao.SelectionStart;

            // Remove qualquer caractere que não seja número
            string textoOriginal = txtDataConclusao.Text;
            string textoFormatado = _controllerMetas.FormatarTextoData(textoOriginal);

            // Verifica se o texto foi alterado
            if (textoOriginal != textoFormatado)
            {
                txtDataConclusao.Text = textoFormatado;

                // Ajusta a posição do cursor
                if (_backspacePressionado && posicaoCursor > 0)
                {
                    // Verifica se o cursor está em uma posição válida antes de acessar o índice
                    if (posicaoCursor > 1 && posicaoCursor <= textoFormatado.Length && textoFormatado[posicaoCursor - 1] == '/')
                    {
                        posicaoCursor--;
                    }
                    posicaoCursor--; // Move o cursor para trás
                }
                else
                {
                    int diferenca = textoFormatado.Length - textoOriginal.Length;
                    posicaoCursor += diferenca;
                }

                // Garante que a posição do cursor esteja dentro dos limites do texto
                txtDataConclusao.SelectionStart = Math.Max(0, Math.Min(posicaoCursor, textoFormatado.Length));
            }
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
