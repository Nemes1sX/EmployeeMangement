using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMangement.Models
{
    public class Boss
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual IList<Employee> Employees { get; set; }
    }
}
