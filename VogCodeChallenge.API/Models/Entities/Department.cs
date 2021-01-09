using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.API.Models.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Name { get; set; }

        [Required, MinLength(10), MaxLength(300)]
        public string Address { get; set; }

        public int CompanyId { get; set; }


        // Navigational
        public Company Company { get; set; }

        // lists all employees
        public ICollection<Employee> Employees { get; set; }
    }
}
