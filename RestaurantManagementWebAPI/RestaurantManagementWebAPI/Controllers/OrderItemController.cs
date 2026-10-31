using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementWebAPI.Model;

namespace RestaurantManagementWebAPI.Controllers
{
    [Route("/orderItems")]
    [ApiController]
    public class OrderItemController(AppDbContext context) : ControllerBase
    {
        [HttpPost]
        public IActionResult AddOrderItem(OrderItem orderItem)
        {
            if (orderItem.Quantity <= 0)
                return BadRequest("Quantity must be greater than 0.");
            if (!context.Orders.Any(o => o.Id == orderItem.OrderId))
                return NotFound("Order not found.");
            if (!context.Products.Any(p => p.Id == orderItem.ProductId))
                return NotFound("Product not found.");

            var existing = context.OrderItems.Find(orderItem.OrderId, orderItem.ProductId);
            if (existing is null)
            {
                context.OrderItems.Add(new OrderItem
                {
                    OrderId = orderItem.OrderId,
                    ProductId = orderItem.ProductId,
                    Quantity = orderItem.Quantity
                });
            }
            else
            {
                existing.Quantity += orderItem.Quantity;
            }

            context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{orderId}/{productId}")]
        public IActionResult RemoveOrderItem(int orderId, int productId)
        {
            var item = context.OrderItems.Find(orderId, productId);
            if (item is null) return NotFound();

            context.OrderItems.Remove(item);
            context.SaveChanges();
            return NoContent();
        }
    }
}
