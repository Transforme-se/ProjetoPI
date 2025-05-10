using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPI.Services;
using ProjetoPI.Views;

namespace ProjetoPI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Exibe a tela de login
            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Se o login for bem-sucedido, abre a tela principal
                    Application.Run(new TelaPrincipal(SessaoUsuario.usuarioLogado));
                }
            }
        }
    }
}