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
    public int Id { get; }

    public Place(string cityName, string durationOfStay, string travelPartners, string favoriteRestaurants, string activities)
    {
      CityName = cityName;
      DurationOfStay = durationOfStay;
      TravelPartners = travelPartners;
      FavoriteRestaurants = favoriteRestaurants;
      Activities = activities; 
      Id = _trips.Count;
      //add Places to list called trips
      _trips.Add(this);
    }

    public static List<Place> GetAllPlaces()
    {
      return _trips;
    }

    public static Place Find(int searchId)
    {
      return _trips[searchId];
    }

    public static void ClearPlace(int searchId)
    {
      _trips.RemoveAt(searchId);
      // return _trips[searchId -1].CityName;
    }
  }
}