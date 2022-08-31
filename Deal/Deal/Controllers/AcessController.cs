using Data.Model;
using Data.Repository;
using DealWebApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessController : ControllerBase
    {
        [HttpPost("Logon")]
        public Users Logon(UsersDto usuarioDto)
        {
            UsersRepository repository = new UsersRepository();
            Users entity = repository.Logon(usuarioDto.UserEmail, usuarioDto.UserSenha);
            return entity;
        }

        [HttpGet("GetByName")]
        public Users Filtro([FromQuery]string name)
        {
            return new Users();
        }
    }
}
