using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Services
{

    //IDisposable é uma interface que permite liberar recursos não gerenciados (como conexões de banco de dados)
    public class DataBaseService : IDisposable
    {

        //MySqlConnection é uma classe que representa uma conexão com um banco de dados MySQL
        //readonly é um modificador que indica que o campo só pode ser atribuído no construtor ou na declaração
        private readonly MySqlConnection _connection;
        private bool _disposed = false;

        //O construtor da classe DataBaseService inicializa a conexão com o banco de dados usando a string de conexão definida no arquivo de configuração
        public DataBaseService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            _connection = new MySqlConnection(connectionString);
        }

        //Método para abrir a conexão com o banco de dados
        public void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        //Método para fechar a conexão com o banco de dados
        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }


        //Método para executar uma consulta SQL e retornar um MySqlDataReader. Para SELECT
        public MySqlDataReader ExecuteQuery(string query, MySqlParameter[] parameters = null)


        {
            try
            {
                OpenConnection();
                var command = new MySqlCommand(query, _connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Erro ao executar consulta: " + ex.Message);
            }
        }


        //Método para executar um comando SQL que não retorna dados (INSERT, UPDATE, DELETE) mas afetam registros
        public int ExecuteNonQuery(string commandText, MySqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                var command = new MySqlCommand(commandText, _connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                //ExecuteNonQuery retorna o número de linhas afetadas
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando: " + ex.Message);
            }

            // O bloco finally garante que a conexão seja fechada, independentemente de ocorrer uma exceção ou não
            finally
            {
                CloseConnection();
            }
        }

        //Método para executar um comando SQL e retornar um único valor (como o resultado de uma função de agregação. Como COUNT(*))
        public object ExecuteScalar(string commandText, MySqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                var command = new MySqlCommand(commandText, _connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar scalar: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //Padrão para liberar recursos não gerenciados. Libera a conexão e marca como liberada.
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _connection.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);

            //Informa ao coletor de lixo que não precisa chamar o finalizador.
            GC.SuppressFinalize(this);
        }
    }
}