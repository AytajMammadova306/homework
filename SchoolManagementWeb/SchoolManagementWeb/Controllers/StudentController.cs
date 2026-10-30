using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementWeb.Model;

namespace SchoolManagementWeb.Controllers
{
    [Route("/students")]
    [ApiController]
    public class StudentController (AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students=context.Students.ToList();
            return Ok(students);
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return Ok(student);
        }
    }
}
