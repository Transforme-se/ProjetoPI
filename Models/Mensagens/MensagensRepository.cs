using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoPI.Services;

namespace ProjetoPI.Models.Mensagens
{
    class MensagensRepository
    {
        DataBaseService _dataBaseService;

        public MensagensRepository(DataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public Mensagens ObterMensagem(int id ) 
        {
            string query = "SELECT * FROM mensagens WHERE idMensagens = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };

            using (MySqlDataReader resultadoBanco = _dataBaseService.ExecuteQuery(query, parameters))
            {
                if (resultadoBanco.Read())
                {
                    Mensagens mensagem = Mensagens.UserFromDataReader(resultadoBanco);
                    return mensagem;
                }
            }

            return null;
        }
    }
}
