using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class EnvironmentDictionary
    {
        public static IDictionary<string, string> Environment
        {
            get
            {
                IDictionary<string, string> env = new Dictionary<string, string>();
                env.Add(".", "Stage");
                env.Add("(localdb)\\MSSQLLocalDB", "DEV");
                return env;
            }
        }
    }
}
