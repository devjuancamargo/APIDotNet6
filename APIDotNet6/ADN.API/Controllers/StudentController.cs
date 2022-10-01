using ADN.Domain.Domain;
using ADN.Domain.DTO.Student;
using ADN.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace ADN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(StudentInsertDTO studentDTO)
        {
            await _service.Insert(studentDTO);
            return StatusCode(201);
        }
    }
}
