using System;
using System.Collections.Generic;
using System.Linq;
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
            // Valida os dados da meta
            var resultadoValidacao = ValidarMeta(titulo, descricao, dataConclusao?.ToString());
            if (!resultadoValidacao.Sucesso)
            {
                MessageBox.Show(resultadoValidacao.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                Metas metas = new Metas
                {
                    Titulo = titulo,
                    Descricao = descricao,
                    DataConclusao = dataConclusao
                };

                bool resultado = _metasRepository.AdicionarMetas(metas);

                return resultado ? metas : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a meta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void EditarMeta(int idMeta, string titulo, string descricao, string dataTexto)
        {
            // Valida os dados da meta
            var resultadoValidacao = ValidarMeta(titulo, descricao, dataTexto);
            if (!resultadoValidacao.Sucesso)
            {
                MessageBox.Show(resultadoValidacao.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida e converte a data
            DateTime? dataConclusao = ConverterData(dataTexto);

            // Cria o objeto meta com os dados atualizados
            var meta = new Metas
            {
                Id = idMeta,
                Titulo = titulo,
                Descricao = descricao,
                DataConclusao = dataConclusao
            };

            // Atualiza a meta no repositório
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

        // Método para formatar a data no formato desejado
        public string FormatarData(DateTime? data)
        {
            return data?.ToString("dd/MM/yyyy") ?? string.Empty;
        }

        // Método para converter uma string para DateTime?
        public DateTime? ConverterData(string dataTexto)
        {
            if (DateTime.TryParse(dataTexto, out DateTime dataValida))
            {
                return dataValida;
            }
            return null;
        }

        public string FormatarTextoData(string texto)
        {
            // Remove qualquer caractere que não seja número
            string numeros = new string(texto.Where(char.IsDigit).ToArray());

            // Aplica a formatação "dd/MM/yyyy" conforme o comprimento do texto
            if (numeros.Length >= 2)
            {
                numeros = numeros.Insert(2, "/");
            }
            if (numeros.Length >= 5)
            {
                numeros = numeros.Insert(5, "/");
            }

            return numeros;
        }

        public List<Metas> ObterMetasFiltradas(string filtro)
        {
            List<Metas> metas = new List<Metas>();
            
            foreach (var meta in _metasRepository.ObterTodasMetas())
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
            List<Metas> metas = new List<Metas>();
            foreach (var meta in _metasRepository.ObterTodasMetas())
            {
                if (meta.DataConclusao.ToShortDateString().Equals(data.ToShortDateString()))
                {
                    metas.Add(meta);
                }
            }
            return metas;
        }
    }
}
