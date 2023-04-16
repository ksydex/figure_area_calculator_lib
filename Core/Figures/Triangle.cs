using System;
using Ksydex.Figure.Interfaces;

namespace Ksydex.Figure.Figures
{
    /// <summary>
    /// Represents a triangle with three sides and an area.
    /// </summary>
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
        /// </summary>
        /// <param name="a">The length of side a of the triangle.</param>
        /// <param name="b">The length of side b of the triangle.</param>
        /// <param name="c">The length of side c of the triangle.</param>
        /// <exception cref="ArgumentException">Thrown when any side length is zero or negative, or when the side lengths do not satisfy the triangle inequality.</exception>
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

        /// <summary>
        /// Gets the area of the triangle using Heron's formula.
        /// </summary>
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