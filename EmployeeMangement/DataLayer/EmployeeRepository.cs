using EmployeeMangement.DataContext;
using EmployeeMangement.Infrastructure;
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
        private Mapping _mapper;

        public EmployeeRepository(EmployeeContext db, Mapping mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> GetEmployees()
        {
            var employeesList = await _db.Employees
                 .Include(b => b.Boss)
                 .Include(r => r.Role)
                 .ToListAsync();


            return _mapper.MapEmployee().Map<List<EmployeeDto>>(employeesList);
        }

        public async Task<EmployeeDto> GetEmployeeById(int id)
        {
            var employee = await _db.Employees
                            .Include(b => b.Boss).Include(r => r.Role)
                            .SingleAsync(x => x.Id == id);

            return _mapper.MapEmployee().Map<EmployeeDto>(employee);

        }

        public async Task<List<EmployeeDto>> GetEmployeesByBoss(int bossId)
        {
            var boss = _db.Bosses.Find(bossId);
            if (boss == null)
                return null;

            var employees = await _db.Employees.Where(x => x.BossId == bossId)
                 .Include(x => x.Role)
                 .Include(b => b.Boss)
                 .ToListAsync();

            return _mapper.MapEmployee().Map<List<EmployeeDto>>(employees);

        }

        public async Task<List<EmployeeDto>> GetEmployeesByNameAndBirthDate(string name, string from, string to)
        {
            var fromDate = DateTime.Parse(from);
            var toDate = DateTime.Parse(to);    
            var employees = await _db.Employees
               .Where(x => x.FirstName.ToLower().StartsWith(name.ToLower()))    
               .Where(x => x.BirthDate >= fromDate && x.BirthDate <= toDate)
               .Include(x => x.Boss)
               .Include(x => x.Role)
               .ToListAsync();

            return _mapper.MapEmployee().Map<List<EmployeeDto>>(employees);

        }

        public async Task<CountRoleAvgSalaryDto> CountAndAverageSalaryByRole(int roleId)
        {
            var role = _db.Roles.Find(roleId);
            if (role == null)
                return null;

            var result = new CountRoleAvgSalaryDto();
            result.Count = await _db.Employees.Where(x => x.RoleId == roleId).CountAsync();
            decimal totalSalary = await _db.Employees.Where(x => x.RoleId == roleId).SumAsync(x => x.Salary);
            result.AverageSalary = Math.Round((totalSalary / result.Count), 2);

            return result;
        }

        public async Task<EmployeeDto> AddEmployee(EmployeeRequest request)
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

            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();

            return _mapper.MapEmployee().Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> UpdateEmployee(int id, EmployeeRequest request)
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

            return _mapper.MapEmployee().Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> UpdateEmployeeSalary(int id, int salary)
        {

            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return null;
            }

            employee.Salary = salary;

            await _db.SaveChangesAsync();

            return _mapper.MapEmployee().Map<EmployeeDto>(employee);
        }

        public async Task<int> DeleteEmployee(int id)
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
    }
}
