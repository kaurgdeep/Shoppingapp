using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public Customer customer { get; set; }

        public int AmountOrdered { get; set; }


        public int ProductId { get; set; }

        public Product product { get; set; }


        public DateTime OrderedAt { get; set; }

        public string DisplayDate { get; set; }

        public Order()
        {
            OrderedAt = DateTime.Now;
            DisplayDate = OrderedAt.ToString("MMMM dd, yyyy");
        }
    }
}
