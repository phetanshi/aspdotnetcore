using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.ViewModels
{
    public class UserClaimsViewModel : IViewModel
    {
        public UserClaimsViewModel()
        {
            Cliams = new List<UserClaim>();
        }

        public string UserId { get; set; }
        public List<UserClaim> Cliams { get; set; }
        public string Message { get; set; }
    }
}
