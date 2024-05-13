using Dapper.Contrib.Extensions;

namespace PDV.Classes
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}
