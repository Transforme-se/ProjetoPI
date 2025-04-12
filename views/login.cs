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
    }
}
