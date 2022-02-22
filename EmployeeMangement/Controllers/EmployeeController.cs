using EmployeeMangement.DataLayer;
using EmployeeMangement.Models;
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
        private readonly LoggingException _loggingException;

        public EmployeeController(IEmployeeRepository employeeRepository, LoggingException loggingException)
        {
            _employeeRepository = employeeRepository;
            _loggingException = loggingException;
        }

        [HttpGet]
        [Route("index")]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployees()
        {
            try
            {
                var employees = await _employeeRepository.GetEmployees();

                if (employees.Count == 0)
                {
                    return NotFound();
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("show/{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeById(id);
                if (employee == null)
                {
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("boss")]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployeeByBoss(int bossId)
        {
            try
            {
                var employees = await _employeeRepository.GetEmployeesByBoss(bossId);

                if (employees == null || employees.Count == 0)
                {
                    return NotFound();
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet]
        [Route("role")]
        public async Task<ActionResult<CountRoleAvgSalaryDto>> GetAverageSalaryAndRole(int roleId)
        {
            try
            {
                var result = await _employeeRepository.CountAndAverageSalaryByRole(roleId);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("getbynameandbirth")]
        public async Task<ActionResult<List<EmployeeDto>>> GetByNameAndBirthDate(string name, string from, string to)
        {
            try
            {
                var employees = await _employeeRepository.GetEmployeesByNameAndBirthDate(name, from, to);

                if (employees.Count == 0)
                {
                    return NotFound();
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<EmployeeDto>> AddEmployee(EmployeeRequest request)
        {
            try
            {
                var employee = await _employeeRepository.AddEmployee(request);

                return Ok(employee);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult<EmployeeDto>> UpdateEmployee(int id, EmployeeRequest request)
        {
            try
            {
                var employee = await _employeeRepository.UpdateEmployee(id, request);

                if (employee == null)
                    return NotFound();

                return Ok(employee);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPatch]
        [Route("updatesalary")]
        public async Task<ActionResult<EmployeeDto>> UpdateEmployeeSalary(int id, int salary)
        {
            try
            {
                var employee = await _employeeRepository.UpdateEmployeeSalary(id, salary);

                if (employee == null)
                    return NotFound();

                return Ok(employee);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<int>> DeleteEmployee(int id)
        {
            try
            {

                var recordId = await _employeeRepository.DeleteEmployee(id);
                if (recordId == 0)
                    return NotFound();

                return Ok(id);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
