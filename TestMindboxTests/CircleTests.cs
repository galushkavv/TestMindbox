using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindbox.Tests
{
    [TestClass]
    public class CircleTests
    {
        private int precision = 4;

        [TestMethod]
        [DataRow(1, 3.1416)]
        [DataRow(2, 12.5664)]
        public void CalculateArea(double radius, double expectedArea)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.Round(area, precision), Math.Round(expectedArea, precision));
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public void Circle_ZeroOrLessRadius_Exception(double radius)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                IAreaCalculatable shape = new Circle(radius);
            });
        }
    }
}