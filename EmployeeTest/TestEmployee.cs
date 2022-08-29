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
using Microsoft.Data.Sqlite;
using EmployeeTest.Attributes;
using EmployeeMangement.Models.Entities;
using FizzWare.NBuilder;

namespace EmployeeTest
{
    [TestCaseOrderer("EmployeeTest.Orderers.PriorityOrder", "EmployeeTest")]
    public class TestEmployee
    {
        private EmployeeRepository repo;
        public static DbContextOptions<EmployeeContext> dbContextOptions { get; }
        public static IConfiguration Configuration { get; }

        static TestEmployee()
        {
            dbContextOptions = new DbContextOptionsBuilder<EmployeeContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

        }

        public TestEmployee()
        {
            var context = new EmployeeContext(dbContextOptions);
            var mapper = new Mapping();

            TestDBInit db = new TestDBInit();
            db.Seed(context);

            context.SaveChanges();
            repo = new EmployeeRepository(context, mapper);
        }

        [Fact, TestPriority(1)]
        public async void Task_CreateEmployee()
        {

            var employeeeRequest = new EmployeeRequest
            {
                FirstName = "Testas",
                LastName = "Testenis",
                Address = "Kretingos 14",
                EmploymentDate = DateTime.Now.AddYears(-5),
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
            Assert.Equal(data.EmploymentDate, employeeeRequest.EmploymentDate);
            Assert.Equal(data.Salary, employeeeRequest.Salary);
        }

        [Fact, TestPriority(2)]
        public async void Task_GetEmployees()
        {

            var data = await repo.GetEmployees();

            Assert.IsType<List<EmployeeDto>>(data);
            Assert.Single(data);
        }

        [Fact, TestPriority(3)]
        public async void Task_GetEmployeeById()
        {
            var employeeId = 1;

            var data = await repo.GetEmployeeById(employeeId);

            Assert.NotNull(data);
            Assert.IsType<EmployeeDto>(data);
        }

        [Fact, TestPriority(4)]
        public async void Task_UpdateEmployee()
        {
            var employeeeRequest = new EmployeeRequest
            {
                FirstName = "Testas",
                LastName = "Testenis",
                Address = "Kretingos 15",
                EmploymentDate = DateTime.Now.AddYears(-5),
                BirthDate = DateTime.Now.AddYears(-25),
                BossId = 1,
                RoleId = 2,
                Salary = 1500,
            };

            var employeeId = 1;

            var data = await repo.UpdateEmployee(employeeId, employeeeRequest);

            Assert.NotNull(data);
            Assert.IsType<EmployeeDto>(data);
            Assert.Equal(employeeeRequest.Address, data.HomeAddress);
        }

        [Fact, TestPriority(5)]
        public async void Task_DeleteEmployee()
        {
            var employeeId = 1;

            await repo.DeleteEmployee(employeeId);
            var data = await repo.GetEmployeeById(employeeId);

            Assert.Null(data);
        }
    }
}
