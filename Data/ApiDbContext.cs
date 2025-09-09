using Microsoft.EntityFrameworkCore;
using ApiWeb.Models;

namespace ApiWeb.Data;

public class ApiDbContext : DbContext
{
  public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
  {
  }

  public DbSet<Product> Products { get; set; }
}