using ProjetoPI.Models.Usuarios;
using ProjetoPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Controllers
{
    class AlterarNomeController
    {
        private readonly DataBaseService _dataBaseService;
        private readonly UsuariosRepository _usuariosRepository;
        public AlterarNomeController(DataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
            _usuariosRepository = new UsuariosRepository(_dataBaseService);
        }

        public bool AlterarNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
            {
                return false;
            }
            // Atualiza o nome do usuário na sessão
            SessaoUsuario.usuarioLogado.Nome = novoNome;

            return _usuariosRepository.AlterarNome(SessaoUsuario.usuarioLogado.Id, novoNome);
        }
    }
}
