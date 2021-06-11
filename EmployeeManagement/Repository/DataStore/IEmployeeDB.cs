using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.DataStore
{
    public interface IEmployeeDB
    {
        DataSet GetDataSet(string procedureName, params DataStoreParameterWrapper[] parameters);
        void ExecuteProcedure(string procedureName, params DataStoreParameterWrapper[] parameters);
    }
}
