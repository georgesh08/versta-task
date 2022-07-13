using Microsoft.EntityFrameworkCore;
using VerstaTask.Models;

namespace VerstaTask.Data;

public sealed class VerstaTaskContext : DbContext, IDatabaseContext
{
    private DbSet<Order> Orders { get; set; }

    public VerstaTaskContext(DbContextOptions<VerstaTaskContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public VerstaTaskContext() { }

    public async Task<Order> AddOrder(Order order)
    {
        await Orders.AddAsync(order);
        await SaveChangesAsync();
        return order;
    }

    public async Task<List<Order>> GetOrders()
    {
        return await Orders.ToListAsync();
    }

    public new async Task SaveChanges()
    {
        await SaveChangesAsync();
    }
}