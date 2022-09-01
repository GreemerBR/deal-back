using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Announces : BaseModel
    {
        public string AnunTitulo { get; set; } = String.Empty;
        public string AnunDescri { get; set; } = String.Empty;
        public string AnunData { get; set; } = String.Empty;
        public double AnunValor { get; set; } = 0.00;

        [Column(TypeName = "BYTEA")]
        public byte[] AnunImage { get; set; }

        public int CategoriesId { get; set; }
        [JsonIgnore]
        [ForeignKey("CategoriesId")]
        public Categories? Categorie { get; set; }

        public int UserId { get; set; }
        [JsonIgnore]
        [ForeignKey("UserId")]
        public Users? User { get; set; }
    }
}
