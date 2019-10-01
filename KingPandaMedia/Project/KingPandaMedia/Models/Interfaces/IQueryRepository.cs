using KingPandaMedia.Models.Tables;
using System.Linq;

namespace KingPandaMedia.Models.Interfaces
{
    public interface IPortfolioRepository
    {
        IQueryable<Portfolio> Portfolios { get; }
    }
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
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
