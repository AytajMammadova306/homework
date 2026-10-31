using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementWebAPI.Model;

namespace RestaurantManagementWebAPI.Controllers
{
    [Route("/orders")]
    [ApiController]
    public class OrderController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .ToList();
            return Ok(orders);
        }
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefault(o => o.Id == id);

            if (order is null) return NotFound();
            return Ok(order);
        }
        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            if (string.IsNullOrWhiteSpace(order.CustomerName) || order.CustomerName.Length > 100)
                return BadRequest("CustomerName is invalid.");
            if (string.IsNullOrWhiteSpace(order.Status) || order.Status.Length > 30)
                return BadRequest("Status is invalid.");
            if (order.OrderItems.Any(i => i.Quantity <= 0))
                return BadRequest("Quantity must be greater than 0.");

            order.OrderItems = order.OrderItems
                .GroupBy(i => i.ProductId)
                .Select(g => new OrderItem { ProductId = g.Key, Quantity = g.Sum(x => x.Quantity) })
                .ToList();

            var productIds = order.OrderItems.Select(i => i.ProductId).ToList();
            if (context.Products.Count(p => productIds.Contains(p.Id)) != productIds.Count)
                return BadRequest("Some products do not exist.");

            order.Id = 0;
            order.OrderDate = DateTime.Now;

            context.Orders.Add(order);
            context.SaveChanges();
            return Ok(order);
        }
    }
}
