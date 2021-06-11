using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee { Id = 1, Name = "Padmasekhar", Email = "padmasekhar@gmail", Department = Dept.IT },
                new Employee { Id = 2, Name = "Narmada", Email = "narmada@gmail", Department = Dept.HR },
                new Employee { Id = 3, Name = "Hetanshi", Email = "hetanshi@gmail", Department = Dept.SALSE }
            };

        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeList;
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeeList.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee emp = _employeeList.FirstOrDefault(x => x.Id == id);
            if (emp != null)
                _employeeList.Remove(emp);
            return emp;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            Employee emp = _employeeList.FirstOrDefault(x => x.Id == employee.Id);
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Department = employee.Department;
            }
            return employee;
        }
    }
}
