using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPI.Models.Metas;
using ProjetoPI.Services;
using Syncfusion.OfficeChart;

namespace ProjetoPI.Controllers
{
    class ControllerMetas
    {
        private readonly DataBaseService _databaseService;
        private readonly MetasRepository _metasRepository;

        public ControllerMetas(DataBaseService databaseService)
        {
            _databaseService = databaseService;
            _metasRepository = new MetasRepository(_databaseService);
        }

        public List<Metas> ObterTodasMetas()
        {
            List<Metas> metas = new List<Metas>();

            metas = _metasRepository.ObterTodasMetas();
            
            if (metas == null)
            {
                MessageBox.Show("AAAAAAAA 2");
                return null;
            }
            return metas;
        }

        public Metas CadastrarMetas(string titulo, string descricao, DateTime dataConclusao)
        {
            Metas metas = new Metas();
            metas.Titulo = titulo;
            metas.Descricao = descricao;
            metas.DataConclusao = dataConclusao;

            MetasRepository metasRepository = new MetasRepository(_databaseService);
            
            bool resultado = metasRepository.AdicionarMetas(metas);

            return resultado ? metas : null;
        }

        public List<Metas> ObterMetasFiltradas(string filtro)
        {
            List<Metas> metas = new List<Metas>();
            
            foreach (var meta in _metasRepository.ObterTodasMetas())
            {
                if (meta.Titulo.Contains(filtro) || meta.Descricao.Contains(filtro))
                {
                    metas.Add(meta);
                }
            }

            return metas;
        }
    }
}
