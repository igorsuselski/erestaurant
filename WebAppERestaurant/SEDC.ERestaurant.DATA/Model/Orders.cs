using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    class Orders
    {
        public int Quantity { get; set; }
        public int TotalQuantity { get; set; }
        public int Table { get; set; }
        public double TotalPrize { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Comments { get; set; }
        public DateTime Created { get; set; }
        public List<Items> ItemList { get; set; }
    }

    enum OrderStatus
    {
        created,
        inProcess,
        prepared,
        unprepared
    }
}
