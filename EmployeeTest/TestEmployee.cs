using EmployeeMangement.DataContext;
using EmployeeMangement.DataLayer;
using EmployeeMangement.Infrastructure;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using EmployeeTest.Attributes;
using EmployeeMangement.Models.Entities;
using FizzWare.NBuilder;
using NUnit.Framework;
using System.Threading.Tasks;

namespace EmployeeTest
{
    public class TestEmployee 
    {
        private EmployeeRepository repo;
        //public static DbContextOptions<EmployeeContext> dbContextOptions { get; }
        public static IConfiguration Configuration { get; }
        private DbContextOptions<EmployeeContext> dbContext = new DbContextOptionsBuilder<EmployeeContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

        [OneTimeSetUp]
        public void Setup()
        {
            var mapper = new Mapping();

            Seed();

            repo = new EmployeeRepository(new EmployeeContext(dbContext), mapper);
        }

        [Test, Order(1)]
        public async Task Task_CreateEmployee()
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

            using var context = new EmployeeContext(dbContext);

            var data = await repo.AddEmployee(employeeeRequest);

            Assert.AreEqual(data.Name, employeeeRequest.FirstName + " " + employeeeRequest.LastName);
            Assert.AreEqual(data.HomeAddress, employeeeRequest.Address);
            Assert.AreEqual(data.BirthDate, employeeeRequest.BirthDate);
            Assert.AreEqual(data.EmploymentDate, employeeeRequest.EmploymentDate);
            Assert.AreEqual(data.Salary, employeeeRequest.Salary);
        }

        [Test, Order(2)]
        public async Task Task_GetEmployees()
        {
            /*var employeeeRequest = new EmployeeRequest
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

            var data = await repo.AddEmployee(employeeeRequest);*/
            using var context = new EmployeeContext(dbContext);

            var result = await repo.GetEmployees();

            Assert.AreEqual(100, result.Count);
        }

        [Test, Order(3)]
        public async Task Task_GetEmployeeById()
        {
            using var context = new EmployeeContext(dbContext);

            var employeeId = 1;

            var data = await repo.GetEmployeeById(employeeId);

            Assert.NotNull(data);
        }

        [Test, Order(4)]
        public async Task Task_UpdateEmployee()
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
            using var context = new EmployeeContext(dbContext);

            var data = await repo.UpdateEmployee(employeeId, employeeeRequest);

            Assert.NotNull(data);
            Assert.AreEqual(employeeeRequest.Address, data.HomeAddress);
        }

        [Test, Order(5)]
        public async Task Task_DeleteEmployee()
        {
            using var context = new EmployeeContext(dbContext);

            await repo.DeleteEmployee(1);
            var result = await repo.GetEmployeeById(1);

            Assert.Null(result);
        }

        private void Seed()
        {
            using var context = new EmployeeContext(dbContext);
            context.Database.EnsureCreated();
            context.Database.EnsureDeleted();

            var randomYears = new RandomGenerator();

            var boss = Builder<Boss>.CreateListOfSize(5)
              .All()
                  .With(f => f.FirstName = Faker.Name.First())
                  .With(f => f.LastName = Faker.Name.Last())
            .Build();


            context.Roles.AddRange(new Role { Id = 1, Name = "CEO" },
               new Role { Id = 2, Name = "Senior Specialist" },
               new Role { Id = 3, Name = "Intermediate Specialist" },
               new Role { Id = 4, Name = "Junior Specialist" },
               new Role { Id = 5, Name = "Entry-level specialist" });

            context.Bosses.AddRange(boss);
            var employees = Builder<Employee>.CreateListOfSize(100)
     .All()
     .With(m => m.FirstName = Faker.Name.First())
     .With(m => m.LastName = Faker.Name.Last())
     .With(m => m.BossId = Faker.RandomNumber.Next(1, 5))
     .With(m => m.Salary = Faker.RandomNumber.Next(1000, 3000))
     .With(m => m.HomeAddress = Faker.Address.StreetAddress())
     .With(m => m.RoleId = Faker.RandomNumber.Next(1, 5))
     .With(m => m.BirthDate = DateTime.Now.AddYears(-randomYears.Next(18, 70)))
     .With(m => m.EmploymentDate = DateTime.Now.AddYears(-randomYears.Next(0, 22)))
     .Build();
            context.Employees.AddRange(employees);

            context.SaveChanges();
        }
    }
}
