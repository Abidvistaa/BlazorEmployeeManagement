using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class EmployeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext dbContext;
        public EmployeRepository(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        

        public async void DeleteEmployee(int employeeId)
        {
            var result = await dbContext.Employees.FirstOrDefaultAsync(e => e.employeeID == employeeId);
            if (result != null)
            {
                dbContext.Employees.Remove(result);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(e => e.employeeID == employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await dbContext.Employees.FirstOrDefaultAsync(e => e.employeeID == employee.employeeID);

            if (result != null)
            {
                result.firstname = employee.firstname;
                result.lastName = employee.lastName;
                result.email = employee.email;
                result.dateOfBirth = employee.dateOfBirth;
                result.departmentID = employee.departmentID;
                result.photoPath = employee.photoPath;

                await dbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        
    }
}
