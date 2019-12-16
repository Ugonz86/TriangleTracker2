using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker;

namespace Tracker.Tests
{
  [TestClass]
  public class TriangleTrackerTest
  {
    [TestMethod]
    public void IsTriangle_CheckIfSidesAreTriangle_True()
    {
        Triangle testTriangle = new Triangle(4, 4, 4);
        Assert.AreEqual("It's an Equilateral Triangle!", testTriangle.TriangleType());
    }


    [TestMethod]
    public void IsTriangle_CheckIfSidesAreNotTriangle_False()
    {
        Triangle testTriangle = new Triangle(6, 2, 2);
        Assert.AreEqual("It's not a Triangle!", testTriangle.TriangleType());
    }


    [TestMethod]
    public void IsTriangle_CheckIfSidesAreIsosceles_True()
    {
        Triangle testTriangle = new Triangle(4, 4, 5);
        Assert.AreEqual("It's an Isosceles Triangle!", testTriangle.TriangleType());
    }

  }
}