using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.ViewModels
{
    public abstract class ViewModelBase : IViewModel
    {
        private IConfiguration _config;
        public ViewModelBase(IConfiguration configuration)
        {
            _config = configuration;
        }
        public string Message { get; set; }

        public string GetEnvironment()
        {
            var con = _config.GetConnectionString("EmployeeDBConnection");
            SqlConnectionStringBuilder sqlConn = new SqlConnectionStringBuilder(con);
            return EnvironmentDictionary.Environment[sqlConn.DataSource];
        }
    }
}
