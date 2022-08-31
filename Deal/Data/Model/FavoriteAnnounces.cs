namespace Data.Model
{
    public class FavoriteAnnounces : BaseModel
    {
        public Users User { get; set; }
        public Announces Anun { get; set; }

    }
}
