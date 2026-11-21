namespace CoffeeShopAPI.Domain.Entities
{
    public sealed class Customer : AuditableEntity
    {
        public string Email { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string Fullname { get; set; } = null!;

        public ICollection<Order> Orders { get; set; }
            = new List<Order>();
    }
}
