using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<Users, UsersRepository>
    {
        public UserController() : base(new UsersRepository())
        {
        }
    }
}
