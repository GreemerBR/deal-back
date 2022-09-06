using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DealContext : DbContext
    {
        #region Props
        public DbSet<Users> User { get; set; }
        public DbSet<Announces> Announce { get; set; }
        public DbSet<Categories> Categorie { get; set; }
        public DbSet<FavoriteAnnounces> FavoriteAnnounce { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=zuplae.vps-kinghost.net; Port=5442; Database=Deal; UserId=postgres; Password=123456");
        }
    }
}
