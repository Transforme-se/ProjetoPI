using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Controllers
{
    class ControllerSenha
    {
        public bool ValidarSenha(string senha)
        {
            ControllerTxtBox controleTextBox = new ControllerTxtBox();

            // Variáveis intermediárias para cada validação
            bool naoVazia = controleTextBox.TextoNaoVazio(senha);
            bool possuiEspaco = controleTextBox.PossuiEspaco(senha);
            bool possuiCaracteresEspeciais = controleTextBox.PossuiCaracteresEspeciais(senha);
            bool possuiNumeros = controleTextBox.PossuiNumeros(senha);
            bool possuiLetraMaiuscula = controleTextBox.PossuiLetraMaiuscula(senha);
            bool possuiLetraMinuscula = controleTextBox.PossuiLetraMinuscula(senha);
            bool possuiTamanhoMinimo = senha.Length >= 6; // Verifica se a senha tem pelo menos 8 caracteres
            // Combina todas as validações
            return naoVazia && possuiEspaco && possuiCaracteresEspeciais && possuiNumeros && possuiLetraMaiuscula && possuiLetraMinuscula;

        }
    }
}
