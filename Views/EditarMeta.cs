using ProjetoPI.Controllers;
using ProjetoPI.Models.Metas;
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
    public partial class EditarMeta: Form
    {
        private Metas _meta;
        private ControllerMetas _controllerMetas;
        private bool _backspacePressionado = false;
        public EditarMeta(ControllerMetas controllerMetas, Metas meta)
        {
            InitializeComponent();
            
            _controllerMetas = controllerMetas;
            _meta = meta;

            txtTituloMeta.Text = _meta.Titulo;
            txtDescricaoMeta.Text = _meta.Descricao;
            txtConclusaoMeta.Text = _meta.DataConclusao.HasValue ? _meta.DataConclusao.Value.ToString("dd/MM/yyyy") : string.Empty;
        }

        private void ConclusaoEditarMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres não permitidos
            }
        }

        private void txtConclusaoMeta_KeyDown(object sender, KeyEventArgs e)
        {
            // Detecta se o backspace foi pressionado
            if (e.KeyCode == Keys.Back)
            {
                _backspacePressionado = true;
            }
        }

        private void txtConclusaoMeta_KeyUp(object sender, KeyEventArgs e)
        {
            // Reseta o estado do backspace após a tecla ser liberada
            if (e.KeyCode == Keys.Back)
            {
                _backspacePressionado = false;
            }
        }

        private void ConclusaoEditarMeta_TextChanged(object sender, EventArgs e)
        {
            // Salva a posição atual do cursor
            int posicaoCursor = txtConclusaoMeta.SelectionStart;

            // Remove qualquer caractere que não seja número
            string textoOriginal = txtConclusaoMeta.Text;
            string textoFormatado = _controllerMetas.FormatarTextoData(textoOriginal);

            // Verifica se o texto foi alterado
            if (textoOriginal != textoFormatado)
            {
                txtConclusaoMeta.Text = textoFormatado;

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
                txtConclusaoMeta.SelectionStart = Math.Max(0, Math.Min(posicaoCursor, textoFormatado.Length));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloMeta.Text;
            string descricao = txtDescricaoMeta.Text;
            DateTime? dataConclusao = null;

            if (!string.IsNullOrWhiteSpace(txtConclusaoMeta.Text) && DateTime.TryParse(txtConclusaoMeta.Text, out DateTime dataValida))
            {
                dataConclusao = dataValida;
            }

            _meta.Titulo = titulo;
            _meta.Descricao = descricao;
            _meta.DataConclusao = dataConclusao;

            // Atualiza a meta no banco de dados
            _controllerMetas.EditarMeta(_meta.Id, _meta.Titulo, _meta.Descricao, _meta.DataConclusao?.ToString("yyyy-MM-dd"));

            MessageBox.Show("Meta atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void brnExcluirMeta_Click(object sender, EventArgs e)
        {
            _controllerMetas.ExcluirMeta(_meta.Id);

            MessageBox.Show("Meta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtTituloMeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarMeta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
