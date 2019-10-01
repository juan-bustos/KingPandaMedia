using System.Linq;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.Interfaces;

namespace KingPandaMedia.Models.EFRepository
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private KingPandaMediaDbContext context;

        public EFEmployeeRepository(KingPandaMediaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Employee> Employees => context.Employees;
    }
}
