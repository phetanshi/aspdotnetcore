using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Models.ViewModels;

namespace EmployeeManagement.Service
{
    public interface IHomeService
    {
        HomeIndexEmployeeViewModel Get();
        HomeDetailsEmployeeViewModel Get(int id);
        void Add(HomeCreateEmployeeViewModel employee);
        void Update(HomeEditEmployeeViewModel employee);
        HomeDetailsEmployeeViewModel Delete(int id);
    }
}
