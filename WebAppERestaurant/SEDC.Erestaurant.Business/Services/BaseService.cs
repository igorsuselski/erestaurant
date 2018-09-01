using SEDC.Erastaurant.Data1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Erestaurant.Business.Services
{
    public class BaseService<T> : IDisposable
        where T : BaseRepository
    {
        private T _repository;

        public T Repository => _repository;

        public BaseService()
        {
            _repository = Activator.CreateInstance<T>();
        }

        public void Despose()
        {
            _repository.Dispose();
        }
    }
}
