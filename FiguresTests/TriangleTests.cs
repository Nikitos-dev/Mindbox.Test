using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, -3, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, -5));
        }

        [TestMethod()]
        public void IsRightTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isRightTriangle = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(true, isRightTriangle);
        }

        [TestMethod()]
        public void AreaTest()
        {
            //Arrange
            var triangle = new Triangle(3,4,5);

            //Act
            var triangleSquare = triangle.Area();

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            //Arrange
            var triangle = new Triangle(5, 6, 7);

            //Act
            var trianglePerim = triangle.Perimeter();

            //Assert
            Assert.AreEqual(18, trianglePerim);
        }
    }
}