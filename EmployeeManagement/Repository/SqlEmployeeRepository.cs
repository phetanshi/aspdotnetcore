using EmployeeManagement.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDBContext context;
        private readonly ILogger<SqlEmployeeRepository> logger;

        public SqlEmployeeRepository(AppDBContext context, ILogger<SqlEmployeeRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = context.Employees.Find(id);
            if(employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            logger.LogInformation("Entered into GetEmployee methods");
            Employee employee = context.Employees.Find(id);
            logger.LogInformation("Returning from GetEmployee methods");
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = context.Employees.Attach(employee);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employee;
        }
    }
}
