using EmployeeMangement.DataLayer;
using EmployeeMangement.Models;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("index")]
        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        [HttpGet]
        [Route("show/{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        [HttpGet]
        [Route("boss/{id}")]
        public async Task<List<Employee>> GetEmployeeByBoss(int bossId)
        {
            return await _employeeRepository.GetEmployeesByBoss(bossId);

        }

        [HttpGet]
        [Route("role/{id}")]
        public async Task<CountRoleAvgSalaryDto> GetAverageSalaryAndRole(int roleId)
        {
            return await _employeeRepository.CountAndAverageSalaryByRole(roleId);
        }

        [HttpGet]
        [Route("get/{name}{from}{to}")]
        public async Task<List<Employee>> GetEmployeeByNameAndBirthDate(string name, DateTime from, DateTime to)
        {
            return await _employeeRepository.GetEmployeesByNameAndBirthDate(name, from, to);    
        }

        [HttpPost]
        [Route("add")]
        public async Task<Employee> AddEmployee(EmployeeRequest request)
        {
            return await _employeeRepository.AddEmployee(request);
        }

        [HttpPost]
        [Route("update/{id}")]
        public async Task<Employee> UpdateEmployee(int id, EmployeeRequest request)
        {
            return await _employeeRepository.UpdateEmployee(id, request);
        }

        [HttpPost]
        [Route("updatesalary/{id}")]
        public async Task<Employee> UpdateEmployeeSalary(int id, int salary)
        {
            return await _employeeRepository.UpdateEmployeeSalary(id, salary);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _employeeRepository.DeleteEmployee(id);
        }
    }
}
