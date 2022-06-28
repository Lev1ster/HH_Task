using System;

namespace Figures
{
    public class Circle : IFigure
    {
        int _radius;

        public Circle(int radius)
        {
            if (radius > 0)
                _radius = radius;
            else
                throw new ArgumentException("Radius not valid");
        }

        public double FindArea() => Math.PI * _radius * _radius;
    }
}
