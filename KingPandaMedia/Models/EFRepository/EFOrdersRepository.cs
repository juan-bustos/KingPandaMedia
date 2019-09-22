using System.Linq;
using System.Collections.Generic;
using KingPandaMedia.Models.Interfaces;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models
{
    public class EFOrdersRepository : IOrderRepository
    {
        private KingPandaMediaDbContext context;

        public EFOrdersRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Orders> Orders => context.Orders;
    }
}
