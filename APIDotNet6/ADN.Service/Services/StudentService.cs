using ADN.Domain.Domain;
using ADN.Domain.Interfaces.Repository;
using ADN.Domain.Interfaces.Service;

namespace ADN.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _repository.GetAll();
        }
    }
}
