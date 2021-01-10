using System.Collections.Generic;
using VogCodeChallenge.Models.Entities;
using VogCodeChallenge.Models.ViewModels;

namespace VogCodeChallenge.App.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();

        List<EmployeeVM> EmployeesByDepartment(int departmentId);
    }
}
