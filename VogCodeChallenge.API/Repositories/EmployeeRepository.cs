using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Models.Entities;
using VogCodeChallenge.API.Repositories.Interfaces;

namespace VogCodeChallenge.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
