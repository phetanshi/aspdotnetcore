using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Models.ViewModels
{
    public class HomeIndexEmployeeViewModel : IViewModel
    {
        public string Message { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public bool IsErrorOccured { get; set; }
    }
}
