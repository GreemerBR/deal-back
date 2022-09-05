using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R _repository;

        public GenericController()
        {
            this._repository = Activator.CreateInstance<R>();
        }

        [HttpGet()]
        public virtual List<T> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost()]
        public virtual string Post(T model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public virtual string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut()]
        public virtual string Update(T model)
        {
            return _repository.Update(model);
        }
    }
}
