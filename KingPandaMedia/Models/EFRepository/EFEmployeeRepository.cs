using System.Linq;
using System.Collections.Generic;
using KingPandaMedia.Models.Interfaces;
using KingPandaMedia.Models.Tables;


namespace KingPandaMedia.Models
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private KingPandaMediaDbContext context;
        public EFEmployeeRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Employees> Employees => context.Employees;
    }
}
