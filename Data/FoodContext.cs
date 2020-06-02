using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fast_Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Fast_Food.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options)
        { 
        }
        public DbSet <Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<OrderItem> OrderItems  { get; set; }
        public DbSet<OrderItemDetail> OrderItemDetails   { get; set; }


    }
}
