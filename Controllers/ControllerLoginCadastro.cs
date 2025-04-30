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
            MessageBox.Show("Inicio de Controller Cadastro");
            ValidarCadastro valida = new ValidarCadastro();
            nome = nome.Trim();
            if (!valida.ValidarNome(nome))
            {
                MessageBox.Show("O nome deve conter pelo menos 3 caracteres e não pode conter números ou caracteres especiais.");
                return false;
            }
            if (!valida.ValidarLogin(login))
            {
                MessageBox.Show("O login deve conter pelo menos 3 caracteres e não pode conter espaços, números ou caracteres especiais.");
                return false;
            }
            if (senha != senhaConf)
            {
                MessageBox.Show("As senhas não conferem");
                return false;
            }
            if (!valida.ValidarSenha(senha))
            {
                MessageBox.Show("A senha deve conter pelo menos 6 caracteres, incluindo letras maiúsculas, minúsculas, números e caracteres especiais.");
                return false;
            }
            Usuarios usuario = new Usuarios
            {
                Nome = nome,
                Login = login
            };
            string senhaHash = Criptografia.HashSenha(senha);
            UsuariosRepository usuariosRepository = new UsuariosRepository(new DataBaseService());

            return usuariosRepository.RegistrarUsuarios(usuario, senhaHash);
        }
    }
}
