namespace CoffeeShopAPI.Application.DTOs.Menu
{
    public class MenuItemResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; }
    }
}
