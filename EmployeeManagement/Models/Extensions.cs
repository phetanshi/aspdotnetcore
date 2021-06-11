using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class Extensions
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return str == null || str.Trim() == string.Empty;
        }
    }
}