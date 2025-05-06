using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Resultset;
using ProjetoPI.Models.Metas;
using Syncfusion.Windows.Shared;

namespace ProjetoPI.Controllers
{
    class ControllerFiltro
    {
        private ControllerMetas _controllerMetas;
        private List<Metas> _allMetas;
        private List<Metas> _metasDia = null;
        private bool _dataSelecionada = false;

        public ControllerFiltro(ControllerMetas controllerMetas)
        {
            _controllerMetas = controllerMetas;
            _allMetas = _controllerMetas.ObterTodasMetas();
        }

        public List<Metas> ObterMetasFiltradasTexto(string filtro)
        {
            List<Metas> metas = new List<Metas>();

            if (string.IsNullOrEmpty(filtro))
            {
                return _metasDia == null ? _allMetas : _metasDia;
            }

            foreach (var meta in _dataSelecionada ? _metasDia : _allMetas)
            {
                if (meta.Titulo.ToLower().Contains(filtro.ToLower()) || meta.Descricao.ToLower().Contains(filtro.ToLower()))
                {
                    metas.Add(meta);
                }
            }
            return metas; 
        }
        public List<Metas> ObterMetasFiltradasData(DateTime data)
        {
            _dataSelecionada = true;
            List<Metas> metas = new List<Metas>();
            foreach (var meta in _allMetas)
            {
                DateTime date = meta.DataConclusao ?? DateTime.MinValue;
                if (date.ToShortDateString().Equals(data.ToShortDateString()))
                {
                    metas.Add(meta);
                }
            }
            _metasDia = metas;
            return _metasDia;
        }
        public bool VerificarMetasVazias(List<Metas> metas)
        {
            if (metas == null || metas.Count == 0)
                return true;
            return false;
        }
        public void LimparFiltro()
        {
            _dataSelecionada = false;
            _metasDia = null;
            return;
        }
    }
}
