using AutoMapper;
using EmployeeMangement.Models;
using EmployeeMangement.Models.Dtos;

namespace EmployeeMangement.Infrastructure
{
    public class Mapping
    {
        public  Mapper MapEmployee()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Boss, act => act.MapFrom(
                   src => src.Boss.FirstName + " " + src.Boss.LastName
                 ))
                .ForMember(dest => dest.Role, act => act.MapFrom(
                    src => src.Role.Name
                 ))
                 .ForMember(dest => dest.Name, act => act.MapFrom(
                     src => src.FirstName + "  " + src.LastName
                  ));
            });
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
