using Dapper;
using Dapper.Contrib.Extensions;
using PDV.Classes;
using System.Data.SqlClient;

namespace PDV.Dao
{
    public class UsuarioDao
    {
        public Usuario ConsultarUsuario(SqlConnection conexao, string nomeUsuario, string senha)
        {
            #region [ Comando Select ]
            var sql = @"
                       SELECT *
                         FROM USUARIO
                        WHERE NomeUsuario = @NomeUsuario
                          AND Senha = @Senha";
            #endregion

            return conexao.QueryFirstOrDefault<Usuario>(sql, new { NomeUsuario = nomeUsuario, Senha = senha });
        }

        public void AdicionarNovoUsuario(SqlConnection conexao, Usuario novoUsuario)
        {
            conexao.Insert(novoUsuario);
        }

        public bool VerificarSeNomeDeUsuarioExiste(SqlConnection conexao, string nomeUsuario)
        {
            var sql = @"
                         SELECT 1
                            FROM USUARIO
                          WHERE NomeUsuario = @NomeUsuario";

            return conexao.QueryFirstOrDefault<int>(sql, new { NomeUsuario = nomeUsuario }) != 0;
        }

        public bool VerificarSeEmailExiste(SqlConnection conexao, string email)
        {
            var sql = @"
                         SELECT 1
                            FROM USUARIO
                          WHERE Email = @Email";

            return conexao.QueryFirstOrDefault<int>(sql, new { Email = email }) != 0;
        }
    }
}
