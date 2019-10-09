using KingPandaMedia.Models.Tables;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace KingPandaMedia.Models.Interfaces
{
    public interface IPortfolioRepository
    {
        IQueryable<Portfolio> Portfolios { get; }
    }
    public interface IUserRepository
    {
        IQueryable<KPMUser> KPMUsers { get; }
    }
    public interface IEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
    }
}
