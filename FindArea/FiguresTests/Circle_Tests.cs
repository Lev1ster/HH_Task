using Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresTests
{
    public class Circle_Tests
    {
        [TestCase(5)]
        [TestCase(1)]
        [TestCase(2)]
        public void FindAreaCircle_Success(int radius)
        {
            //Act
            double expected = Math.PI * radius * radius;
            var circle = new Circle(radius);

            //Arrange
            double actual = circle.FindArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FindAreaCircle_Exception(int radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
