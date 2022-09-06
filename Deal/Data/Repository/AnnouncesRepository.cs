using Data.Model;

namespace Data.Repository
{
    public class AnnouncesRepository : BaseRepository<Announces>
    {
        public List<Announces> GetByName(string nome)
        {
            List<Announces> list = new List<Announces>();

            using (DealContext dealContext = new DealContext())
            {
                list = dealContext.Announce.Where(announce => announce.AnunTitulo.ToLower().Contains(nome.ToLower())).ToList();
            }

            return list;
        }        
    }
}
