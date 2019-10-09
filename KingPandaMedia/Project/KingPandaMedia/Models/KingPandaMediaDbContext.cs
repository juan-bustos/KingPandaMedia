using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using KingPandaMedia.Models.Tables;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
//using System.Data.Entity;

namespace KingPandaMedia.Models
{
    public class KingPandaMediaDbContext : IdentityDbContext<KPMUser>
    {
        public KingPandaMediaDbContext(DbContextOptions<KingPandaMediaDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<KPMUser> KPMUsers { get; set; }
    }
}
