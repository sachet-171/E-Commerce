using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
    
    }

    public DbSet<Category> Categories { get; set; }  /* Category is model and Categories is a table name*/
    public DbSet<CoverType> CoverTypes { get; set; }
    public DbSet<Product> Products { get; set; }    //creating DbSet for product
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
  public DbSet<Company> Companies { get; set; }
}
