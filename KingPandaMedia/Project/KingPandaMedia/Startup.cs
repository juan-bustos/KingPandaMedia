using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.HttpsPolicy;

using KingPandaMedia.Models;
using KingPandaMedia.Models.Interfaces;
using KingPandaMedia.Models.EFRepository;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages();

            services.AddDbContext<KingPandaMediaDbContext>(options => options.UseSqlServer(Configuration["Data:KingPandaMedia:ConnectionString"]));

            services.AddDbContext<KingPandaMediaIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:KingPandaMediaIdentity:ConnectionString"]));

            services.AddIdentity<KPMUser, IdentityRole>(options => options.User.RequireUniqueEmail = true)
                .AddEntityFrameworkStores<KingPandaMediaIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmployeeRepository, EFEmployeeRepository>();
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddTransient<IPortfolioRepository, EFPortfolioRepository>();            
            services.AddTransient<IUserRepository, EFUserRepository>();


            services.ConfigureApplicationCookie(options => options.LoginPath = "/Users/Login");

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                .AddCookie()
                .AddFacebook(facebookOptions =>
                {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                facebookOptions.Events.OnRemoteFailure = (context) =>
                {
                    context.HandleResponse();
                    return context.Response.WriteAsync("<script>Window.close();</script>");
                };
                });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern:"{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            IdentitySeedData.EnsurePopulated(app);
            //SeedData.EnsurePopulated(app);
            
        }
    }
}
