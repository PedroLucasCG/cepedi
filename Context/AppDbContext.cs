using cepedi.Models;
using Microsoft.EntityFrameworkCore;

namespace cepedi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Orders> Orders { get; set;}
    public DbSet<Status> Status { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<OrdersProducts> OrdersProducts { get; set; }
    public DbSet<UsersOrders> UsersOrders { get; set; }

}