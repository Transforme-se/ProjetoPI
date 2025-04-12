using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPI.Models.Usuarios
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string login { get; set; }
        public string SenhaHash { get; set; }
        public DateTime dataCriacao { get; set; }

        // Contrutor para pegar os dados que vieram do banco de dados e transformar em um objeto UsuariosModel
        public static Usuarios UserFromDataReader(MySqlDataReader reader)
        {

            return new Usuarios
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nome =  Convert.ToString(reader["Nome"]),
                login = Convert.ToString(reader["login"]),
                SenhaHash = Convert.ToString(reader["SenhaHash"]),
                dataCriacao = Convert.ToDateTime(reader["dataCriacao"])
            };
        }
    }
}
