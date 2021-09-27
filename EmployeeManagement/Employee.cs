using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string firstname { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Gender gender { get; set; }
        public int departmentID { get; set; }
        public string photoPath { get; set; }

    }
}
