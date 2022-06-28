using Figures;
using NUnit.Framework;
using System;

namespace FiguresTests
{
    public class Triangle_Tests
    {
        [TestCase(5, 5, 5)]
        [TestCase(6, 6, 1)]
        [TestCase(2, 2, 3)]
        public void FindArea_Triangle_Success(double a, double b, double c)
        {
            //Act
            double p = (a + b + c) / 2;
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            var triangle = new Triangle(a, b, c);

            //Arrange
            double actual = triangle.FindArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -1)]
        public void FindArea_Triangle_Exception(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a,b,c));
        }

        [TestCase(10, 6, 8)]
        [TestCase(3, 5, 4)]
        public void isRectangle_True(double a,double b, double c)
        {
            //Act-Arrange
            var actual = Triangle.isRectangular(a, b, c);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(3, 5, 7)]
        public void isRectangle_False(double a, double b, double c)
        {
            //Act-Arrange
            var actual = Triangle.isRectangular(a, b, c);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}