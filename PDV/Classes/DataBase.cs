using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PDV.Classes
{
    public class DataBase
    {
        const string stringConexao = "SuaStringDeConexaoAqui"; // Substitua com sua string de conexão real

        public static SqlConnection OpenConnection()
        {
            var conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
                return null; 
            }
        }
    }
}
