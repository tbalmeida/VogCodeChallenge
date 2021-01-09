using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models.Entities;

namespace VogCodeChallenge.API
{
    public class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Companies.Any())
                {
                return;
                }

                context.Companies.Add(new Company { Id = 1, Name = "Acme" });

                context.Departments.AddRange(
                    new Department { Id = 1, Name = "Board", CompanyId = 1, Address = "1 Centre Street, Calgary AB" },
                    new Department { Id = 2, Name = "Services", CompanyId = 1, Address = "1 Centre Street, Calgary AB" },
                    new Department { Id = 3, Name = "Sales", CompanyId = 1, Address = "204 11 Ave SW, Calgary AB" }
                );

                context.JobTitles.AddRange(
                    new JobTitle { Id = 1, Title = "Manager", Managing = true},
                    new JobTitle { Id = 2, Title = "Consultant", Managing = false}
                );

                context.Employees.AddRange(
                    new Employee { Id = 1, FirstName = "Samuel", LastName = "Champlain", DepartmentId = 1, JobTitleId = 1, ResidentialAddress = "Rue Orleans, 3, Quebec QC"},
                    new Employee { Id = 2, FirstName = "Jack", LastName = "Smith", DepartmentId = 3, JobTitleId = 2, ResidentialAddress = "54 Elbow Drive, Calgary AB"}
                );

                context.SaveChanges();
            }
        }
    }
}
