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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            if (id.Length != 24)
                return BadRequest("Id deve ter 24 caracteres");

            var student = await _service.GetById(id);

            if (student is not null)
                return Ok(student);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(StudentInsertDTO studentDTO)
        {
            await _service.Insert(studentDTO);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, StudentInsertDTO studentDTO)
        {
            if (id.Length != 24)
                return BadRequest("Id deve ter 24 caracteres");

            await _service.Update(id, studentDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id.Length != 24)
                return BadRequest();

            await _service.Delete(id);
            return NoContent();
        }
    }
}
