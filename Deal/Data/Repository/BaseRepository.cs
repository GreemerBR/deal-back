using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T entity)
        {
            using (DealContext dealContext = new DealContext())
            {
                dealContext.Set<T>().Add(entity);
                dealContext.SaveChanges();
            }
            return "Objeto criado";
        }

        public virtual string Delete(int id)
        {
            T entity = GetById(id);

            using (DealContext dealContext = new DealContext())
            {
                if (entity != null)
                {
                    dealContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    dealContext.SaveChanges();
                }

            }
            return "Objeto deletado";
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();

            using (DealContext dealContext = new DealContext())
            {
                list = dealContext.Set<T>().ToList();
            }

            return list;
        }

        public virtual T GetById(int id)
        {
            T entity = null;

            using (DealContext dealContext = new DealContext())
            {
                entity = dealContext.Set<T>().Find(id);
            }

            return entity;
        }

        public virtual string Update(T entity)
        {
            using (DealContext dealContext = new DealContext())
            {
                dealContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dealContext.SaveChanges();
            }
            return "Objeto alterado";
        }
    }
}
