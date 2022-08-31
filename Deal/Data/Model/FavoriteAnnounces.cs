using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Data.Model
{
    public class FavoriteAnnounces : BaseModel
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [JsonIgnore]
        public Users? User { get; set; }

        [ForeignKey("Announce")]
        public int AnunId { get; set; }
        [JsonIgnore]
        public Announces? Anun { get; set; }

    }
}
