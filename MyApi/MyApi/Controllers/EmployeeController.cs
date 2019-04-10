using ApiService;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApi.Controllers
{
    public class EmployeeController : ApiController
    {
        private List<Employee> Employees => new EmployeeService().GetEmployees();

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return Employees;
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return Employees.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Employee
        public void Post([FromBody]Employee value)
        {
            Employees.Add(value);
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]Employee value)
        {
            var employee = Employees.FirstOrDefault(x => x.Id == id);
            employee.EmployeeName = value.EmployeeName;
            employee.Gender = value.Gender;
            employee.Salary = value.Salary;
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
            var employee = Employees.FirstOrDefault(x => x.Id == id);
            Employees.Remove(employee);
        }

        public void Delete(List<Employee> emp)
        {
            Employees.RemoveAll(x => emp.Contains(x));
        }
    }
}
