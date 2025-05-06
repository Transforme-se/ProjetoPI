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
        private TelaPrincipal _telaPrincipal;
        private ControllerMetas _controllerMetas;
        public AdicionarMeta(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            DataBaseService dataBaseService = new DataBaseService();
            _controllerMetas = new ControllerMetas(dataBaseService);
            _telaPrincipal = telaPrincipal;
        }

        private void FormatacaoDataMeta_TextChanged(object sender, EventArgs e)
        {
            // Use o método do Controller para formatar o texto
            txtDataConclusao.Text = _controllerMetas.FormatarTextoData(txtDataConclusao.Text);

            // Mantém o cursor no final do texto
            txtDataConclusao.SelectionStart = txtDataConclusao.Text.Length;
        }


        private void btnSalvarMeta_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloMeta.Text;
            string descricao = txtDescricaoMeta.Text;
            DateTime? dataConclusao = _controllerMetas.ConverterData(txtDataConclusao.Text);

            var meta = _controllerMetas.CadastrarMetas(titulo, descricao, dataConclusao);
            if (meta != null)
            {
                MessageBox.Show("Meta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _telaPrincipal.AtualizarMetas();
                this.Close();
            }
        }


    }
}
