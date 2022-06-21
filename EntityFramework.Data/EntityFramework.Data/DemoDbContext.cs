using EntityFramework.Data.DemoEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmpEducation { get; set; }
        public DbSet<ClassRoom> Class { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DemoDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-2D3FN7GQ;Database=Employeedetails;Trusted_Connection=True;");

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Teacher>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();

            });
        }
    }
}
