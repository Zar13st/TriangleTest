using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AllSidesGreaterZeroTest()
        {
            Triangle t = new Triangle(4, 0, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TrianglePossibleTest()
        {
            Triangle t = new Triangle(2, 2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotRegularTriangleTest()
        {
            Triangle t = new Triangle(2, 2, 3);
        }

        [TestMethod]
        public void CorrectRegularTriangleTest()
        {
            Triangle t = new Triangle(3, 4, 5);
        }

        [TestMethod]
        public void AreaTest()
        {
            Triangle t = new Triangle(3, 4, 5);

            double expected = 3 * 4 / 2;
            double area = t.Area();

            Assert.AreEqual(expected, area, 1E-4);
        }
    }
}
