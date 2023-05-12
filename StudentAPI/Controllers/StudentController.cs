using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;

        private IStudetService _studetService;
        public StudentController(IStudetService studetService)
        {
            _studetService = studetService;
        }

        [HttpPost]
        [Route("data")]
        public IEnumerable<Student> GetStudents()
        {
            return _studetService.GetStudents();
        }

        [HttpGet]
        [Route("search")]
        public IEnumerable<Student> GetStudentsByValue(string value)
        {
            return _studetService.GetStudents().Where(x=> x.Age.ToString().Contains(value) || x.Name.Contains(value) || x.Hobbies.Contains(value)).ToList();
        }
    }
}
