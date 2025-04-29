using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Controllers
{
    class ValidarCadastro
    {
        private ControllerTxtBox controllerTxtBox;

        public bool ValidarLogin(string login)
        {
            bool naoVazio = controllerTxtBox.TextoNaoVazio(login);
            bool possuiEspaco = controllerTxtBox.PossuiEspaco(login);
            bool possuiCaracteresEspeciais = controllerTxtBox.PossuiCaracteresEspeciais(login);
            bool possuiNumeros = controllerTxtBox.PossuiNumeros(login);
            bool possuiTamanhoMinimo = login.Length >= 3; // Verifica se o nome tem pelo menos 3 caracteres

            return naoVazio && !possuiEspaco && !possuiCaracteresEspeciais && !possuiNumeros && possuiTamanhoMinimo;
        }
        public bool ValidarNome(string nome)
        {
            // Variáveis intermediárias para cada validação
            nome = controllerTxtBox.RemoverEspacosInicioFim(nome);
            bool naoVazia = controllerTxtBox.TextoNaoVazio(nome);
            bool possuiCaracteresEspeciais = controllerTxtBox.PossuiCaracteresEspeciais(nome);
            bool possuiNumeros = controllerTxtBox.PossuiNumeros(nome);
            bool possuiTamanhoMinimo = nome.Length >= 3; // Verifica se o nome tem pelo menos 3 caracteres
            // Combina todas as validações
            return naoVazia && !possuiCaracteresEspeciais && !possuiNumeros && possuiTamanhoMinimo;
        }
        public bool ValidarSenha(string senha)
        {
            bool naoVazia = controllerTxtBox.TextoNaoVazio(senha);
            bool possuiEspaco = controllerTxtBox.PossuiEspaco(senha);
            bool possuiCaracteresEspeciais = controllerTxtBox.PossuiCaracteresEspeciais(senha);
            bool possuiNumeros = controllerTxtBox.PossuiNumeros(senha);
            bool possuiLetraMaiuscula = controllerTxtBox.PossuiLetraMaiuscula(senha);
            bool possuiLetraMinuscula = controllerTxtBox.PossuiLetraMinuscula(senha);
            bool possuiTamanhoMinimo = senha.Length >= 6; // Verifica se a senha tem pelo menos 6 caracteres
            // Combina todas as validações
            return naoVazia && !possuiEspaco && possuiCaracteresEspeciais && possuiNumeros && possuiLetraMaiuscula && possuiLetraMinuscula && possuiTamanhoMinimo;
        }
    }
}
