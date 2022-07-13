using VerstaTask.Models;

namespace VerstaTask.Data;

public interface IDatabaseContext
{
    Task<Order> AddOrder(Order order);
    Task<List<Order>> GetOrders();
    Task SaveChanges();
}