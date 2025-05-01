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
        public EditarMeta()
        {
            InitializeComponent();
        }

        private void ConclusaoEditarMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres não permitidos
            }
        }

        private void ConclusaoEditarMeta_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja número
            string texto = new string(txtConclusaoMeta.Text.Where(char.IsDigit).ToArray());

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
            txtConclusaoMeta.Text = texto;

            // Mantém o cursor no final do texto
            txtConclusaoMeta.SelectionStart = txtConclusaoMeta.Text.Length;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtConclusaoMeta.Text, out DateTime dataValida))
            {
                MessageBox.Show($"Data salva: {dataValida.ToString("dd/MM/yyyy")}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
