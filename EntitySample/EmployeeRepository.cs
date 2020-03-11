using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntitySample
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDbContext employeeDBContext = new EmployeeDbContext();
            return employeeDBContext.Departments.Include("Employees").ToList();
        }
    }
}