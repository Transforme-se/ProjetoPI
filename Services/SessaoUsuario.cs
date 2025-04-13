using ProjetoPI.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Services
{

    // Classe para gerenciar a sessão do usuário logado. É staticamente acessível em toda a aplicação
    public static class SessaoUsuario
    {
        // Variável estática que guarda o usuário que está atualmente logado no sistema.
        // Como é estática, seu valor é compartilhado e único em toda a aplicação (enquanto o app estiver aberto).
        public static Usuarios usuarioLogado;

        // Método para verificar se o usuário está logado
        public static Usuarios Login(Usuarios usuario)
        {
            return usuarioLogado = usuario;
        }

        //Esse método "desloga" o usuário, limpando a variável usuarioLogado.
        public static void Logout()
        {
            usuarioLogado = null;
        }
    }
}
