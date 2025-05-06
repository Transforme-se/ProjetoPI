using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoPI.Models.Metas;
using ProjetoPI.Services;

namespace ProjetoPI.Controllers
{
    public class ControllerMetas
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

        public Metas ObterMetasPorId(int idMeta)
        {
            return _metasRepository.ObterMetasPorId(idMeta);
        }

        public class ResultadoOperacao
        {
            public bool Sucesso { get; set; }
            public string Mensagem { get; set; }
        }


        public ResultadoOperacao ValidarMeta(string titulo, string descricao, string dataTexto)
        {
            // Valida o título
            if (string.IsNullOrWhiteSpace(titulo))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    Mensagem = "Por favor, preencha o título da meta."
                };
            }

            // Valida a data
            if (!string.IsNullOrWhiteSpace(dataTexto) && !DateTime.TryParse(dataTexto, out _))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    Mensagem = "A data de conclusão informada é inválida."
                };
            }

            // Se tudo estiver válido
            return new ResultadoOperacao
            {
                Sucesso = true,
                Mensagem = "Validação bem-sucedida."
            };
        }


        public Metas CadastrarMetas(string titulo, string descricao, DateTime? dataConclusao)
        {
            try
            {
                Metas metas = new Metas();
                metas.Titulo = titulo;
                metas.Descricao = descricao;
                metas.DataConclusao = dataConclusao;

                MetasRepository metasRepository = new MetasRepository(_databaseService);

                bool resultado = metasRepository.AdicionarMetas(metas);

                return resultado ? metas : null;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a meta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void EditarMeta(int idMeta, string titulo, string descricao, string dataTexto)
        {
            // Valida a data
            DateTime? dataConclusao = null;
            if (!string.IsNullOrWhiteSpace(dataTexto) && DateTime.TryParse(dataTexto, out DateTime dataValida))
            {
                dataConclusao = dataValida;
            }

            // Envia os dados validados para o Model ou Repository
            var meta = new Metas
            {
                Id = idMeta,
                Titulo = titulo,
                Descricao = descricao,
                DataConclusao = dataConclusao
            };

            _metasRepository.EditarMetas(meta);
        }

        public void ExcluirMeta(int idMeta)
        {
            // Envia o ID da meta para o Model ou Repository
            _metasRepository.DeletarMetas(idMeta);
        }

        public bool EditarStatus(Metas meta)
        {
            try
            {
                return _metasRepository.EditarStatus(meta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao editar status: {ex.Message}", ex);
            }
        }
    }
}
