using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementWeb.Model;

namespace SchoolManagementWeb.Controllers
{
    [Route("/studentcourses")]
    [ApiController]
    public class StudentCourseController(AppDbContext context) : ControllerBase
    {
        [HttpGet("{studentId}")]
        public IActionResult GetCoursesOfStudent(int studentId)
        {
            var courses = context.StudentCourses
                .Where(sc => sc.StudentId == studentId)
                .Select(sc => new { sc.Course.Id, sc.Course.Name })
                .ToList();

            return Ok(courses);
        }
        [HttpPost]
        public IActionResult AddStudentToCourse(StudentCourse studentCourse)
        {
            if (!context.Students.Any(s => s.Id == studentCourse.StudentId))
                return NotFound("Student not found");
            if (!context.Courses.Any(c => c.Id == studentCourse.CourseId))
                return NotFound("Course not found");
            if (context.StudentCourses.Any(sc =>
                    sc.StudentId == studentCourse.StudentId &&
                    sc.CourseId == studentCourse.CourseId))
                return BadRequest("Student is already enrolled in this course");

            context.StudentCourses.Add(studentCourse);
            context.SaveChanges();
            return Ok(studentCourse);
        }
    }
}
