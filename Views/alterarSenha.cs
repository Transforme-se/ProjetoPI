using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPI.Controllers;

namespace ProjetoPI.Views
{
    public partial class AlterarSenha: Form
    {
        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja alterar a senha?", "Alterar Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (new ControllerAlterarSenha(txtSenhaAtual.Text, txtNovaSenha.Text, txtConfirmarSenha.Text).AlterarSenhaUsuario())
                {
                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar a senha. Verifique se a senha atual está correta e se as novas senhas são válidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtSenhaAtual.Focus();
        }
    }
}
