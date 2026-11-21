using CoffeeShopAPI.Application.Interfaces;
using CoffeeShopAPI.Domain.Entities;
using CoffeeShopAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopAPI.Persistence.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly AppDbContext _context;

        public MenuItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<MenuItem?> GetByIdAsync(Guid id)
        {
            return await _context.MenuItems
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<MenuItem>> GetAllAsync()
        {
            return await _context.MenuItems
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
