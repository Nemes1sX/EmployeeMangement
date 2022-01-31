using EmployeeMangement.DataContext;
using EmployeeMangement.DataLayer;
using EmployeeMangement.Infrastructure;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using Xunit;

namespace EmployeeTest
{
    public class TestEmployee
    {
        private EmployeeRepository repo;
        private Mapping mapper;
        public static DbContextOptions<EmployeeContext> dbContextOptions { get; }
        public static IConfiguration Configuration { get; }

        //public static string connectionString = Configuration["ConnectionStrings:TestEmployeeDatabase"];

        public static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestEmlpoymentManagement;Trusted_Connection=False;Integrated Security=False;MultipleActiveResultSets=True";

        static TestEmployee()
        {
            dbContextOptions = new DbContextOptionsBuilder<EmployeeContext>()
           .UseSqlServer(connectionString)
           .Options;
        }

        public TestEmployee()
        {
            var context = new EmployeeContext(dbContextOptions);
            TestDBInit db = new TestDBInit();
            db.Seed(context);

            repo = new EmployeeRepository(context, mapper);
        }

        [Fact]
        public async void Task_GetEmployees()
        {
            var data = await repo.GetEmployees();

            Assert.IsType<List<EmployeeDto>>(data);
            Assert.Equal(100, data.Count);
        }

        [Fact]
        public async void Task_CreateEmployee()
        {
            var employeeeRequest = new EmployeeRequest
            {
                FirstName = "Testas",
                LastName = "Testenis",
                Address = "Kretingos 14",
                EmployentDate = DateTime.Now.AddYears(-5),
                BirthDate = DateTime.Now.AddYears(-25),
                BossId = 1,
                RoleId = 2,
                Salary = 1500,
            };
            
            var data = await repo.AddEmployee(employeeeRequest);

            Assert.IsType<EmployeeDto>(data);
            Assert.Equal(data.Name, employeeeRequest.FirstName + " " + employeeeRequest.LastName);
            Assert.Equal(data.HomeAddress, employeeeRequest.Address);
            Assert.Equal(data.BirthDate, employeeeRequest.BirthDate);
            Assert.Equal(data.EmploymentDate, employeeeRequest.EmployentDate);
            Assert.Equal(data.Salary, employeeeRequest.Salary);            
        }

        [Fact]
        public async void Task_GetEmployeeById()
        {
            var employeeId = 101;

            var data = await repo.GetEmployeeById(employeeId);

            Assert.NotNull(data);
            Assert.IsType<EmployeeDto>(data);
        }

        [Fact]
        public async void Task_UpdateEmployee()
        {
            var employeeeRequest = new EmployeeRequest
            {
                FirstName = "Testas",
                LastName = "Testenis",
                Address = "Kretingos 15",
                EmployentDate = DateTime.Now.AddYears(-5),
                BirthDate = DateTime.Now.AddYears(-25),
                BossId = 1,
                RoleId = 2,
                Salary = 1500,
            };

            var employeeId = 101;

            var data = await repo.UpdateEmployee(employeeId, employeeeRequest);

            Assert.NotNull(data);
            Assert.IsType<EmployeeDto>(data);
            Assert.Equal(employeeeRequest.Address, data.HomeAddress);
        }

        [Fact]
        public async void Task_DeleteEmployee()
        {
            var employeeId = 101;

            await repo.DeleteEmployee(employeeId);
            var data = await repo.GetEmployeeById(employeeId);

            Assert.Null(data);
        }
    }
}
