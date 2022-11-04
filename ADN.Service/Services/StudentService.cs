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

        public async Task<Student?> GetById(string id)
        {
            var list = await _repository.GetById(id);

            if(list.Any())
                return list.FirstOrDefault();
            return null;
        }

        public async Task Insert(StudentInsertDTO studentDTO)
        {
           Student student = _mapper.Map<Student>(studentDTO);
            await _repository.Insert(student);
        }

        public async Task Update(string id, StudentInsertDTO student)
        {
            var std = await GetById(id);
            if (std is not null)
            {
                std = _mapper.Map<Student>(student);
                
                await _repository.Update(std);
            }
        }
        public async Task Delete(string id)
        {
            if(await _repository.GetById(id) is not null)
               await _repository.Delete(id);
        }
    }
}
