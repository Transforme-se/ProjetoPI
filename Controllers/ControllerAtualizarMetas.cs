using Krypton.Toolkit;
using ProjetoPI.Models.Metas;
using ProjetoPI.Services;
using System;
using System.Windows.Forms;

namespace ProjetoPI.Controllers
{
    class ControllerAtualizarMetas
    {
        private readonly DataBaseService _databaseService;
        private readonly KryptonDataGridView _tabela;
        private readonly MetasRepository _metasRepository;

        public ControllerAtualizarMetas(DataBaseService dataBaseService, KryptonDataGridView tabela, MetasRepository metasRepository)
        {
            _databaseService = dataBaseService;
            _tabela = tabela;
            _metasRepository =  metasRepository;
        }

        public void AtualizarMetas()
        {
            try
            {
                _tabela.DataSource = _metasRepository.ObterTodasMetas();
                _tabela.Columns["idMetas"].FillWeight = 15;
                _tabela.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar as metas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
