using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFreamwork.Models
{
    public class EmployeeRepository
    {
        public List<Department> GetAllDepartments()
        {
            EmployeeDBContext employee = new EmployeeDBContext();
            return employee.Departments.ToList();
        }
    }
}