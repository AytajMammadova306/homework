using CoffeeShopAPI.Domain.Entities;

namespace CoffeeShopAPI.Application.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateToken(Customer customer);
    }
}
