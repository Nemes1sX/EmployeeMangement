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


namespace EmployeeTest
{
    [TestCaseOrderer("EmployeeTest.Orderers.PriorityOrder", "EmployeeTest")]
    public class TestEmployee
    {
        private Mapping mapper;
        private EmployeeRepository repo;
        public static DbContextOptions<EmployeeContext> dbContextOptions { get; }
        public static IConfiguration Configuration { get; }

        //public static string connectionString = Configuration["ConnectionStrings:TestEmployeeDatabase"];

        //public static string connectionString = "Server=DESKTOP-7VL5B8Q;Database=EmployerTest;User ID=sa;PWD=qwaeis12;Trusted_Connection=False; MultipleActiveResultSets=true;Integrated Security=SSPI";
        public static string connectionString = "Server=(localdb)\\v15.0;Database=TestEmployent;Trusted_Connection=True;";


        static TestEmployee()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            dbContextOptions = new DbContextOptionsBuilder<EmployeeContext>()
           .UseSqlServer(connectionString)
           .Options;
            /*dbContextOptions = new DbContextOptionsBuilder<EmployeeContext>()
            .UseSqlite(connection)
            .Options;*/
        }

        public TestEmployee()
        {
            var context = new EmployeeContext(dbContextOptions);
            TestDBInit db = new TestDBInit();
            db.Seed(context);

            repo = new EmployeeRepository(context, mapper);
        }

        [Fact, TestPriority(1)]
        public async void Task_GetEmployees()
        {

            var data = await repo.GetEmployees();

            Assert.IsType<List<EmployeeDto>>(data);
            Assert.Equal(100, data.Count);
        }

        [Fact, TestPriority(2)]
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

        [Fact, TestPriority(3)]
        public async void Task_GetEmployeeById()
        {
            var employeeId = 101;

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

            var employeeId = 101;

            var data = await repo.UpdateEmployee(employeeId, employeeeRequest);

            Assert.NotNull(data);
            Assert.IsType<EmployeeDto>(data);
            Assert.Equal(employeeeRequest.Address, data.HomeAddress);
        }

        [Fact, TestPriority(5)]
        public async void Task_DeleteEmployee()
        {
            var employeeId = 101;

            await repo.DeleteEmployee(employeeId);
            var data = await repo.GetEmployeeById(employeeId);

            Assert.Null(data);
        }
    }
}
