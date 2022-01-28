using EmployeeMangement.Models;
using EmployeeMangement.Models.FormRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Employee>> GetEmployee()
        {
            return new List<Employee>();
        }

        [HttpGet]
        public async Task<Employee> GetEmployee(int id)
        {

        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployeeByBoss(int bossId)
        {
            return new List<Employee>();

        }

        [HttpGet]
        public async Task<List<Employee>> GetAverageSalaryAndRole(int roleId)
        {

        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployeeByNameAndBirthDate(string name, DateTime from, DateTime to)
        {
            return new List<Employee>();
        }

        [HttpPost]
        public async Task<Employee> AddEmployee(EmployeeRequest request)
        {
            return new Employee();
        }

        [HttpPost]
        public async Task<Employee> UpdateEmployee(int id, EmployeeRequest request)
        {
            return new Employee();
        }

        [HttpPost]
        public async Task<Employee> UpdateEmployeeSalary(int id, int salary)
        {
            return new Employee();
        }

        [HttpDelete]
        public async Task<int> DeleteEmployee(int id)
        {
            return id;
        }
    }
}
