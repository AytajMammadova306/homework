namespace RestaurantManagementWebAPI.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        
    }
}
