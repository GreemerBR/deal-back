using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
