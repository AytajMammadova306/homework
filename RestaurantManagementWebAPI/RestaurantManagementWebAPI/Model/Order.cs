namespace RestaurantManagementWebAPI.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }= DateTime.Now;
        public string Status { get; set; }
        public List<OrderItem> OrderItems { get; set; }= new List<OrderItem>();
    }
}
