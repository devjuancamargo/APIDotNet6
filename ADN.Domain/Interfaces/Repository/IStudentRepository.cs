using ADN.Domain.Domain;
using ADN.Domain.DTO.Student;

namespace ADN.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task Insert(Student student);
        Task<Student> GetById(string id);
        Task Update(string id, StudentInsertDTO student);
        Task Delete(string id);
    }
}
