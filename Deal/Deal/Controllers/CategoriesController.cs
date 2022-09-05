using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DealWebApi.Controllers
{
    public class CategoriesController : GenericController<Categories, CategorieRepository>
    {
        [HttpGet("getbyid/{id}")]
        public Categories GetById([FromQuery] int id)
        {
            CategorieRepository _repository = new CategorieRepository();
            return _repository.GetById(id);
        }
    }
}
