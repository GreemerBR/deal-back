using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class FavoriteAnnouncesRepository : BaseRepository<FavoriteAnnounces>
    {
        public string DeleteByUserAndAnnounceId(int userId, int announceId)
        {           
            using (DealContext dealContext = new DealContext())
            {
                var entity = dealContext.FavoriteAnnounce.Where(favoriteAnnounce => favoriteAnnounce.UserId == userId && favoriteAnnounce.AnnounceId == announceId).FirstOrDefault();

                if (entity != null)
                {
                    dealContext.Entry(entity).State = EntityState.Deleted;
                    dealContext.SaveChanges();
                }

            }
            return "Objeto deletado";
        }

        public List<FavoriteAnnounces> GetByUserId(int userId)
        {
            List<FavoriteAnnounces> entity = null;

            using (DealContext dealContext = new DealContext())
            {
                entity = dealContext.FavoriteAnnounce.Include("Announce").Where(favoriteAnnounces => favoriteAnnounces.UserId == userId).ToList();
            }

            return entity;
        }

        public override List<FavoriteAnnounces> GetAll()
        {
            List<FavoriteAnnounces> list = new List<FavoriteAnnounces>();

            using (DealContext dealContext = new DealContext())
            {
                list = dealContext.FavoriteAnnounce.Include("Announce").ToList();
            }

            return list;
        }
    }
}
