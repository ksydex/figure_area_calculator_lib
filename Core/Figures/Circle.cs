using System;
using Ksydex.Figure.Interfaces;

namespace Ksydex.Figure.Figures
{
    /// <summary>
    /// Represents a circle with a radius and an area.
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double _radius;

        /// <summary>
        /// Gets the area of the circle.
        /// </summary>
        public double Area => Math.PI * _radius * _radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is zero or negative.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive number.");

            _radius = radius;
        }
    }
}