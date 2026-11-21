using CoffeeShopAPI.Application.DTOs.Orders;
using CoffeeShopAPI.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoffeeShopAPI.Controllers
{
    [ApiController]
    [Route("api/orders")]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(
            [FromBody] CreateOrderRequestDto request)
        {
            var customerId = Guid.Parse(
                User.FindFirstValue(ClaimTypes.NameIdentifier)!
            );

            var result = await _orderService.CreateAsync(
                request,
                customerId
            );

            return StatusCode(
                StatusCodes.Status201Created,
                result
            );
        }

        [HttpGet]
        public async Task<IActionResult> GetMyOrders()
        {
            var customerId = Guid.Parse(
                User.FindFirstValue(ClaimTypes.NameIdentifier)!
            );

            var orders = await _orderService.GetMyOrdersAsync(
                customerId
            );

            return Ok(orders);
        }
    }
}
