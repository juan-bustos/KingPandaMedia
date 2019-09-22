using System.Linq;
using System.Collections.Generic;
using KingPandaMedia.Models.Interfaces;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models.EFRepositoryModels
{
    public class EFUsersRepository : IUserRepository
    {
        private KingPandaMediaDbContext context;

        public EFUsersRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Users> Users => context.Users;
    }
}
