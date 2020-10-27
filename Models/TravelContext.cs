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
          new Review {  ReviewId = 1, Country = "USA", City = "Seattle", Details = "A City in the Pacific Northwest surrounded by hills and trees.", Rating = 4, Visited = today, UserName = "mmanchee" },
          new Review {  ReviewId = 2, Country = "Sweden", City = "Stockholm", Details = "A City in northern Europe. Sweden's Capitol.", Rating = 5, Visited = today, UserName = "gbrown" },
          new Review {  ReviewId = 3, Country = "Canada", City = "Toronto", Details = "Canada's most populated city, located just beyond the border near Detroit.", Rating = 4, Visited = today, UserName = "gbrown" },
          new Review {  ReviewId = 4, Country = "China", City = "Shanghai", Details = "A city in China that neighbors Hong-Kong just on the other side of the river.", Rating = 4, Visited = today, UserName = "gbrown" },
          new Review {  ReviewId = 5, Country = "USA", City = "Honolulu", Details = "Located in the middle of the Pacific near the equator. This coast city sits right on white sand beaches with Diamond Head Mt. at the far south", Rating = 5, Visited = today, UserName = "mmanchee" },
          new Review {  ReviewId = 6, Country = "USA", City = "Seattle", Details = "A City in the Pacific Northwest surrounded by hills and trees.", Rating = 1, Visited = today, UserName = "mmanchee" },
          new Review {  ReviewId = 7, Country = "Sweden", City = "Stockholm", Details = "A City in northern Europe. Sweden's Capitol.", Rating = 2, Visited = today, UserName = "gbrown" },
          new Review {  ReviewId = 8, Country = "Canada", City = "Toronto", Details = "Canada's most populated city, located just beyond the border near Detroit.", Rating = 1, Visited = today, UserName = "gbrown" },
          new Review {  ReviewId = 9, Country = "China", City = "Shanghai", Details = "A city in China that neighbors Hong-Kong just on the other side of the river.", Rating = 2, Visited = today, UserName = "gbrown" },
          new Review {  ReviewId = 10, Country = "USA", City = "Honolulu", Details = "Located in the middle of the Pacific near the equator. This coast city sits right on white sand beaches with Diamond Head Mt. at the far south", Rating = 2, Visited = today, UserName = "mmanchee" }
          );
    }
  }
}