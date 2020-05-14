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
    public class RoundTests
    {
        [TestMethod()]
        public void RoundTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Round(-12));
        }

        [TestMethod()]
        public void AreaTest()
        {
            //Arrange
            var round = new Round(9);

            //Act
            var roundArea = round.Area();

            //Assert
            Assert.AreEqual(254.46900494077326, roundArea);
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            var round = new Round(10);

            //Act
            var roundPerim = round.Perimeter();

            //Assert
            Assert.AreEqual(62.831853071795862, roundPerim);
        }
    }
}