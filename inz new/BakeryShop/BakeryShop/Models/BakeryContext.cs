using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BakeryShop.Models
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class BakeryContext : IdentityDbContext<ApplicationUser>
    {
        public BakeryContext() : base("BakeryShopContext")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<User> Users { get; set; }
    }
}