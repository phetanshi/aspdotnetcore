using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.ViewModels
{
    public class HomeDetailsEmployeeViewModel : Employee, IViewModel
    {
        public string Message { get; set; }
    }
}
