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
        // Injeção de dependência
        private readonly AutenticacaoService _autenticacaoService;
        private readonly UsuariosRepository _usuariosRepository;

        public ControllerLoginCadastro(AutenticacaoService autenticacaoService, UsuariosRepository usuariosRepository)
        {
            _autenticacaoService = autenticacaoService;
            _usuariosRepository = usuariosRepository;
        }

        public Usuarios Login (string login, string senha)
        {
            AutenticacaoService autenticacaoService = new AutenticacaoService(new DataBaseService());
            var usuario = autenticacaoService.Autenticacao(login, senha);
            if (usuario == null)
            {
                MessageBox.Show("Login ou senha inválidos");
            }
            return autenticacaoService.Autenticacao(login, senha);
        }

        public bool Cadastrar(string nome, string login, string senha, string senhaConf)
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
