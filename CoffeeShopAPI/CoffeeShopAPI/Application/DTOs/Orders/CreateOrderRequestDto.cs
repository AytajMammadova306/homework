using System.ComponentModel.DataAnnotations;

namespace CoffeeShopAPI.Application.DTOs.Orders
{
    public class CreateOrderRequestDto
    {
        public Guid MenuItemId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
