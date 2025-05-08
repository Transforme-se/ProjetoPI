using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPI.Models.Mensagens
{
    public class Mensagens
    {
        public int IdMensagens { get; set; }
        public String Mensagem { get; set; }

        public static Mensagens UserFromDataReader(MySqlDataReader reader)
        {
            return new Mensagens
            {
                IdMensagens = Convert.ToInt32(reader["IdMensagens"]),
                Mensagem = Convert.ToString(reader["Mensagem"])
            };
        }
    }
}
