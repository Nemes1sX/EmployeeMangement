using EmployeeMangement.DataContext;
using EmployeeMangement.Models;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest
{
    public class TestDBInit
    {
        public TestDBInit()
        {

        }

        public void Seed(EmployeeContext context)
        {
            context.Database.EnsureCreated();
            context.Database.EnsureDeleted();

            var randomYears = new RandomGenerator();

            var boss = Builder<Boss>.CreateListOfSize(5)
              .All()
                  .With(f => f.FirstName = Faker.Name.First())
                  .With(f => f.LastName = Faker.Name.Last())
            .Build();
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

            context.Roles.AddRange(new Role { Id = 1, Name = "CEO" },
               new Role { Id = 2, Name = "Senior Specialist" },
               new Role { Id = 3, Name = "Intermediate Specialist" },
               new Role { Id = 4, Name = "Junior Specialist" },
               new Role { Id = 5, Name = "Entry-level specialist" });

            context.Bosses.AddRange(boss);
            context.Employees.AddRange(employees);

            context.SaveChanges();
        }
    }
}
