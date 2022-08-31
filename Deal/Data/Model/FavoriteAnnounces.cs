namespace Data.Model
{
    public class FavoriteAnnounces : BaseModel
    {
        public Users UserId { get; set; }
        public Announces AnunId { get; set; }

    }
}
