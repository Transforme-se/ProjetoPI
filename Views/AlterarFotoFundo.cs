using ProjetoPI.Models.Usuarios;
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
    public partial class AlterarFotoFundo : Form
    {
        private int _fundoAtivo = SessaoUsuario.usuarioLogado.FotoFundo;
        private UsuariosRepository _usuarioRepository;
        public AlterarFotoFundo()
        {
            InitializeComponent();
        }

        private void AlterarFotoFundo_Load(object sender, EventArgs e)
        {
            _usuarioRepository = new UsuariosRepository(new DataBaseService());
            SelecionarFundo(_fundoAtivo);
        }

        private void Fundo_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.PictureBox pictureBox)
            {
                string pictureBoxName = pictureBox.Name;
                switch (pictureBoxName)
                {
                    case "fundo0":
                        _fundoAtivo = 0;
                        break;
                    case "fundo1":
                        _fundoAtivo = 1;
                        break;
                    case "fundo2":
                        _fundoAtivo = 2;
                        break;
                    case "fundo3":
                        _fundoAtivo = 3;
                        break;
                    case "fundo4":
                        _fundoAtivo = 4;
                        break;
                    case "fundo5":
                        _fundoAtivo = 5;
                        break;
                }
            }
            SelecionarFundo(_fundoAtivo);
        }

        private void SelecionarFundo(int fundoAtivo)
        {
            panelFoto0.BackColor = Color.Transparent;
            panelFoto1.BackColor = Color.Transparent;
            panelFoto2.BackColor = Color.Transparent;
            panelFoto3.BackColor = Color.Transparent;
            panelFoto4.BackColor = Color.Transparent;
            panelFoto5.BackColor = Color.Transparent;

            switch (fundoAtivo)
            {
                case 0:
                    panelFoto0.BackColor = Color.Gray;
                    break;
                case 1:
                    panelFoto1.BackColor = Color.Gray;
                    break;
                case 2:
                    panelFoto2.BackColor = Color.Gray;
                    break;
                case 3:
                    panelFoto3.BackColor = Color.Gray;
                    break;
                case 4:
                    panelFoto4.BackColor = Color.Gray;
                    break;
                case 5:
                    panelFoto5.BackColor = Color.Gray;
                    break;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (_fundoAtivo != SessaoUsuario.usuarioLogado.FotoFundo)
            {
                _usuarioRepository.AlterarFotoFundo(SessaoUsuario.usuarioLogado.Id, _fundoAtivo);
                SessaoUsuario.usuarioLogado.FotoFundo = _fundoAtivo;
            }
            Close();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
