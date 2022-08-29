using EmployeeMangement.DataContext;
using NUnit.Framework;

namespace EmployeeTest
{
    public abstract class IntegrationTestBase
    {
        protected EmployeeContext dbContext = null;

        [SetUp]
        public void SetUp()
        {
            var dbContextFactory = new EmployeeContextFactory();
            dbContext = dbContextFactory.CreateDbContext(new string[] { });
        }

        [TearDown]
        public void TearDown()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
