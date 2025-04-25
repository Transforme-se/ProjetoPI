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
    }
}
