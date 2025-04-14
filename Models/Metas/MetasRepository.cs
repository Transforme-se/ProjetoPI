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

        public List<Metas> ObterTodasMetas()
        {
            List<Metas> metas = new List<Metas>();

            try
            {
                string query = "SELECT * FROM metas";
                MySqlDataReader resultadoBanco = _databaseService.ExecuteQuery(query);

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
        

    }
}
