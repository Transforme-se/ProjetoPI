using ProjetoPI.Models.Usuarios;
using ProjetoPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI.Controllers
{
    public class ExcluirContaController
    {
        private readonly DataBaseService _databaseService;
        private readonly UsuariosRepository _usuariosRepository;

        public ExcluirContaController(DataBaseService databaseService)
        {
            _databaseService = databaseService;
            _usuariosRepository = new UsuariosRepository(_databaseService);
        }

        public bool ExcluirConta(int idUsuario)
        {
            try
            {

                return _usuariosRepository.ExcluirUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir conta: " + ex.Message);
            }
        }

    }
}
