using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteAnnounceController : GenericController<FavoriteAnnounces, FavoriteAnnouncesRepository>
    {
        public FavoriteAnnounceController() : base(new FavoriteAnnouncesRepository())
        {
        }
    }
}
