using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace TravelAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelAPIContext _db;

    public ReviewsController(TravelAPIContext db)
    {
      _db = db;
    }

    // GET api/Reviews
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string country, string city)
    {
      var query = _db.Reviews.AsQueryable();
      if (country != null)
      {
        country = country.ToUpper();
        query = query.Where(entry => entry.Country == country);
      }
      if (city != null)
      {
        city = city.ToUpper();
        query = query.Where(entry => entry.City == city);
      }
      //query = query.Skip(startIndex).Take(pageSize); // Pagination using passed variables int startIndex, int pageSize
      return query.ToList();
    }

    // POST api/Reviews
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      review.City = review.City.ToUpper();
      review.Country = review.Country.ToUpper();
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }

    // GET api/Reviews/5
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
      return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
    }

    // PUT api/Reviews/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Review review)
    {
      // if (UserName == "0"/*UserId*/) // Needs to be intigrated with ApplicationUser for Identity
      // {
      review.ReviewId = id;
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
      //}
    }

    // DELETE api/Reviews/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      // if (UserName == "0"/*UserId*/) // Needs to be intigrated with ApplicationUser for Identity
      // {
      var ReviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(ReviewToDelete);
      _db.SaveChanges();
      //}
    }
    // Top Rated
    [HttpGet("TopRated")]
    public IEnumerable<object> TopRated()
    {
      var query = from review in _db.Reviews
                  group review by review.City into cities
                  select new
                  {
                    City = cities.Key,
                    Average = (decimal)cities.Average(x => x.Rating)
                  };
      query = query.OrderByDescending(x => x.Average).Take(5);
      return query.ToList();
    }
    [HttpGet("Random")]
    public IEnumerable<Review> Random()
    {
      var count = _db.Reviews.Count();
      Random ran = new Random();
      int skipTo = ran.Next(count);
      return _db.Reviews.OrderBy(r => Guid.NewGuid()).Skip(skipTo).Take(1);
    }
  }
}