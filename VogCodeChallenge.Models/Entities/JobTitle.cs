using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.Models.Entities
{
    public class JobTitle
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(5), MaxLength(20)]
        public string Title { get; set; }

        public bool Managing { get; set; } = false;


        // Navigational
        public ICollection<Employee> Employees { get; set; }
    }
}
