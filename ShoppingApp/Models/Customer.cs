using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Must have first name")]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must have last name")]
        [MinLength(2)]
        public string LastName { get; set; }

        [MinLength(2)]
        [EmailAddress]
        [Required(ErrorMessage = "Must have email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must have password")]
        [MinLength(8)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public string DisplayDate { get; set; }

        public List<Order> orders { get; set; }

        public Customer()
        {
            orders = new List<Order>();
            CreatedAt = DateTime.Now;
            DisplayDate = CreatedAt.ToString("MMMM dd, yyyy");
        }
    }
}
