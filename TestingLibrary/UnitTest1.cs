using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;
using System;

namespace TestingLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Triangle_Init()
        {
            Triangle triangle = new Triangle(5,10,20);
            Assert.IsNotNull(triangle);
        }
        [TestMethod]
        public void Test_Triangle_Rectangular_False()
        {
            Triangle triangle = new Triangle(5, 10, 20);
            Assert.AreEqual(triangle.Is_Triangle_Rectangular(), false);
        }
        [TestMethod]
        public void Test_Triangle_Rectangular_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.Is_Triangle_Rectangular(), true);
        }
        [TestMethod]
        public void Test_Triangle_Square()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.Calc_Square(), 6);
        }
        [TestMethod]
        public void Test_Circle()
        {
            Circle circle = new Circle(5);
            Assert.IsNotNull(circle);
        }
        [TestMethod]
        public void Test_Circle_Calc_Square()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(circle.Calc_Square(), 78,53981633974483);
        }
    }
}
