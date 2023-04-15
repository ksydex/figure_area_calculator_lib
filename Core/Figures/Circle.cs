using System;
using Core.Interfaces;

namespace Core.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public double Area => Math.PI * _radius * _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive number.");

            _radius = radius;
        }
    }
}