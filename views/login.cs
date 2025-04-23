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
            ArredondarPainel.Arredondar(painel1, 30);

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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var mover = new PainelLogin();
            mover.MoverPainel(painel1, 688);
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            var mover = new PainelLogin();
            mover.MoverPainel(painel1, 13);
        }
    }
}
