using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inzynierka_Shop.Models
{
    public class Inzynierka_ShopContext : DbContext
    {
        public Inzynierka_ShopContext (DbContextOptions<Inzynierka_ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Inzynierka_Shop.Models.Produkt> Produkt { get; set; }
    }
}
