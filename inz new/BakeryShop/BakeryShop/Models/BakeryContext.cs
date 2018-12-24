using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BakeryShop.Models
{
    public class BakeryContext : DbContext  
    {
        public BakeryContext() : base("BakeryShopContext")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
    }
}