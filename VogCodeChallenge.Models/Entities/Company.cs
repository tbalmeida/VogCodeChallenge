using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.Models.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        // Navigational

        public ICollection<Department> Departments { get; set; }
    }
}
