using System.ComponentModel.DataAnnotations;

namespace EmployeeMangement.Models.FormRequest
{
    public class LocationRequest
    {
        [Required, MinLength(4)]
        public string Name { get; set; }
        [Required, MinLength(4)]
        public string Address { get; set; }
        public int MaxAllocation { get; set; }
    }
}
