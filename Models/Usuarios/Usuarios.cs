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
        public string Login { get; set; }
        public string SenhaHash { get; set; }

        // Contrutor para pegar os dados que vieram do banco de dados e transformar em um objeto Usuarios
        public static Usuarios UserFromDataReader(MySqlDataReader reader)
        {

            return new Usuarios
            {
                Id = Convert.ToInt32(reader["IdUsuarios"]),
                Nome =  Convert.ToString(reader["Nome"]),
                Login = Convert.ToString(reader["Login"]),
                SenhaHash = Convert.ToString(reader["SenhaHash"])
            };
        }
    }
}
