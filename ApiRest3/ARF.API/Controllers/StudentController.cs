using ARF.Domain;
using ARF.Service;
using Microsoft.AspNetCore.Mvc;

namespace ARF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add(Student student)
        {
            StudentService service = new StudentService();
            service.AddStudent(student);


            return StatusCode(201);
        }
    }
}
