using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.ViewModels
{
    public class ForgotPasswordViewModel : IViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
