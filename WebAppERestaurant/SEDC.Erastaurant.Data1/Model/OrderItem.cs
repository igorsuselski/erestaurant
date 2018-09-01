using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public Orders Order { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        [Required]
        public short Quantity{ get; set; }
    }
}
