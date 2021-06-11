using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.DataStore
{
    public class EmployeeDB : IEmployeeDB
    {
        public void ExecuteProcedure(string procedureName, params DataStoreParameterWrapper[] parameters)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDataSet(string procedureName, params DataStoreParameterWrapper[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
