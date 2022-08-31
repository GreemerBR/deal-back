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

        public GenericController(R repository)
        {
            this._repository = repository;
        }

        [HttpGet()]
        public List<T> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost()]
        public string Post(T model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut()]
        public string Update(T model)
        {
            return _repository.Update(model);
        }
    }
}
