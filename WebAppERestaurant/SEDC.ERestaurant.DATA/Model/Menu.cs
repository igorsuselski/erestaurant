using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    class Menu
    {       
        public int Id { get; set; }
        public Type Type { get; set; }
        public string RestaurantName { get; set; }
        public List<Category> CategoryList { get; set; }
    }

    enum Type
    {
        Meals,
        Drinks,
        Wiens
    }
}
