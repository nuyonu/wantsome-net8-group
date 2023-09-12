using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.Entities;

namespace PizzaApp.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    { }
    
    public DbSet<User> Users { get; set; }
}