using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceofPlace_Place()
    {
      Place newPlace = new Place("teststring", "teststring", "teststring", "teststring", "teststring");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Bellingham";
      Place newPlace = new Place(cityName, "teststring", "teststring", "teststring", "teststring");
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }
  }
}