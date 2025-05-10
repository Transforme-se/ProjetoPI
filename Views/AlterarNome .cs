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
using ProjetoPI.Services;

namespace ProjetoPI.Views
{
    public partial class AlterarNome: Form
    {
        private readonly AlterarNomeController _alterarNomeController;

        public AlterarNome()
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            _alterarNomeController = new AlterarNomeController(dataBaseService);
            lblNomeAtual.Text = SessaoUsuario.usuarioLogado.Nome;
        }

        private void AlterarNome_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja alterar o nome?", "Alterar Nome", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (_alterarNomeController.AlterarNome(txtNovoNome.Text))
                {
                    MessageBox.Show("Nome alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o nome. Verifique se o novo nome é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
