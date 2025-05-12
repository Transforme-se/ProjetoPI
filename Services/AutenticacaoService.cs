using MySql.Data.MySqlClient;
using ProjetoPI.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI.Services
{
    class AutenticacaoService
    {
        //Realiza a conexão com o banco de dados. readonly é um modificador que indica que o campo só pode ser atribuído no construtor ou na declaração
        private readonly DataBaseService _dataBaseService;

        //Construtor da classe AutenticacaoService que recebe um objeto DataBaseService como parâmetro
        public AutenticacaoService(DataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        //Método para autenticar o usuário. Recebe o login e a senha como parâmetros
        public Usuarios Autenticacao(string login, string senha)
        {
            try
            {
                //Consulta SQL para verificar se o usuário existe no banco de dados
                string query = "SELECT * FROM usuarios WHERE login = @loginDigitado";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@loginDigitado", login),
                };

                //Executa a consulta e armazena o resultado em respostaBanco
                using (var respostaBanco = _dataBaseService.ExecuteQuery(query, parameters))
                {
                    //Verifica se o usuário foi encontrado
                    if (respostaBanco.Read())
                    {
                        //Verifica se a senha informada corresponde à senha armazenada no banco de dados
                        string hashArmazenado = respostaBanco["senhaHash"].ToString();
                        string hashEntrada = Criptografia.HashSenha(senha);

                        //Se a senha informada corresponder à senha armazenada, cria um objeto Usuarios e retorna
                        if (hashArmazenado == hashEntrada)
                        {
                            Usuarios usuario = new Usuarios();
                            usuario = Usuarios.UserFromDataReader(respostaBanco);

                            return usuario;
                        }
                    }
                }

                //Se o usuário não for encontrado ou a senha não corresponder, retorna null
                return null;
            }

            //Captura qualquer exceção que ocorra durante o processo de autenticação
            catch (Exception ex)
            {
                throw new Exception("Erro ao autenticar usuário: " + ex.Message);
            }
        }
    }
}
