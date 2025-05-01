using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPI.Models.Metas
{
    public class Metas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool status { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }

        // Contrutor para pegar os dados que vieram do banco de dados e transformar em um objeto Metas
        public static Metas UserFromDataReade(MySqlDataReader reader)
        {
            return new Metas
            {
                Id = reader.IsDBNull(reader.GetOrdinal("idMetas")) ? 0 : Convert.ToInt32(reader["idMetas"]),
                Titulo = reader.IsDBNull(reader.GetOrdinal("Titulo")) ? string.Empty : Convert.ToString(reader["Titulo"]),
                Descricao = reader.IsDBNull(reader.GetOrdinal("Descricao")) ? string.Empty : Convert.ToString(reader["Descricao"]),
                status = reader.IsDBNull(reader.GetOrdinal("status")) ? false : Convert.ToBoolean(reader["status"]),
                DataCriacao = reader.IsDBNull(reader.GetOrdinal("DataCriacao")) ? DateTime.MinValue : Convert.ToDateTime(reader["DataCriacao"]),
                DataConclusao = reader.IsDBNull(reader.GetOrdinal("DataConclusao")) ? DateTime.MinValue : Convert.ToDateTime(reader["DataConclusao"])
            };
        }
    }
}
