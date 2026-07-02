using Microsoft.AspNetCore.Mvc;
using StudentAPI.DataSimulation;
using System.Collections.Generic;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/StudentAPI")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = StudentDataSimulation.StudentsList;
            return Ok(students);
        }
    }
}
