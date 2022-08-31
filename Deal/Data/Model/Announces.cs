using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Data.Model
{
    public class Announces : BaseModel
    {
        public string AnunTitulo { get; set; }
        public string AnunDescri { get; set; }
        public string AnunCat { get; set; }
        public string AnunCep { get; set; }
        public string AnunEndereco { get; set; }
        public string AnunData { get; set; }
        public decimal AnunValor { get; set; }

        [Column(TypeName = "BYTEA")]
        public byte[] AnunImage1 { get; set; }
        [Column(TypeName = "BYTEA")]
        public byte[] AnunImage2 { get; set; }
        [Column(TypeName = "BYTEA")]
        public byte[] AnunImage3 { get; set; }

        public Users UserId { get; set; }
    }
}
