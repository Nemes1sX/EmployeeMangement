using EmployeeMangement.Models;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMangement.DataLayer
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeDto>> GetEmployees();
        Task<EmployeeDto> GetEmployeeById(int id);
        Task<List<EmployeeDto>> GetEmployeesByBoss(int bossId);
        Task<List<EmployeeDto>> GetEmployeesByNameAndBirthDate(string name, DateTime from, DateTime to);
        Task<CountRoleAvgSalaryDto> CountAndAverageSalaryByRole(int roleId);
        Task<EmployeeDto> AddEmployee(EmployeeRequest request);
        Task<EmployeeDto> UpdateEmployee(int id, EmployeeRequest request);
        Task<EmployeeDto> UpdateEmployeeSalary(int id, int salary);
        Task<int> DeleteEmployee(int id);
    }
}
