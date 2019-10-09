using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<KPMUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<KPMUser>>();

            KPMUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new KPMUser();
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
