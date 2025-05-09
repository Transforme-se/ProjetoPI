using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPI.Models.Mensagens;
using ProjetoPI.Services;

namespace ProjetoPI.Controllers
{
    class MensagemController
    {
        private readonly DataBaseService _databaseService;
        private readonly MensagensRepository _mensagensRepository;

        public MensagemController(DataBaseService databaseService)
        {
            _databaseService = databaseService;
            _mensagensRepository = new MensagensRepository(_databaseService);
        }

        public async Task MostrarMensagem(int idMensagens)
        {
            try
            {
                Random numeroAleatorio = new Random(DateTime.Now.Millisecond);
                idMensagens = numeroAleatorio.Next(1, 31);

                var mensagemAleatoria = _mensagensRepository.ObterMensagem(idMensagens);

                string mensagem = mensagemAleatoria.Mensagem;
                var mostrarMensagem = new ProjetoPI.Views.MostrarMensagem(mensagem);
                TimerMensagem(mostrarMensagem, 2500);
                mostrarMensagem.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exibir mensagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TimerMensagem(Form formulario, int intervaloEmMilissegundos)
        {
            Timer timer = new Timer();
            timer.Interval = intervaloEmMilissegundos;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                formulario.Close();
            };
            timer.Start();
        }
    }
}
