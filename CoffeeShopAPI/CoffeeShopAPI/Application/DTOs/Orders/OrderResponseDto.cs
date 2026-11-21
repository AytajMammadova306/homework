namespace CoffeeShopAPI.Application.DTOs.Orders
{
    public class OrderResponseDto
    {
        public Guid Id { get; set; }
        public string DrinkName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
