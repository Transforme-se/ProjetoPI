using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPI.Services;

namespace ProjetoPI.Controllers
{
    class ControlerLoginCadastro
    {
        public bool Login (string login, string senha)
        {
            AutenticacaoService autenticacaoService = new AutenticacaoService(new DataBaseService());
            var usuario = autenticacaoService.Autenticacao(login, senha);
            if (usuario == null)
            {
                MessageBox.Show("Login ou senha inválidos");
                return false;
            }
            return true;
        }
    }
}
