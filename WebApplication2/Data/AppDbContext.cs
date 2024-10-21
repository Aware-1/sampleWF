using WebApplication2.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) { }
    
    
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}