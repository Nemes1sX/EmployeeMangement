using AutoMapper;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.Entities;
using System.Collections.Generic;

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
                     src => src.FirstName + " " + src.LastName
                  ))
                 .ForMember(dest => dest.Location, act => act.MapFrom(
                     src => src.Location.Name + " " + src.Location.Address
                  ));
            });
            var mapper = new Mapper(config);
            return mapper;
        }

        public LocationDto MapLocation(Location location)
        {
            var locationDto = new LocationDto();
            locationDto.Id = location.Id;
            locationDto.Name = location.Name;
            locationDto.Address = location.Address;
            locationDto.MaxAllocation = location.MaxAllocation;
            locationDto.Employees = new List<LocationEmployeeDto>();
            foreach (var employee in location.Employees)
            {
                var employeeDto = new LocationEmployeeDto();
                employeeDto.Id = employee.Id;
                employeeDto.Name = employee.FirstName + " " + employee.LastName;
                locationDto.Employees.Add(employeeDto);
            }
            return locationDto;
        }
    }
}
