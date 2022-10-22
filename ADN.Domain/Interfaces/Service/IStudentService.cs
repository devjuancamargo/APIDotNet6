using ADN.Domain.Domain;
using ADN.Domain.DTO.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN.Domain.Interfaces.Service
{
    public interface IStudentService
    {
        Task<List<Student>> GetAll();
        Task Insert(StudentInsertDTO studentDTO);
        Task<Student> GetById(string id);
        Task Update(string id, StudentInsertDTO student);
        Task Delete(string id);
    }
}
