using EmployeeMangement.Models.Entities;
using FizzWare.NBuilder;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeMangement.DataContext
{
    public static class EmployeeSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            var boss = Builder<Boss>.CreateListOfSize(5)
               .All()
                   .With(f => f.FirstName = Faker.Name.First())
                   .With(f => f.LastName = Faker.Name.Last())
                .Build();

            var locations = Builder<Location>.CreateListOfSize(20)
                .All()
                .With(f => f.Name = Faker.Lorem.GetFirstWord())
                .With(f => f.Address = Faker.Address.StreetName() + ", " + Faker.Address.City() + ", " + Faker.Address.Country())
                .With(f => f.MaxAllocation = Faker.RandomNumber.Next(5, 50))
                .Build();

            builder.Entity<Location>().HasData(locations);

            builder.Entity<Boss>().HasData(boss);
            builder.Entity<Role>()
                .HasData(
                 new Role { Id = 1, Name = "CEO" },
                 new Role { Id = 2, Name = "Senior Specialist" },
                 new Role { Id = 3, Name = "Intermediate Specialist" },
                 new Role { Id = 4, Name = "Junior Specialist" },
                 new Role { Id = 5, Name = "Entry-level specialist" }
                );

            var randomYears = new RandomGenerator();

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

            builder.Entity<Employee>().HasData(employees);
        }
    }
}
