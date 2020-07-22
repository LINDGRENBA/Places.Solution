using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private static List<Place> _trips = new List<Place> {};
    public string CityName { get; set; }
    public string DurationOfStay { get; set; }
    public string TravelPartners { get; set;}
    public string FavoriteRestaurants { get; set; }
    public string Activities { get; set; }

    public Place(string cityName, string durationOfStay, string travelPartners, string favoriteRestaurants, string activities)
    {
      CityName = cityName;
      DurationOfStay = durationOfStay;
      TravelPartners = travelPartners;
      FavoriteRestaurants = favoriteRestaurants;
      Activities = activities; 
      //add Places to list called trips
      _trips.Add(this);
    }

    public static List<Place> GetAllPlaces()
    {
      return _trips;
    }
  }
}