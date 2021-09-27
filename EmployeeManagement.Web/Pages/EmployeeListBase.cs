using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase:ComponentBase
    {
        public IEnumerable<Employee>  Employees{ get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
            
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(2000);
            Employee e1 = new Employee
            {
                employeeID = 1,
                firstname = "Abid",
                lastName = "Hassan",
                email = "a@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender=Gender.Male,
                departmentID=10,
                photoPath="images/abid.png"
            };
            Employee e2 = new Employee
            {
                employeeID = 2,
                firstname = "Rasel",
                lastName = "Uddin",
                email = "r@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Male,
                departmentID = 20,
                photoPath = "images/rasel.jpg"
            };
            Employee e3 = new Employee
            {
                employeeID = 3,
                firstname = "Jahid",
                lastName = "Hassan",
                email = "j@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Male,
                departmentID = 10,
                photoPath = "images/jahid.png"
            };
            Employee e4 = new Employee
            {
                employeeID = 4,
                firstname = "Mimu",
                lastName = "Parvathy",
                email = "m@gmail.com",
                dateOfBirth = new DateTime(1996, 11, 20),
                gender = Gender.Female,
                departmentID = 30,
                photoPath = "images/mimu.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
