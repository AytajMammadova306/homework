using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementWebAPI.Model;

namespace RestaurantManagementWebAPI.Controllers
{
    [Route("/categories")]
    [ApiController]
    public class CategoryController (AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories= context.Categories.ToList();
            return Ok(categories);
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name) || category.Name.Length > 50)
                return BadRequest("Name is required and must be at most 50 characters.");

            context.Categories.Add(category);
            context.SaveChanges();
            return Ok(category);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, Category updated)
        {
            var category = context.Categories.Find(id);
            if (category is null) return NotFound();

            if (string.IsNullOrWhiteSpace(updated.Name) || updated.Name.Length > 50)
                return BadRequest("Name is required and must be at most 50 characters.");

            category.Name = updated.Name;
            context.SaveChanges();
            return Ok(category);
        }

    }
}
