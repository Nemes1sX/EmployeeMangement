using EmployeeMangement.DataContext;
using EmployeeMangement.Models.Entities;
using FizzWare.NBuilder;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace EmployeeTest
{
    [SetUpFixture]
    public class IntegrationSetUp
    {
        [OneTimeSetUp]
        public async Task SetUp()
        {
            var dbContextFactory = new EmployeeContextFactory();
            using (var dbContext = dbContextFactory.CreateDbContext(new string[] { }))
            {
                await dbContext.Database.EnsureDeletedAsync();
                await dbContext.Database.EnsureCreatedAsync();
            }
        }
    }
}
