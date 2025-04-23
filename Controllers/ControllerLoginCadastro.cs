using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPI.Models.Usuarios;
using ProjetoPI.Services;

namespace ProjetoPI.Controllers
{
    class ControllerLoginCadastro
    {
        public bool Login (string login, string senha)
        {
            AutenticacaoService autenticacaoService = new AutenticacaoService(new DataBaseService());
            var usuario = autenticacaoService.Autenticacao(login, senha);
            if (usuario == null)
            {
                MessageBox.Show("Login ou senha inválidos");
                return false;
            }
            return true;
        }

        public bool Cadastrar(string nome, string login, string senha)
        {
            Usuarios usuario = new Usuarios();
            usuario.Nome = nome;
            usuario.login = login;
            string senhaHash = Criptografia.HashSenha(senha);
            UsuariosRepository usuariosRepository = new UsuariosRepository(new DataBaseService());

            return usuariosRepository.RegistrarUsuarios(usuario, senhaHash);
        }
    }
}
