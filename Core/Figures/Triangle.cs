using System;
using Core.Interfaces;

namespace Core.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides must be positive numbers.");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("The sum of any two sides must be greater than the third side.");

            _a = a;
            _b = b;
            _c = c;
        }

        public double Area
        {
            get
            {
                var p = (_a + _b + _c) / 2;
                return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            }
        }
    }
}