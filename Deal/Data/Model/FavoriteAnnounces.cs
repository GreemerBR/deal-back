using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Data.Model
{
    public class FavoriteAnnounces : BaseModel
    {
        public int UserId { get; set; }
        [JsonIgnore]
        [ForeignKey("UserId")]
        public Users? User { get; set; }

        public int AnnounceId { get; set; }
        //[JsonIgnore]
        [ForeignKey("AnnounceId")]
        public Announces? Announce { get; set; }

    }
}
