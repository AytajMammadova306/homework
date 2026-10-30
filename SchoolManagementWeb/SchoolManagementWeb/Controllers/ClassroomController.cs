using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementWeb.Model;

namespace SchoolManagementWeb.Controllers
{
    [Route("/classrooms")]
    [ApiController]
    public class ClassroomController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClassrooms()
        {
            var classrooms = context.Classrooms.ToList();
            return Ok(classrooms);
        }
        [HttpPost]
        public IActionResult AddClassroom(Classroom classroom)
        {
            context.Classrooms.Add(classroom);
            context.SaveChanges();
            return Ok(classroom);
        }
    }
}
