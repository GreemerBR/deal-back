using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Data.Model
{
    public class Users : BaseModel
    {
        public string UserNomeCompleto { get; set; } = String.Empty;
        public string UserEmail { get; set; } = String.Empty;
        public string UserSenha { get; set; } = String.Empty;
        public string? UserApelido { get; set; } 
        public string? UserCpf { get; set; } 
        public string? UserTelefone { get; set; } 
        public string? UserCep { get; set; } 
        public string? UserEstado { get; set; } 
        public string? UserCidade { get; set; } 
        public string? UserBairro { get; set; } 
        public string? UserRua { get; set; } 
        public string? UserComplemento { get; set; } 
        public int? UserNumero { get; set; }

        [Column(TypeName = "BYTEA")]
        public byte[]? UserImage { get; set; }
    }
}
