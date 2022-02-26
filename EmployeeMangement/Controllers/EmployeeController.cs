using EmployeeMangement.DataLayer;
using EmployeeMangement.Models.Entities;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using EmployeeMangement.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using System.Web.Http;

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
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployees()
        {
            var employees = await _employeeRepository.GetEmployees();

            if (employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpGet]
        [Route("show/{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpGet]
        [Route("boss")]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployeeByBoss(int bossId)
        {
            var employees = await _employeeRepository.GetEmployeesByBoss(bossId);

            if (employees == null || employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpGet]
        [Route("role")]
        public async Task<ActionResult<CountRoleAvgSalaryDto>> GetAverageSalaryAndRole(int roleId)
        {
            var result = await _employeeRepository.CountAndAverageSalaryByRole(roleId);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("getbynameandbirth")]
        public async Task<ActionResult<List<EmployeeDto>>> GetByNameAndBirthDate(string name, string from, string to)
        {
            var employees = await _employeeRepository.GetEmployeesByNameAndBirthDate(name, from, to);

            if (employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<EmployeeDto>> AddEmployee(EmployeeRequest request)
        {
            var employee = await _employeeRepository.AddEmployee(request);

            return Ok(employee);

        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult<EmployeeDto>> UpdateEmployee(int id, EmployeeRequest request)
        {
            var employee = await _employeeRepository.UpdateEmployee(id, request);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPatch]
        [Route("updatesalary")]
        public async Task<ActionResult<EmployeeDto>> UpdateEmployeeSalary(int id, int salary)
        {

            var employee = await _employeeRepository.UpdateEmployeeSalary(id, salary);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<int>> DeleteEmployee(int id)
        {
            var recordId = await _employeeRepository.DeleteEmployee(id);
            if (recordId == 0)
                return NotFound();

            return Ok(id);
        }
    }
}
