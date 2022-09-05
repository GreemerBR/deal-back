using Data.Model;
using Data.Utils;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class UsersRepository : BaseRepository<Users>
    {
        public override string Create(Users entity)
        {
            entity.UserSenha = Criptografia.Criptografar(entity.UserSenha);
            return base.Create(entity);
        }

        public override string Update(Users entity)
        {
            entity.UserSenha = Criptografia.Criptografar(entity.UserSenha);
            return base.Update(entity);
        }

        public Users Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);
            Users user = new Users();

            using (DealContext dealContexto = new DealContext())
            {
                user = dealContexto.User.Where(u => u.UserEmail == email && u.UserSenha == senha).FirstOrDefault();
            }

            return user;
        }

        public int GetByEmail(string email)
        {
            Users user = new Users();

            using (DealContext dealContexto = new DealContext())
            {
                user = dealContexto.User.Where(u => u.UserEmail == email).FirstOrDefault();
            }

            return user.Id;
        }

        public override Users GetById(int id)
        {
            Users entity = null;

            using (DealContext dealContext = new DealContext())
            {
                entity = dealContext.User.Include("Announces").Include("FavoriteAnnounces").Where(c => c.Id == id).FirstOrDefault();
            }

            return entity;
        }
    }
}
