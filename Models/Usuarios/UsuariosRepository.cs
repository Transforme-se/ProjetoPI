using ProjetoPI.Services;
using ProjetoPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Models.Usuarios
{
    public class UsuariosRepository
    {
        DataBaseService _databaseService;

        public UsuariosRepository(DataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool RegistrarUsuarios(Usuarios usuario, string senha)
        {
            try
            {
                string query = @"INSERT INTO usuarios (nome, login, senhaHash, createdAt) VALUES(@nome, @login, @senhaHash, @createdAt)";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@nome", usuario.Nome),
                    new MySqlParameter("@login", usuario.Login),
                    new MySqlParameter("@senhaHash", senha),
                    new MySqlParameter("@createdAt", DateTime.Now)
                };

                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar usuário: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }

    }
}
