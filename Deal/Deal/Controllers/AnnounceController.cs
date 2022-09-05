using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    public class AnnounceController : GenericController<Announces, AnnouncesRepository>
    {
        [HttpGet("GetByName")]
        public List<Announces> GetByName([FromQuery] string name)
        {
            AnnouncesRepository _repository = new AnnouncesRepository();
            return _repository.GetByName(name);
        }

    }
}
