namespace CoffeeShopAPI.Domain.Entities
{
    public sealed class Order : AuditableEntity
    {
        public Guid CustomerId { get; set; }

        public Guid MenuItemId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => UnitPrice * Quantity;

        public Customer Customer { get; set; } = null!;

        public MenuItem MenuItem { get; set; } = null!;
    }
}
