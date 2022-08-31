using Data.Model;
using Data.Utils;

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
    }
}
