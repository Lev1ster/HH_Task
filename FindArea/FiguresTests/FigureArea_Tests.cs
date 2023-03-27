using Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresTests
{
    public class FigureArea_Tests
    {
        [TestCase(0)]
        [TestCase(1)]
        public void FindAreaFigure_Success(int i)
        {
            //Act
            double expected = DataForArea.data[i].FindArea();
            var figure = DataForArea.data[i];

            //Arrange
            double actual = FigureArea.FindArea(figure);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public static class DataForArea
    {
        public static IFigure[] data = new IFigure[2] { new Triangle(2, 3, 2), new Circle(3) };
    }
}
