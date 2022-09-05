using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class CategorieRepository : BaseRepository<Categories>
    {
        public override List<Categories> GetAll()
        {
            List<Categories> list = new List<Categories>();

            using (DealContext dealContext = new DealContext())
            {
                list = dealContext.Categorie.Include("Announces").ToList();
            }

            return list;
        }

        public override Categories GetById(int id)
        {
            Categories entity = null;

            using (DealContext dealContext = new DealContext())
            {
                entity = dealContext.Categorie.Include("Announces").Where(c => c.Id == id).FirstOrDefault();
            }

            return entity;
        }
    }
}
