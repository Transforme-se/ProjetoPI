using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPI.Models.Usuarios;
using ProjetoPI.Services;

namespace ProjetoPI.Controllers
{
    class ControllerAlterarSenha
    {
        private string senhaAtual;
        private string novaSenha;
        private string confirmarSenha;
        private ValidarCadastro _validar;
        private UsuariosRepository _usuariosRepository;

        public ControllerAlterarSenha(string senhaAtual, string novaSenha, string confirmarSenha)
        {
            this.senhaAtual = senhaAtual;
            this.novaSenha = novaSenha;
            this.confirmarSenha = confirmarSenha;
            _validar = new ValidarCadastro();
            _usuariosRepository = new UsuariosRepository(new DataBaseService());
        }

        private bool ValidarSenhaNova()
        {
            return _validar.ValidarSenha(novaSenha) && novaSenha.Equals(confirmarSenha);
        }

        private bool ConfimarSenha()
        {
            return Criptografia.HashSenha(senhaAtual).Equals(SessaoUsuario.usuarioLogado.SenhaHash);
        }
        public bool AlterarSenhaUsuario()
        {
            if (ConfimarSenha() && ValidarSenhaNova())
            {
                _usuariosRepository.AlterarSenha(SessaoUsuario.usuarioLogado.Id, Criptografia.HashSenha(novaSenha));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
