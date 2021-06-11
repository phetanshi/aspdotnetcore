using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.ViewModels
{
    public class HomeEditEmployeeViewModel : HomeCreateEmployeeViewModel
    {
        public string ExistingPhotoPath { get; set; }
    }
}
