using Dapper.Contrib.Extensions;
using PDV.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Dao
{
    public class ProdutoDao
    {
        public List<Produto> ConsultarProdutos(SqlConnection conexao)
        {
            List<Produto> produtos = new List<Produto>();

            #region [ Comando Select ]
            var sql = @" SELECT *
                            FROM PRODUTO";
            #endregion

            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto
                        {
                            CodigoProduto = Convert.ToInt32(reader["CodigoProduto"]),
                            NomeProduto = Convert.ToString(reader["NomeProduto"]),
                            Preco = Convert.ToDouble(reader["Preco"]),
                            Embalagem = Convert.ToString(reader["Embalagem"]),
                            Estoque = Convert.ToInt32(reader["Estoque"]),
                            Fornecedor = Convert.ToString(reader["Fornecedor"]),
                            DataAdicionado = Convert.ToDateTime(reader["DataAdicionado"])
                        };

                        produtos.Add(produto);
                    }
                }
            }

            return produtos;
        }

        public void AdicionarNovoProduto(SqlConnection conexao, Produto novoProduto)
        {
            conexao.Insert(novoProduto);
        }
    }
}
