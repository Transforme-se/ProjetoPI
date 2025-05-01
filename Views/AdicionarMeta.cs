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
        private telaPrincipal _telaPrincipal;
        private ControllerMetas _controllerMetas;
        public AdicionarMeta(telaPrincipal telaPrincipal)
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            _controllerMetas = new ControllerMetas(dataBaseService);
            _telaPrincipal = telaPrincipal;
        }

        private void btnSalvarMeta_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTituloMeta.Text;
                string descricao = txtDescricaoMeta.Text;
                DateTime dataConclusao = DataConclusaoMeta.Value;

                if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(descricao))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var meta = _controllerMetas.CadastrarMetas(titulo, descricao, dataConclusao);
                if (meta != null)
                {
                    MessageBox.Show("Meta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _telaPrincipal.AtualizarMetas();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a meta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a meta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
