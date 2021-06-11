using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.ViewModels
{
    public class HomeCreateEmployeeViewModel : HomeDetailsEmployeeViewModel
    {
        public IFormFile Photo { get; set; }
    }
}
