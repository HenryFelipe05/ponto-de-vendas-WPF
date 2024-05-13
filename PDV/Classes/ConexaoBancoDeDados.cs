using System.Data.SqlClient;
using System.Windows;

namespace PDV.Classes
{
    class ConexaoBancoDeDados
    {
        private static string stringConexao = "Data Source=192.168.1.10;Initial Catalog=Teste;Persist Security Info=True;User ID=sa;Password=projet@ftech;MultipleActiveResultSets=True;Max Pool Size=400;";

        public static SqlConnection AbrirConexao()
        {
            try
            {
                var conexao = new SqlConnection(stringConexao);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao conectar ao banco de dados \nErro: {ex}", "Falha no banco de dados", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
    }
}
