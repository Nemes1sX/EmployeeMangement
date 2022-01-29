using EmployeeMangement.Models;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using EmployeeMangement.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.DataLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _db;
        private readonly LoggingException _loggingException; 

        public EmployeeRepository(EmployeeContext db, LoggingException loggingException)
        {
            _db = db;
            _loggingException = loggingException;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            try
            {
                return await _db.Employees.ToListAsync();
            } catch (Exception ex) 
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            try
            {
                return await _db.Employees.FindAsync(id);
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<List<Employee>> GetEmployeesByBoss(int bossId)
        {
            try
            {
                return await _db.Employees.Where(x => x.BossId == bossId).ToListAsync();
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<List<Employee>> GetEmployeesByNameAndBirthDate(string name, DateTime from, DateTime to)
        {
            try
            {
                return await _db.Employees.Where(x => x.FirstName == name && (x.BirthDate >= from && x.BirthDate <= to)).ToListAsync();
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<CountRoleAvgSalaryDto> CountAndAverageSalaryByRole(int roleId)
        {
           try
            {
                var result = new CountRoleAvgSalaryDto();
                result.Count = await _db.Employees.Where(x => x.RoleId == roleId).CountAsync();
                decimal totalSalary = await _db.Employees.Where(x => x.RoleId == roleId).SumAsync(x => x.Salary);
                result.AverageSalary = Math.Round((totalSalary / result.Count), 2);

                return result;
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<Employee> AddEmployee(EmployeeRequest request)
        {
            try
            {
                var employee = new Employee();
                employee.BossId = request.BossId;
                employee.RoleId = request.RoleId;
                employee.LastName = request.LastName;
                employee.FirstName = request.FirstName;
                employee.BirthDate = request.BirthDate;
                employee.EmploymentDate = request.EmployentDate;
                employee.HomeAddress = request.Address;
                employee.Salary = request.Salary;

                await _db.SaveChangesAsync();
                
                return employee;
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<Employee> UpdateEmployee(int id, EmployeeRequest request)
        {
            try
            {
                var employee = _db.Employees.Find(id);
                if (employee == null)
                {
                    return null;
                }

                employee.BossId = request.BossId;
                employee.RoleId = request.RoleId;
                employee.LastName = request.LastName;
                employee.FirstName = request.FirstName;
                employee.BirthDate = request.BirthDate;
                employee.EmploymentDate = request.EmployentDate;
                employee.HomeAddress = request.Address;
                employee.Salary = request.Salary;

                await _db.SaveChangesAsync();

                return employee;
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<Employee> UpdateEmployeeSalary(int id, int salary)
        {
            try
            {
                var employee = _db.Employees.Find(id);
                if (employee == null)
                {
                    return null;
                }

                employee.Salary = salary;

                await _db.SaveChangesAsync();

                return employee;
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return null;
            }
        }

        public async Task<int> DeleteEmployee(int id)
        {
            try
            {
                var employee = _db.Employees.Find(id);
                if (employee == null)
                {
                    return 0;
                }

                _db.Employees.Remove(employee);
                await _db.SaveChangesAsync();

                return id;
            }
            catch (Exception ex)
            {
                _loggingException.SaveLogFile(ex.Message);
                return 0;
            }
        }
    }
}
