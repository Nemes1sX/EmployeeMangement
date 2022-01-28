using Bogus;
using EmployeeMangement.Models;
using FizzWare.NBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EmployeeMangement.DataLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var boss = Builder<Boss>.CreateListOfSize(5)
                .All()
                    .With(f => f.FirstName = Faker.Name.First())
                    .With(f => f.LastName = Faker.Name.Last())
.               Build();


            builder.Entity<Boss>().HasData(boss);    
            builder.Entity<Role>()
                .HasData(
                 new Role { Id = 1, Name = "CEO" },
                 new Role { Id = 2, Name = "Senior Specialist" },
                 new Role { Id = 3, Name = "Intermediate Specialist" },
                 new Role { Id = 4, Name = "Junior Specialist" },
                 new Role { Id = 5, Name = "Entry-level specialist" }
                );

            var roles = new List<Role>();
            roles.Add(new Role { Id = 1, Name = "CEO" });
            roles.Add(new Role { Id = 2, Name = "Senior Specialist" });
            roles.Add(new Role { Id = 3, Name = "Intermediate Specialist" });
            roles.Add(new Role { Id = 4, Name = "Junior Specialist" });
            roles.Add(new Role { Id = 5, Name = "Entry-level specialist" });

            var randomYears = new RandomGenerator();

            var employees = Builder<Employee>.CreateListOfSize(100)
                .All()
                .With(m => m.FirstName = Faker.Name.First())
                .With(m => m.LastName = Faker.Name.Last())
                .With(m => m.Boss = Pick<Boss>.RandomItemFrom(boss))
                .With(m => m.Salary = Faker.RandomNumber.Next(1000, 3000))
                .With(m => m.HomeAddress = Faker.Address.StreetAddress())
                .With(m => m.Role = Pick<Role>.RandomItemFrom(roles))
                .With(m => m.BirthDate = DateTime.Now.AddYears(-randomYears.Next(18, 70)))
                .With(m => m.EmploymentDate = DateTime.Now.AddYears(-randomYears.Next(0, 22)))
                .Build();

            builder.Entity<Employee>().HasData(employees);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Boss> Bosses { get; set; }
    }
 

}

