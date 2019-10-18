using System.Linq;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.Interfaces;


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
