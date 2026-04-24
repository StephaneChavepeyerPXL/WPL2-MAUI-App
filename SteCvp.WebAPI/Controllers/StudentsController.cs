using Microsoft.AspNetCore.Mvc;
using SteCvp.Application.Services;
using SteCvp.Domain;

namespace SteCvp.Api.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class StudentsController : ControllerBase

    {

        private readonly StudentService _service;

        public StudentsController()

        {

            _service = new StudentService();

        }

        [HttpGet]

        public ActionResult<List<Student>> Get()

        {

            return Ok(_service.GetStudents());

        }

        [HttpPost]

        public IActionResult Post([FromBody] Student student)

        {

            _service.AddStudent(student.FirstName, student.LastName);

            return Ok();

        }

    }
}
