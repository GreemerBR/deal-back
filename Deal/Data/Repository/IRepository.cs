using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        string Create(T entity);
        string Update(T entity);
        string Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}