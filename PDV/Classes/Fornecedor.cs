using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;

namespace PDV.Classes
{
    [Table("FORNECEDOR")]
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }
        public string? NomeFornecedor { get; set; }
    }
}
