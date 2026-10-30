using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementWeb.Model;

namespace SchoolManagementWeb.Controllers
{
    [Route("/courses")]
    [ApiController]
    public class CourseController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = context.Courses.ToList();
            return Ok(courses);
        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return Ok(course);
        }
    }
}
