using CoffeeShopAPI.Domain.Entities;

namespace CoffeeShopAPI.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);

        Task<List<Order>> GetByCustomerIdAsync(Guid customerId);
    }
}
