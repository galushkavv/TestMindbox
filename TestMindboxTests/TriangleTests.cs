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
    public class TriangleTests
    {
        private int precision = 4;

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(13, 14, 15, 84)]
        [DataRow(10, 15, 20, 72.6184)]
        public void CalculateArea(double a, double b, double c, double expectedArea)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.Round(area, precision), Math.Round(expectedArea, precision));
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(1, 2, 1)]
        public void Triangle_WrongSidesLength_Exception(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                IAreaCalculatable shape = new Triangle(a, b, c);
            });
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(4, 5, 3)]
        public void IsRightTriangle(double a, double b, double c)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            bool result = triangle.IsRightTriangle;

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(7, 6, 4);

            // Act
            bool result = triangle.IsRightTriangle;

            //Assert
            Assert.IsFalse(result);
        }
    }
}