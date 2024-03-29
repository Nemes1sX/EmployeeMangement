﻿using EmployeeMangement.DataContext;
using EmployeeMangement.Infrastructure;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.Entities;
using EmployeeMangement.Models.FormRequest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                 .Include(l => l.Location)
                 .ToListAsync();


            return _mapper.MapEmployee().Map<List<EmployeeDto>>(employeesList);
        }

        public async Task<EmployeeDto> GetEmployeeById(int id)
        {
            var employee = await _db.Employees.Include(b => b.Boss).Include(r => r.Role).Include(l => l.Location).SingleAsync(x => x.Id == id);

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
                 .Include(l => l.Location)
                 .ToListAsync();

            return _mapper.MapEmployee().Map<List<EmployeeDto>>(employees);

        }

        public async Task<List<EmployeeDto>> GetEmployeesByNameAndBirthDate(string name, string from, string to)
        {
            DateTime fromDate;
            DateTime toDate;
            DateTime.TryParse(from, out fromDate);
            DateTime.TryParse(to, out toDate);
        
            var employees =  _db.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                employees = employees.Where(x => x.FirstName.ToLower().StartsWith(name.ToLower())
               || x.LastName.ToLower().StartsWith(name.ToLower()));
            }
            if (fromDate > toDate)
            {
                DateTime tewp = fromDate;
                fromDate = toDate;
                toDate = tewp;
            }           
            if (!string.IsNullOrEmpty(from))
            {
                employees = employees.Where(x => x.BirthDate >= fromDate);
            }
            if(!string.IsNullOrEmpty(to))
            {
                employees = employees.Where(y => y.BirthDate <= toDate);
            }
            var employeesList = await 
                employees
               .Include(x => x.Boss)
               .Include(x => x.Role)
               .Include(l => l.Location)
               .ToListAsync();

            return _mapper.MapEmployee().Map<List<EmployeeDto>>(employees);

        }

        public async Task<CountRoleAvgSalaryDto> CountAndAverageSalaryByRole(int roleId)
        {
            var role = await _db.Roles.FindAsync(roleId);
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
 
            employee = SaveEmployee(employee, request);

            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();

            return _mapper.MapEmployee().Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> UpdateEmployee(int id, EmployeeRequest request)
        {
            var employee = await _db.Employees.FindAsync(id);
            if (employee == null)
            {
                return null;
            }

   
            employee = SaveEmployee(employee, request);

            await _db.SaveChangesAsync();

            return _mapper.MapEmployee().Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> UpdateEmployeeSalary(int id, int salary)
        {

            var employee = await _db.Employees.FindAsync(id);
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
            var employee = await _db.Employees.FindAsync(id);
            if (employee == null)
            {
                return 0;
            }

            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync();

            return id;
        }

        private Employee SaveEmployee(Employee employee, EmployeeRequest request)
        {
            employee.BossId = request.BossId;
            employee.RoleId = request.RoleId;
            employee.LocationId = request.LocationId;
            employee.LastName = request.LastName;
            employee.FirstName = request.FirstName;
            employee.BirthDate = request.BirthDate;
            employee.EmploymentDate = request.EmploymentDate;
            employee.HomeAddress = request.Address;
            employee.Salary = request.Salary;

            return employee;
        }
    }
}
