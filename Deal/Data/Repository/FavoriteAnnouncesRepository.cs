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
                var entity = dealContext.FavoriteAnnounce.Where(favoriteAnnounce => favoriteAnnounce.UserId == userId && favoriteAnnounce.AnunId == announceId).FirstOrDefault();

                if (entity != null)
                {
                    dealContext.Entry(entity).State = EntityState.Deleted;
                    dealContext.SaveChanges();
                }

            }
            return "Objeto deletado";
        }
    }
}
