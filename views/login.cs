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
    public partial class login : Form
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

        private void txtUsuario_TextChanged(object sender, EventArgs e) { }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {
        }


       

        private void painelEsquerdo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonPictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {// Adiciona um PictureBox sobre o KryptonTextBox

        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }



     

        private void txtSenhaConf_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

      
    


