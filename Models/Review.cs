using System;

namespace TravelAPI.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Details { get; set; }
    public int Rating { get; set; }
    public DateTime Visited { get; set; }
    public string UserName { get; set; }
  }
}