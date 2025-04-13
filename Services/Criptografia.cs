using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Services
{
    internal class Criptografia
    {
        public static string HashSenha(string senha)
        {
            // Cria uma instância do algoritmo SHA256 que é um algoritmo de hash seguro.
            using (var sha256 = SHA256.Create())
            {
                // Converte a senha em bytes e calcula o hash.
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                // Converte os bytes do hash em uma string hexadecimal.
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
