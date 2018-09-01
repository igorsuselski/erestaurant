using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.ERestaurant.Data.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(2500)]
        public string Contents { get; set; }

        [Required]
        public double Prize { get; set; }

        [Required]
        public bool availability { get; set; }

        [Required]
        public int CategortId { get; set; }

        public Category Category { get; set; }
    }
}
