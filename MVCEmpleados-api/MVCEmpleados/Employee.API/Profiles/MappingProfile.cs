using AutoMapper;
using Employee.Entities;

namespace Employee.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
        }
    }
}
