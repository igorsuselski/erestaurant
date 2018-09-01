using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SEDC.ERestaurant.Data.Model
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte TypeId { get; set; }

        [Required]
        [MaxLength(200)]
        public string RestaurantName { get; set; }

        public List<Category> CategoryList { get; set; }
    }


}
