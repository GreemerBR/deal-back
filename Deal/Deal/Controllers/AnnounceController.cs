using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnounceController : GenericController<Announces, AnnouncesRepository>
    {
        public AnnounceController() : base(new AnnouncesRepository())
        {
        }
    }
}
