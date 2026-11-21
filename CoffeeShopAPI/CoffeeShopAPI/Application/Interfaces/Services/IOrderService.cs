using CoffeeShopAPI.Application.DTOs.Orders;

namespace CoffeeShopAPI.Application.Interfaces.Services
{
    public interface IOrderService
    {
        Task<OrderResponseDto> CreateAsync(
            CreateOrderRequestDto request,
            Guid customerId);

        Task<List<OrderResponseDto>> GetMyOrdersAsync(Guid customerId);
    }
}
