using System.Linq;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models.Interfaces
{
    public interface IPortfolioRepository
    {
        IQueryable<Portfolio> Media { get; }
    }
    public interface IUserRepository
    {
        IQueryable<Users> Users { get; }
    }
    public interface IEmployeeRepository
    {
        IQueryable<Employees> Employees { get; }
    }
    public interface IOrderRepository
    {
        IQueryable<Orders> Orders { get; }
    }
}
