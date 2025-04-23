using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI.Controllers
{
    class ControllerTxtBox
    {
        public string RemoverEspacosInicioFim(string texto)
        {
            // Remove os espaços em branco do início e do fim do texto
            return texto.Trim();
        }
        public bool TextoNaoVazio(string texto)
        {
            // Verifica se o texto não é nulo, vazio ou composto apenas por espaços
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }
            return true;
        }
        public bool PossuiEspaco(string texto)
        {
            // Verifica se o texto contém espaços
            if (texto.Contains(" "))
            {
                return true;
            }
            return false;
        }
        public bool PossuiCaracteresEspeciais(string texto)
        {
            // Define os caracteres especiais que não são permitidos
            HashSet<char> caracteresEspeciais = new HashSet<char>("'@!@#$%^&*()_+-=[]{}|;:,<>.\\/?\"");

            // Verifica se algum caractere do texto está no conjunto de caracteres especiais
            foreach (char c in texto)
            {
                if (caracteresEspeciais.Contains(c))
                {
                    return true; // Retorna verdadeiro se nenhum caractere especial for encontrado
                }
            }
            return false; // Retorna falso se encontrar um caractere especial
        }
        public bool PossuiNumeros(string texto)
        {
            // Verifica se o texto contém números
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    return true; // Retorna verdadeiro se nenhum número for encontrado
                }
            }
            return false; // Retorna falso se encontrar um número
        }

        public bool PossuiLetraMaiuscula(string texto)
        {
            // Verifica se o texto contém letras maiúsculas
            foreach (char c in texto)
            {
                if (char.IsUpper(c))
                {
                    return true; // Retorna verdadeiro se encontrar uma letra maiúscula
                }
            }
            return false; // Retorna falso se nenhuma letra maiúscula for encontrada
        }

        public bool PossuiLetraMinuscula(string texto)
        {
            // Verifica se o texto contém letras minúsculas
            foreach (char c in texto)
            {
                if (char.IsLower(c))
                {
                    return true; // Retorna verdadeiro se encontrar uma letra minúscula
                }
            }
            return false; // Retorna falso se nenhuma letra minúscula for encontrada
        }

        public bool TextosIguais(string texto1, string texto2)
        {
            // Compara se os dois textos são iguais
            if (texto1.Equals(texto2))
            {
                return true;
            }
            return false;
        }
    }
}
