namespace CoffeeShopAPI.Domain.Entities
{
    public sealed class MenuItem : AuditableEntity
    {
        public string Name { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public int StockQuantity { get; set; }
    }
}
