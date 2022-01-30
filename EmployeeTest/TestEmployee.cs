using EmployeeMangement.DataContext;
using EmployeeMangement.DataLayer;
using EmployeeMangement.Infrastructure;
using EmployeeMangement.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
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

        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestEmlpoymentManagement;Integrated Security=False;Connect Timeout=30;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //public static string connectionString = @"Data Source=(localdb)\\\\mssqllocaldb;Database=TestEmlpoymentManagement;Trusted_Connection=True;";

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
        public async void Task_GetEmployeeById()
        {
            var employeeId = 10;

            var data = await repo.GetEmployeeById(employeeId);

            Assert.IsType<EmployeeDto>(data);
        }
    }
}
