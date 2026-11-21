using CoffeeShopAPI.Domain.Entities;

namespace CoffeeShopAPI.Application.Interfaces
{
    public interface IMenuItemRepository
    {
        Task<MenuItem?> GetByIdAsync(Guid id);

        Task<List<MenuItem>> GetAllAsync();
    }
}
