using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    public class UserController : GenericController<Users, UsersRepository>
    {
        [HttpGet("email/{email}")]
        public int GetByEmail(string email)
        {
            UsersRepository _repository = new UsersRepository();

            return _repository.GetByEmail(email);
        }
    }
}
