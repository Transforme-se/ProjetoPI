using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProjetoPI.Services;

namespace ProjetoPI.Models.Metas
{
    class MetasRepository
    {
        DataBaseService _databaseService;

        public MetasRepository(DataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

        // Método para registrar metas
        public List<Metas> ObterTodasMetas()
        {
            // Cria uma lista de metas
            List<Metas> metas = new List<Metas>();

            try
            {
                // Consulta SQL para buscar metas do usuário logado
                string query = "SELECT idMetas, titulo, descricao, status, dataCriacao, dataConclusao FROM metas WHERE idUsuarios = @id";

                // Obtém o ID do usuário logado
                int idUsuario = SessaoUsuario.usuarioLogado.Id;

                // Define os parâmetros da consulta
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                     new MySqlParameter("@id", idUsuario)
                };

                // Executa a consulta e obtém o resultado
                using (MySqlDataReader resultadoBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    // Lê os dados do banco de dados e adiciona à lista de metas
                    while (resultadoBanco.Read())
                    {
                        Metas meta = Metas.UserFromDataReade(resultadoBanco);
                        metas.Add(meta);
                    }
                }

                return metas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar metas: " + ex.Message);
            }
        }

        public Metas ObterMetasPorId(int id)
        {
            string query = "SELECT * FROM metas WHERE idMetas = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };

            using (MySqlDataReader reader = _databaseService.ExecuteQuery(query, parameters))
            {
                if (reader.Read())
                {
                    return Metas.UserFromDataReade(reader);
                }
            }

            return null;
        }

        public bool EditarStatus(Metas metas)
        {
            try
            {
                // Atualiza o status da meta no banco de dados
                string query = "UPDATE metas SET status = @status WHERE idMetas = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@status", metas.status),
                    new MySqlParameter("@id", metas.Id)
                };
                // Executa a consulta de atualização
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar status: " + ex.Message);
            }
        }

        public bool AdicionarMetas(Metas metas)
        {
            try
            {
                // Insere os dados da meta no banco de dados
                string query = "INSERT INTO metas (Titulo, Descricao, status, idUsuarios, DataCriacao, DataConclusao) VALUES(@titulo, @descricao, @status, @id, @dataCriacao, @dataConclusao)";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@titulo", metas.Titulo),
                    new MySqlParameter("@descricao", metas.Descricao),
                    new MySqlParameter("@status", metas.status),
                    new MySqlParameter("@id", SessaoUsuario.usuarioLogado.Id),
                    new MySqlParameter("@dataCriacao", DateTime.Now),
                    new MySqlParameter("@dataConclusao", metas.DataConclusao)
                };
                // Executa a consulta de inserção
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar metas: " + ex.Message);
            }
            // Finaly garante que a conexão com o banco de dados seja fechada.
            finally
            {
                _databaseService.CloseConnection();
            }
        }

        // Método para Editar metas
        public bool EditarMetas(Metas metas)
        {
            try
            {
                // Atualiza os dados da meta no banco de dados
                string query = "UPDATE metas SET Titulo = @titulo, Descricao = @descricao, status = @status, DataConclusao = @dataConclusao WHERE idMetas = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@titulo", metas.Titulo),
                    new MySqlParameter("@descricao", metas.Descricao),
                    new MySqlParameter("@status", metas.status),
                    new MySqlParameter("@dataConclusao", metas.DataConclusao.HasValue ? (object)metas.DataConclusao.Value : DBNull.Value),
                    new MySqlParameter("@Id", metas.Id)
                };

                // Executa a consulta de atualização
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar metas: " + ex.Message);
            }

            // Finaly garante que a conexão com o banco de dados seja fechada.
            finally
            {
                _databaseService.CloseConnection();
            }
        }

        public bool DeletarMetas(int id)
        {
            try
            {
                // Deleta os dados da meta no banco de dados
                string query = "DELETE FROM metas WHERE idMetas = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@id", id)
                };
                // Executa a consulta de deleção
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar metas: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
        }
    }
}
