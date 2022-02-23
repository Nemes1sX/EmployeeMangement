using EmployeeMangement.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangement.DataContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            EmployeeSeeding.Seed(builder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Boss> Bosses { get; set; }
    }
 

}

