using ADN.Domain.Domain;
using ADN.Domain.DTO.Student;
using ADN.Domain.Interfaces.Repository;
using ADN.Domain.Interfaces.Service;
using AutoMapper;

namespace ADN.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository repository,
                              IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _repository.GetAll();
        }

        public Task<Student> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(StudentInsertDTO studentDTO)
        {
           Student student = _mapper.Map<Student>(studentDTO);
            await _repository.Insert(student);
        }

        public Task Update(string id, StudentInsertDTO student)
        {
            throw new NotImplementedException();
        }
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
