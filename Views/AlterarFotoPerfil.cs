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
using ProjetoPI.Models.Metas;
using ProjetoPI.Models.Usuarios;
using ProjetoPI.Services;

namespace ProjetoPI.Views
{
    public partial class AlterarFotoPerfil: Form
    {
        private int _avatarAtivo = SessaoUsuario.usuarioLogado.FotoPerfil;
        private UsuariosRepository _usuarioRepository;
        public AlterarFotoPerfil()
        {
            InitializeComponent();
        }

        private void AlterarFotoPerfil_Load(object sender, EventArgs e)
        {
            _usuarioRepository = new UsuariosRepository(new DataBaseService());
            ArredondarPainel.Arredondar(painelAvatar0, 120);
            ArredondarPainel.Arredondar(painelAvatar1, 120);
            ArredondarPainel.Arredondar(painelAvatar2, 120);
            ArredondarPainel.Arredondar(painelAvatar3, 120);
            ArredondarPainel.Arredondar(painelAvatar4, 120);
            SelecionarAvatar(_avatarAtivo);
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            if (sender is KryptonPictureBox pictureBox)
            {
                string pictureBoxName = pictureBox.Name;
                switch (pictureBoxName)
                {
                    case "Avatar1":
                        _avatarAtivo = 1;
                        break;
                    case "Avatar2":
                        _avatarAtivo = 2;
                        break;
                    case "Avatar3":
                        _avatarAtivo = 3;
                        break;
                    case "Avatar4":
                        _avatarAtivo = 4;
                        break;
                    case "Avatar0":
                        _avatarAtivo = 0;
                        break;
                }
            }
            SelecionarAvatar(_avatarAtivo);
        }

        private void SelecionarAvatar(int avatarAtivo)
        {
            painelAvatar0.BackColor = Color.Transparent;
            painelAvatar1.BackColor = Color.Transparent;
            painelAvatar2.BackColor = Color.Transparent;
            painelAvatar3.BackColor = Color.Transparent;
            painelAvatar4.BackColor = Color.Transparent;
            switch (avatarAtivo)
            {
                case 0:
                    painelAvatar0.BackColor = Color.White;
                    break;
                case 1:
                    painelAvatar1.BackColor = Color.White;
                    break;
                case 2:
                    painelAvatar2.BackColor = Color.White;
                    break;
                case 3:
                    painelAvatar3.BackColor = Color.White;
                    break;
                case 4:
                    painelAvatar4.BackColor = Color.White;
                    break;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (_avatarAtivo != SessaoUsuario.usuarioLogado.FotoPerfil)
            {
                _usuarioRepository.AlterarFotoPerfil(SessaoUsuario.usuarioLogado.Id, _avatarAtivo);
                SessaoUsuario.usuarioLogado.FotoPerfil = _avatarAtivo;
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
