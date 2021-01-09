using System.Collections.Generic;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Models.Entities;

namespace VogCodeChallenge.API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();

        List<EmployeeVM> EmployeesByDepartment(int departmentId);
    }
}
