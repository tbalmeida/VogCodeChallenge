using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Models.Entities;

namespace VogCodeChallenge.App
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<JobTitle> JobTitles { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}
