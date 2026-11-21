using CoffeeShopAPI.Application.Interfaces;
using CoffeeShopAPI.Domain.Entities;
using CoffeeShopAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopAPI.Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
        }

        public async Task<List<Order>> GetByCustomerIdAsync(
            Guid customerId)
        {
            return await _context.Orders
                .AsNoTracking()
                .Include(o => o.MenuItem)
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
