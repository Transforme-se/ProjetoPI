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
                    new MySqlParameter("@login", usuario.login),
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

        public bool AlterarFotoPerfil(int id, int fotoPerfil)
        {
            try
            {
                string query = "UPDATE usuarios SET FotoPerfil = @fotoPerfil WHERE IdUsuarios = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@fotoPerfil", fotoPerfil),
                    new MySqlParameter("@id", id)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar foto de perfil: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }

        public bool AlterarFotoFundo(int id, int fotoFundo)
        {
            try
            {
                string query = "UPDATE usuarios SET FotoFundo = @fotoFundo WHERE IdUsuarios = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@fotoFundo", fotoFundo),
                    new MySqlParameter("@id", id)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar foto de fundo: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }

        public bool AlterarSenha(int id, string senha)
        {
            try
            {
                string query = "UPDATE usuarios SET SenhaHash = @senha WHERE IdUsuarios = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@senha", senha),
                    new MySqlParameter("@id", id)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar senha: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }

        public bool AlterarNome(int id, string nome)
        {
            try
            {
                string query = "UPDATE usuarios SET Nome = @nome WHERE IdUsuarios = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@nome", nome),
                    new MySqlParameter("@id", id)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar nome: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }

        public bool ExcluirUsuario(int id)
        {
            try
            {
                string query = "DELETE FROM usuarios WHERE IdUsuarios = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@id", id)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir usuário: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }
    }
}
