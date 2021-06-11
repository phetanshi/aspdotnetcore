using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace EmployeeManagement.Utility
{
    public class PropertyMapper
    {
        public static TViewModelObject Map<TObject, TViewModelObject>(TObject entity, TViewModelObject viewModel) 
        {
            PropertyInfo[] propList = typeof(TObject).GetProperties();
            PropertyInfo[] VPropList = typeof(TViewModelObject).GetProperties();



            //foreach (var prop in propList)
            //{
            //    VPropList[prop].SetValue(viewModel, prop.GetValue(entity, null), null);
            //}

            return default(TViewModelObject);
        }
    }
}
