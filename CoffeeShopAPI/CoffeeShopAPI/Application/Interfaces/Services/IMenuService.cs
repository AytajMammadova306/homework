using CoffeeShopAPI.Application.DTOs.Menu;

namespace CoffeeShopAPI.Application.Interfaces.Services
{
    public interface IMenuService
    {
        Task<List<MenuItemResponseDto>> GetAllAsync();
    }
}
