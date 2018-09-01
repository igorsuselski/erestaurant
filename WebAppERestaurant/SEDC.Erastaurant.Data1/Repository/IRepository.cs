using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Erastaurant.Data1.Repository
{
    interface IRepository<T>
    {

        IList<T> GetAll();

        T Get(int id);

        T Create(T Team);

        void Update(T item);

        void Delete(T item);

    }
}
