using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMangement.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual IList<Employee> Employees { get; set; } 
    }
}
