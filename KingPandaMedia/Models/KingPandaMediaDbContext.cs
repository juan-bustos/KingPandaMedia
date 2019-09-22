using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models
{
    public class KingPandaMediaDbContext : DbContext
    {
        public KingPandaMediaDbContext(DbContextOptions<KingPandaMediaDbContext> options) : base(options)
        {

        }
        public DbSet<Portfolio> Media { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
