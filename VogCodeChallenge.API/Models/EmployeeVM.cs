using VogCodeChallenge.API.Models.Entities;

namespace VogCodeChallenge.API.Models
{
    public class EmployeeVM
    {

        public EmployeeVM(Employee src)
        {
            Id = src.Id;
            FirstName = src.FirstName;
            LastName = src.LastName;
            Department = src.Department.Name;
            JobTitle = src.JobTitle.Title;
            IsManager = src.JobTitle.Managing;
            ResidentialAddress = src.ResidentialAddress;
            DepartmentId = src.DepartmentId;
            JobTitleId = src.JobTitleId;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string JobTitle { get; set; }

        public bool IsManager { get; set; }

        public string ResidentialAddress { get; set; }

        public int DepartmentId { get; set; }

        public int JobTitleId { get; set; }
    }
}
