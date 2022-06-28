using System;

namespace Figures
{
    public class Triangle : IFigure
    {
        double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideC > sideB && sideA + sideB > sideC && sideB + sideC > sideA)
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else
            {
                throw new ArgumentException("Sides Triangle not valid");
            }
        }

        public double FindArea()
        {
            double p = (_sideC + _sideB + _sideA) / 2;

            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public static bool isRectangular(double sideA, double sideB, double sideC)
            => (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) ||
            (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2)) ||
            (Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2));

        public bool isRectangular() => isRectangular(_sideA, _sideB, _sideC);
    }
}
