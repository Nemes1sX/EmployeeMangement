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
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<List<Employee>> GetEmployeesByBoss(int bossId);
        Task<List<Employee>> GetEmployeesByNameAndBirthDate(string name, DateTime from, DateTime to);
        Task<CountRoleAvgSalaryDto> CountAndAverageSalaryByRole(int roleId);
        Task<Employee> AddEmployee(EmployeeRequest request);
        Task<Employee> UpdateEmployee(int id, EmployeeRequest request);
        Task<Employee> UpdateEmployeeSalary(int id, int salary);
        Task<int> DeleteEmployee(int id);
    }
}
