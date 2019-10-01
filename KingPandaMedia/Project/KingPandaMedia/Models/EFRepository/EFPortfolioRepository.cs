using System.Linq;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.Interfaces;

namespace KingPandaMedia.Models.EFRepository
{
    public class EFPortfolioRepository : IPortfolioRepository
    {
        private KingPandaMediaDbContext context;
        public EFPortfolioRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Portfolio> Portfolios => context.Portfolios;
    }
}
