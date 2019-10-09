using System.Linq;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.Interfaces;
using System;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Identity;

namespace KingPandaMedia.Models.EFRepository
{
    public class EFUserRepository : IUserRepository
    {
        private KingPandaMediaDbContext context;
        public EFUserRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<KPMUser> KPMUsers => context.KPMUsers;
    }
}
