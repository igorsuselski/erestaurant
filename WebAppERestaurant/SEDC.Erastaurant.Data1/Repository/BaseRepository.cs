using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Erastaurant.Data1.Repository
{
    public class BaseRepository : IDisposable
    {
        private ErestaurantContext _dbContext;

        public ErestaurantContext dbContext => _dbContext;


        public BaseRepository()
        {
            _dbContext = new ErestaurantContext();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

    }
}
