using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    //HttpGet says, we're gonna use this to get something
    // ("/places") means, when we submit the form with action="/places", that will trigger this route to get the Index()/Index.cshtml from Views/Places
    public ActionResult Index()
    {
      List<Place> allTrips = Place.GetAllPlaces();
      //We create List<Place> allTrips to store the result of calling Place.GetAllPlaces(), which is accessing the _trips inside of the Place object
      return View(allTrips);
    }
    [HttpPost("/places")]
    public ActionResult Create(string cityName, string durationOfStay, string travelPartners, string favoriteRestaurants, string activities)
    {
      Place newPlace = new Place(cityName, durationOfStay, travelPartners, favoriteRestaurants, activities);
      //info from form comes in, passed into our Place instance, once newPlace is created using info from form, then we Redirect to "Index"
      return RedirectToAction("Index");
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}