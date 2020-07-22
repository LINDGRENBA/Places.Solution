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
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}