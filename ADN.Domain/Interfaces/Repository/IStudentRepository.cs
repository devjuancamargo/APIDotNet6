using ADN.Domain.Domain;
using ADN.Domain.DTO.Student;

namespace ADN.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task Insert(Student student);
        Task<List<Student>> GetById(string id);
        Task Update(Student student);
        Task Delete(string id);
    }
}
