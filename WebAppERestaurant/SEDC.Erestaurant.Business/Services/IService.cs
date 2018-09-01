using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Erestaurant.Business.Services
{
    interface IService <T>
    {
        ServiceResult<T> LoadAll();
        ServiceResult<T> Load();
        ServiceResult<T> Add();
        ServiceResult<T> Edit();
        ServiceResult<T> Remove();
    }
}
