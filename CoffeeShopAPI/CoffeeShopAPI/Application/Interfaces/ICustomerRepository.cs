using CoffeeShopAPI.Domain.Entities;

namespace CoffeeShopAPI.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetByEmailAsync(string email);
    }
}
