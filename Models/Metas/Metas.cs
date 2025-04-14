using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPI.Models.Metas
{
    class Metas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConclusao { get; set; }

        // Contrutor para pegar os dados que vieram do banco de dados e transformar em um objeto Metas
        public static Metas UserFromDataReade(MySqlDataReader reader)
        {
            return new Metas
            {
                Id = Convert.ToInt32(reader["Id"]),
                Titulo = Convert.ToString(reader["Titulo"]),
                Descricao = Convert.ToString(reader["Descricao"]),
                status = Convert.ToBoolean(reader["status"]),
                DataCriacao = Convert.ToDateTime(reader["DataCriacao"]),
                DataConclusao = Convert.ToDateTime(reader["DataConclusao"])
            };
        }
    }
}
