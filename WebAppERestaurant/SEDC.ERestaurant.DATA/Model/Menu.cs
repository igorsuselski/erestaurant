﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnotations;

namespace SEDC.ERestaurant.Data.Model
{
    class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public byte TypeId { get; set; }

        public string RestaurantName { get; set; }

        public List<Category> CategoryList { get; set; }
    }

}
