using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiService
{
    public class EmployeeService
    {
        private static List<Employee> Employees = new List<Employee>()
        {
            new Employee()
            {
                Id=1,
                EmployeeName="Binish",
                Gender="Male",
                Salary=10000
            },
            new Employee()
            {
                Id=2,
                EmployeeName="Alen",
                Gender="Male",
                Salary=20000
            },
            new Employee()
            {
                Id=3,
                EmployeeName="Jilty",
                Gender="Female",
                Salary=30000
            }
        };

        public List<Employee> GetEmployees()
        {
            return Employees;
        }


    }
}
