using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            _allMetas = _controllerMetas.ObterTodasMetas();
            List<Metas> metas = new List<Metas>();
            // Verifica se o txt está vazio
            if (string.IsNullOrEmpty(filtro))
            {
                // Se estiver com algum dia selecionado, retorna as metas do dia, caso contrário, retorna todas as metas
                return _metasDia == null ? _allMetas : _metasDia;
            }

            // faz o forecach nas metas do dia ou todas as metas, dependendo do filtro
            foreach (var meta in _dataSelecionada ? _metasDia : _allMetas)
            {
                // Verifica se o título ou a descrição da meta contém o filtro
                if (meta.Titulo.ToLower().Contains(filtro.ToLower()) || meta.Descricao.ToLower().Contains(filtro.ToLower()))
                {
                    metas.Add(meta);
                }
            }
            // Retorna a lista de metas filtradas
            return metas;
        }
        public List<Metas> ObterMetasFiltradasData(DateTime data)
        {
            _allMetas = _controllerMetas.ObterTodasMetas();
            // Altera o valor da variável _dataSelecionada para true, indicando que uma data foi selecionada
            _dataSelecionada = true;
            List<Metas> metas = new List<Metas>();

            // faz um forecach em todas as metas
            foreach (var meta in _allMetas)
            {
                // Verifica se a data de conclusão da meta é igual à data selecionada
                DateTime date = meta.DataConclusao ?? DateTime.MinValue;
                if (date.ToShortDateString().Equals(data.ToShortDateString()))
                {
                    metas.Add(meta);
                }
            }
            // Altera o valor da variável _metasDia para a lista de metas filtradas
            _metasDia = metas;
            return _metasDia;
        }
        public bool VerificarMetasVazias(List<Metas> metas)
        {
            // Verifica se a lista de metas está vazia ou nula
            if (metas == null || metas.Count == 0)
                return true;
            return false;
        }
        public void LimparFiltro()
        {
            // Altera o valor da variável _dataSelecionada para false, indicando que nenhuma data foi selecionada
            _dataSelecionada = false;
            // Limpa a lista de metas do dia
            _metasDia = null;
            return;
        }
    }
}
