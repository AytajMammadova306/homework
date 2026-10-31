using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementWebAPI.Model;

namespace RestaurantManagementWebAPI.Controllers
{
    [Route("/products")]
    [ApiController]
    public class ProductController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = context.Products.Include(p => p.Category).ToList();
            return Ok(products);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (!context.Categories.Any(c => c.Id == product.CategoryId))
                return BadRequest("Category does not exist.");

            context.Products.Add(product);
            context.SaveChanges();
            return Ok(product);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);
            if (product is null) return NotFound();
            return Ok(product);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updated)
        {
            var product = context.Products.Find(id);
            if (product is null) return NotFound();

            if (!context.Categories.Any(c => c.Id == updated.CategoryId))
                return BadRequest("Category does not exist.");

            product.Name = updated.Name;
            product.Price = updated.Price;
            product.IsAvailable = updated.IsAvailable;
            product.CategoryId = updated.CategoryId;

            context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            if (product is null) return NotFound();

            if (context.OrderItems.Any(oi => oi.ProductId == id))
                return Conflict("This product is used in orders and cannot be deleted.");

            context.Products.Remove(product);
            context.SaveChanges();
            return NoContent();
        }
    }
}
