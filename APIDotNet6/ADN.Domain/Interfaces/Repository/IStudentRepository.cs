using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task Insert(Student student);
    }
}
