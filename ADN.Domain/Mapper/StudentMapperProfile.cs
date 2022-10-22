using ADN.Domain.Domain;
using ADN.Domain.DTO.Student;
using AutoMapper;

namespace ADN.Domain.Mapper
{
    public class StudentMapperProfile : Profile
    {
        public StudentMapperProfile()
        {
            CreateMap<Student, StudentInsertDTO>().ReverseMap();
        }
    }
}
