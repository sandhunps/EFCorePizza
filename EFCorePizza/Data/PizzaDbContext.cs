using EFCorePizza.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCorePizza.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders  { get; set; }

        public DbSet<OrderDetails> OrderDetails{ get; set; }

        public DbSet<Product> Products{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=pizzaDb;Username=postgres;Password=password;Include Error Detail=true");
        }
    }

}
