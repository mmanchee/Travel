using Microsoft.EntityFrameworkCore;
using System;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options)
        : base(options)
    {
    }
    public DbSet<Review> Reviews { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      DateTime today = DateTime.Now;
      builder.Entity<Review>()
          .HasData(
          new Review { Country = "USA", City = "Seattle", Details = "A City in the Pacific Northwest surrounded by hills and trees.", Rating = 4, Visited = today, UserName = "mmanchee" }
          );
    }
  }
}