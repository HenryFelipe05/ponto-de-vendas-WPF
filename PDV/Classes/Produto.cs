using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Classes
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        public int CodigoProduto { get; set; }
        public string? NomeProduto { get; set; }
        public double Preco { get; set; }
        public string? Embalagem { get; set; }
        public int Estoque { get; set; }
        public string? Fornecedor { get; set; }
        public DateTime DataAdicionado { get; set; }
    }
}
