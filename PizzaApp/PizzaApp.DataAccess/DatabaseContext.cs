using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.Entities;

namespace PizzaApp.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Order> Orders { get; set; }
    
    public DbSet<OrderProduct> OrderProduct { get; set; }
    
    public DbSet<User> Users { get; set; }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderProduct>()
            .HasOne<Order>(x => x.Order)
            .WithMany(s => s.Products)
            .HasForeignKey(x => x.OrderId);
        
        modelBuilder.Entity<OrderProduct>()
            .HasOne<Product>(x => x.Product)
            .WithMany(s => s.Orders)
            .HasForeignKey(x => x.ProductId);
        
        base.OnModelCreating(modelBuilder);
    }
}