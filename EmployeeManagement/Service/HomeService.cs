using EmployeeManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Repository;
using EmployeeManagement.Models;
using EmployeeManagement.Utility;

namespace EmployeeManagement.Service
{
    public class HomeService : IHomeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Add(HomeCreateEmployeeViewModel employee)
        {
            Employee addedEmp = _employeeRepository.AddEmployee(employee);
            PropertyCopy.Copy(addedEmp, employee);
        }
        public HomeIndexEmployeeViewModel Get()
        {
            HomeIndexEmployeeViewModel model = new HomeIndexEmployeeViewModel();
            model.Employees = _employeeRepository.GetEmployees();
            return model;
        }
        public HomeDetailsEmployeeViewModel Get(int id)
        {
            HomeDetailsEmployeeViewModel model = new HomeDetailsEmployeeViewModel();
            Employee employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
                return null;
            PropertyCopy.Copy(employee, model);
            return model;
        }
        public HomeDetailsEmployeeViewModel Delete(int id)
        {
            HomeDetailsEmployeeViewModel model = new HomeDetailsEmployeeViewModel();
            Employee deletedEmp = _employeeRepository.DeleteEmployee(id);
            PropertyCopy.Copy(deletedEmp, model);
            return model;
        }
        public void Update(HomeEditEmployeeViewModel employee)
        {
            Employee updatedEmp = _employeeRepository.UpdateEmployee(employee);
            PropertyCopy.Copy(updatedEmp, employee);
        }
    }
}
