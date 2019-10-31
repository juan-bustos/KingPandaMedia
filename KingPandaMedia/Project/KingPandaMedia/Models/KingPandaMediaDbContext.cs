using Microsoft.EntityFrameworkCore;
using KingPandaMedia.Models.Tables;


namespace KingPandaMedia.Models
{
    public class KingPandaMediaDbContext : DbContext
    {
        public KingPandaMediaDbContext(DbContextOptions<KingPandaMediaDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<KPMUser> KPMUsers { get; set; }
    }
}
