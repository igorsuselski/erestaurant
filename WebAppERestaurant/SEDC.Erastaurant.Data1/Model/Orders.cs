using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(3)]
        public int Table { get; set; }

        [Required]
        public byte StatusId { get; set; }

        public string Comments { get; set; }

        [Required]
        public DateTime WhenCreated { get; set; }

        public List<OrderItem> ListOrderItems { get; set; }


        public int? TotalQuantity => ListOrderItems?.Sum(loi => loi.Quantity);


        public double? TotalCoast => ListOrderItems?.Sum(loi => loi.Quantity * loi.Item.Prize);

    }
    
}
