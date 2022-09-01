namespace Data.Model
{
    public class Categories : BaseModel
    {
        public string Nome { get; set; } = string.Empty;

        public ICollection<Announces> Announces { get; set; } = new List<Announces>();
    }
}
