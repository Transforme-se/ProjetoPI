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
        public EditarMeta(ControllerMetas controllerMetas, Metas meta)
        {
            InitializeComponent();
            
            _controllerMetas = controllerMetas;
            _meta = meta;

            txtTituloMeta.Text = _meta.Titulo;
            txtDescricaoMeta.Text = _meta.Descricao;
            txtConclusaoMeta.Text = _controllerMetas.FormatarData(_meta.DataConclusao);
        }

        private void ConclusaoEditarMeta_TextChanged(object sender, EventArgs e)
        {
            // Use o método do Controller para formatar o texto
            txtConclusaoMeta.Text = _controllerMetas.FormatarTextoData(txtConclusaoMeta.Text);

            // Mantém o cursor no final do texto
            txtConclusaoMeta.SelectionStart = txtConclusaoMeta.Text.Length;
        }

        private void brnExcluirMeta_Click(object sender, EventArgs e)
        {
            _controllerMetas.ExcluirMeta(_meta.Id);

            MessageBox.Show("Meta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloMeta.Text;
            string descricao = txtDescricaoMeta.Text;
            string dataTexto = txtConclusaoMeta.Text;

            // Chama o método do Controller para editar a meta
            _controllerMetas.EditarMeta(_meta.Id, titulo, descricao, dataTexto);

            if (!string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Meta editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            
        } 
    }
}
