using System.Linq;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.Interfaces;

namespace KingPandaMedia.Models.EFRepository
{
    public class EFOrderRepository : IOrderRepository
    {
        private KingPandaMediaDbContext context;
        public EFOrderRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders;
    }
}
