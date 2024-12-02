using cepedi.Models;
using Microsoft.EntityFrameworkCore;

namespace cepedi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Categoria> Categorias { get; set;}

    public DbSet<Produto> Proodutos { get; set; }
}