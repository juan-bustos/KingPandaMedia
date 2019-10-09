using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models
{
    public class KingPandaMediaIdentityDbContext : IdentityDbContext<KPMUser>
    {
        public KingPandaMediaIdentityDbContext(DbContextOptions<KingPandaMediaIdentityDbContext> options) : base (options)
        {

        }
        public DbSet<KPMUser> KPMUsers { get; set; }
    }
}

