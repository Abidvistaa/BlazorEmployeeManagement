using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class DepartmentRepository : IDepartment
    {
        private readonly ApplicationDBContext dbContext;
        public DepartmentRepository(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Department> GetDepartment(int dept)
        {
            return await dbContext.Departments.FirstOrDefaultAsync(d => d.departmentID == dept);
            
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await dbContext.Departments.ToListAsync();
        }
    }
}
