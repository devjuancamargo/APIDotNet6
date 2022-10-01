using ADN.Domain.Domain;
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
    }
}
