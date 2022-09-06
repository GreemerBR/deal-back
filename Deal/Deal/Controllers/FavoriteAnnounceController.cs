using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    public class FavoriteAnnounceController : GenericController<FavoriteAnnounces, FavoriteAnnouncesRepository>
    {
        [HttpDelete("delete")]
        public string DeleteByUserAndAnnounceId([FromQuery] int userId, [FromQuery] int announceId)
        {
            FavoriteAnnouncesRepository _repository = new FavoriteAnnouncesRepository();

            return _repository.DeleteByUserAndAnnounceId(userId, announceId);
        }

        [HttpGet("GetbyUserId")]
        public List<FavoriteAnnounces> GetByUserId(int userId)
        {
            FavoriteAnnouncesRepository _repository = new FavoriteAnnouncesRepository();

            return _repository.GetByUserId(userId);
        }
    }
}
