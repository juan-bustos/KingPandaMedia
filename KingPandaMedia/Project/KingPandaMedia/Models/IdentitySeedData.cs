using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using KingPandaMedia.Models.Tables;
using System.Threading.Tasks;

namespace KingPandaMedia.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        public static async Task EnsurePopulated(UserManager<KPMUser> userManager)
        {
            KPMUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new KPMUser();
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
