using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.Models.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(30)]
        public string FirstName { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string LastName { get; set; }

        [Required, MinLength(10), MaxLength(300)]
        public string ResidentialAddress { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public int JobTitleId { get; set; }


        // Navigational
        public Department Department { get; set; }

        public JobTitle JobTitle { get; set; }
    }
}
