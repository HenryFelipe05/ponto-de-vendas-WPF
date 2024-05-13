using PDV.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Dao
{
    public class FornecedorDao
    {
        public List<Fornecedor> ConsultarFornecedores(SqlConnection conexao)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            #region [ Comando Select ]
            var sql = @" SELECT *
                            FROM FORNECEDOR";
            #endregion

            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor
                        {
                            IdFornecedor = Convert.ToInt32(reader["IdFornecedor"]),
                            NomeFornecedor = Convert.ToString(reader["NomeFornecedor"])
                        };

                        fornecedores.Add(fornecedor);
                    }
                }
            }

            return fornecedores;
        }

    }
}
