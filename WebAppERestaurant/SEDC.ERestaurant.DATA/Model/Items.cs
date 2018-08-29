using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    class Items
    {
        public string Description { get; set; }
        public string Contents { get; set; }
        public string Name  { get; set; }
        public double Prize { get; set; }
        public bool availability { get; set; }
        public List<Orders> OrderList { get; set; }
    }
}
