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

        // A small value used for floating point comparison
        private const double Epsilon = 0.0000001;
        
        /// <summary>
        /// Returns a value indicating whether the triangle is a right angled triangle.
        /// </summary>
        /// <remarks>
        /// A triangle is a right angle triangle if one of its angles is a right angle, or if the Pythagorean
        /// theorem is satisfied (i.e., a^2 + b^2 = c^2).
        /// </remarks>
        public bool IsRightAngled
        {
            get
            {
                // Calculate the squares of the lengths of the sides
                var a2 = Math.Pow(_a, 2);
                var b2 = Math.Pow(_b, 2);
                var c2 = Math.Pow(_c, 2);

                // Check if any two sides have lengths that satisfy the Pythagorean theorem
                return Math.Abs(a2 + b2 - c2) < Epsilon ||
                       Math.Abs(a2 + c2 - b2) < Epsilon ||
                       Math.Abs(b2 + c2 - a2) < Epsilon;
            }
        }

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
    }
}