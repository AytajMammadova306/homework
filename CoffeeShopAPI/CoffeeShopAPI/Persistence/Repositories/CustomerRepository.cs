using CoffeeShopAPI.Application.Interfaces;
using CoffeeShopAPI.Domain.Entities;
using CoffeeShopAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopAPI.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == email);
        }
    }
}
