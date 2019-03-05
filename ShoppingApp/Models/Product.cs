using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }


        public string ImageUrl { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "field must be at least 10 chars and less than 100")]
        public string Description { get; set; }

        [Required]
        public int InitialQuantity { get; set; }

        public List<Order> orders { get; set; }

        public Product()
        {
            orders = new List<Order>();
        }

    }
}
