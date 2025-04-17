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
using ProjetoPI.Services;

namespace ProjetoPI.Views
{
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            ArredondarPainel.Arredondar(painelEsquerdo, 30);
            ArredondarPainel.Arredondar(painelDireito, 30);

            try
            {
                using (var dbService = new DataBaseService())
                {
                    dbService.OpenConnection();
                    MessageBox.Show("Conexão com o banco de dados bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void t(object sender, PaintEventArgs e)
        {
            
        }

        private void painelDireito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Hint = "Digite seu usuário";
           
            

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {
            txtSenhaLogin.Hint = "Digite sua senha";
           

        }

        private void txtNovoUsuario_TextChanged(object sender, EventArgs e)
        {
            txtNovoUsuario.Hint = "Digite seu usuário";
            txtNovoUsuario.StateActive.Content.Color1 = Color.Gray;
        }

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {
            txtSenhaCadastro.Hint = "Digite sua senha...";
            txtSenhaCadastro.StateActive.Content.Color1 = Color.Gray;
        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {
            txtConfSenha.Hint = "Confirme sua senha..";
            txtConfSenha.StateActive.Content.Color1 = Color.Gray;
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            new ControllerLoginCadastro().Login(txtUsuario.Text, txtSenhaLogin.Text);
        }

        private void Concluir_Click(object sender, EventArgs e)
        {
            try 
            {
                new ControllerLoginCadastro().Cadastrar(txtNovoUsuario.Text, txtSenhaCadastro.Text, txtConfSenha.Text);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
