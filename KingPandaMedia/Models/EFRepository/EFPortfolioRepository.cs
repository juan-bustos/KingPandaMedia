using System.Linq;
using System.Collections.Generic;
using KingPandaMedia.Models.Interfaces;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models.EFRepositoryModels
{
    public class EFPortfolioRepository : IPortfolioRepository
    {
        private KingPandaMediaDbContext context;

        public EFPortfolioRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Portfolio> Media => context.Media;

    }
}
