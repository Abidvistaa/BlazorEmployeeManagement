using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Sedd Department Table
            //modelBuilder.Entity<Department>().HasData(new Department{departmentID=10,departmentName="IT"});
            //modelBuilder.Entity<Department>().HasData(new Department { departmentID = 20, departmentName = "Business" });
            //modelBuilder.Entity<Department>().HasData(new Department { departmentID = 10, departmentName = "Marketing" });

            //Sedd Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                employeeID = 1,
                firstname = "Abid",
                lastName = "Hassan",
                email = "a@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Male,
                departmentID = 10,
                photoPath = "images/abid.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                employeeID = 2,
                firstname = "Rasel",
                lastName = "Uddin",
                email = "r@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Male,
                departmentID = 20,
                photoPath = "images/rasel.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                employeeID = 3,
                firstname = "Jahid",
                lastName = "Hassan",
                email = "j@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Male,
                departmentID = 10,
                photoPath = "images/jahid.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                employeeID = 4,
                firstname = "Mimu",
                lastName = "Parvathy",
                email = "m@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Female,
                departmentID = 30,
                photoPath = "images/mimu.png"

            });
        }
    }
}
