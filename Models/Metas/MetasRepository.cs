using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string query = "SELECT * FROM metas";
                MySqlDataReader resultadoBanco = _databaseService.ExecuteQuery(query);

                // Lê os dados do banco de dados e adiciona à lista de metas
                while (resultadoBanco.Read())
                {
                    Metas meta = new Metas();
                    meta = Metas.UserFromDataReade(resultadoBanco);

                    metas.Add(meta);
                }
                _databaseService.CloseConnection();

                return metas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar metas: " + ex.Message);
            }
        }

        public bool AdicionarMetas(Metas metas)
        {
            try
            {
                // Insere os dados da meta no banco de dados
                string query = "INSERT INTO metas (Titulo, Descricao, status, DataCriacao, DataConclusao) VALUES(@titulo, @descricao, @status, @dataCriacao, @dataConclusao)";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@titulo", metas.Titulo),
                    new MySqlParameter("@descricao", metas.Descricao),
                    new MySqlParameter("@status", metas.status),
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
                string query = "@UPDATE metas SET Titulo = @titulo, Descricao = @descricao, status = @status, DataCriacao = @dataCriacao, DataConclusao = @dataConclusao WHERE Id = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@titulo", metas.Titulo),
                    new MySqlParameter("@descricao", metas.Descricao),
                    new MySqlParameter("@status", metas.status),
                    new MySqlParameter("@dataCriacao", DateTime.Now),
                    new MySqlParameter("@dataConclusao", metas.DataConclusao),
                    new MySqlParameter("@id", metas.Id)
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
    }
}
