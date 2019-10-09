using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using KingPandaMedia.Models.Tables;
using System;

namespace KingPandaMedia.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            KingPandaMediaDbContext context = app.ApplicationServices.GetRequiredService<KingPandaMediaDbContext>();
            context.Database.Migrate();
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                new Employee { FirstName = "Juan", LastName = "Bustos", Email = "juan.c.bustos@outlook.com", Password = "aPassW0rD"},
                new Employee { FirstName = "Jesus", LastName = "McCloud", Email = "jesus.mccloud@gmail.com", Password = "aPassW0rD"},
                new Employee { FirstName = "Danny", LastName = "Auvert", Email = "danny.auvert@hotmail.com", Password = "1234UsMaR1n3C0rPs"});

            }
            context.SaveChanges();

            //context.Database.Migrate();
            //if (!context.Users.Any())
            //{
            //    context.Users.AddRange(
            //    new KPMUser { FirstName = "Donnie", LastName = "Darko", Email = "therabbitman@gmail.com", Password = "iHaveMulT1p3P3rs0na1ities", PhoneNumber = "(395)-789-1458" },
            //    new KPMUser { FirstName = "Lando", LastName = "Carethean", Email = "mr.smooth@skywalker.com", Password = "M1llen1umFa1c0n", PhoneNumber = "(185)-659-8759" },
            //    new KPMUser { FirstName = "Jane", LastName = "Mazkyvall", Email = "janeismyname@yahoo.com", Password = "j@neTh3ma1d3n", PhoneNumber = "(658)-859-7292" });
            //}
            //context.SaveChanges();

            context.Database.Migrate();
            if (!context.Orders.Any())
            {
                context.Orders.AddRange(
                new Order { EmployeeID = 1, UserID = 2, Category = "Platinum", Price = 350M},
                new Order { EmployeeID = 2, UserID = 3, Category = "Basic", Price = 50M },
                new Order { EmployeeID = 3, UserID = 1, Category = "Premium", Price = 250M});
            }
            context.SaveChanges();

            //context.Database.Migrate();
            //if (!context.Portfolios.Any())
            //{
            //    context.Portfolios.AddRange(
            //    new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/4966179.jpg" },
            //    new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/2460352.jpg" },
            //    new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/2720440.jpg" },
            //    new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/2975249.jpg" },
            //    new Portfolio { MediaCategory = "Photo", ImageURL = "~/media/photos/junior-league-of-san-diego-food--wine-festival-2019_33967532848_o.jpg" });

            //}
            //context.SaveChanges();
        }
    }
}
