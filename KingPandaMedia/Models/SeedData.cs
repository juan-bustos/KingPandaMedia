using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            KingPandaMediaDbContext context = app.ApplicationServices.GetRequiredService<KingPandaMediaDbContext>();
            context.Database.Migrate();
            context.Users.AddRange(
            new Users { FirstName = "Donnie", LastName = "Darko", Email = "therabbitman@gmail.com", Password = "iHaveMulT1p3P3rs0na1ities", Category = "Customer", PhoneNumber = "(395)-789-1458" },
            new Users { FirstName = "Lando", LastName = "Carethean", Email = "mr.smooth@skywalker.com", Password = "M1llen1umFa1c0n", Category = "Customer", PhoneNumber = "(185)-659-8759" },
            new Users { FirstName = "Jane", LastName = "Mazkyvall", Email = "janeismyname@yahoo.com", Password = "j@neTh3ma1d3n", Category = "Customer", PhoneNumber = "(658)-859-7292" });

            context.Database.Migrate();
            context.Employees.AddRange(
            new Employees { FirstName = "Juan", LastName = "Bustos", Email = "juan.c.bustos@outlook.com", Password = "aPassW0rD" },
            new Employees { FirstName = "Jesus", LastName = "McCloud", Email = "jesus.mccloud@gmail.com", Password = "aPassW0rD" },
            new Employees { FirstName = "Danny", LastName = "Auvert", Email = "danny.auvert@hotmail.com", Password = "1234UsMaR1n3C0rPs" });

            context.Database.Migrate();
            context.Orders.AddRange(
            new Orders { Employee = null, Users = null, Category = "Platinum", Price = 350M },
            new Orders { Employee = null, Users = null, Category = "Basic", Price = 50M },
            new Orders { Employee = null, Users = null, Category = "Premium", Price = 250M });

            context.Database.Migrate();
            context.Media.AddRange(
            new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/4966179.jpg" },
            new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/2460352.jpg" },
            new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/2720440.jpg" },
            new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/2975249.jpg" },
            new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/junior-league-of-san-diego-food--wine-festival-2019_33967532848_o.jpg" }
            ); context.SaveChanges();
        }
    }
}
