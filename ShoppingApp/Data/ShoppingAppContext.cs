using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;

namespace ShoppingApp.Models
{
    public class ShoppingAppContext : DbContext
    {
        public ShoppingAppContext (DbContextOptions<ShoppingAppContext> options)
            : base(options)
        {
        }

        public DbSet<ShoppingApp.Models.Product> Product { get; set; }

        public DbSet<ShoppingApp.Models.Customer> Customer { get; set; }

        public DbSet<ShoppingApp.Models.Order> Order { get; set; }
    }
}
