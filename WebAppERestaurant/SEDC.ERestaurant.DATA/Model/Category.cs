using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Items> ListItems { get; set; }
    }
}
