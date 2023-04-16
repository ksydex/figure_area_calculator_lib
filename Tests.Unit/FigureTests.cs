using System;
using System.Collections.Generic;
using System.Linq;
using Ksydex.Figure.Figures;
using Ksydex.Figure.Interfaces;
using Xunit;

namespace Tests.Unit
{
    /// <summary>
    /// Unit tests for the <see cref="IFigure"/> interface.
    /// </summary>
    public class FigureTests
    {
        /// <summary>
        /// Tests the calculation of total area for a list of correct figures and checks that the expected total area is returned with the specified precision.
        /// </summary>
        [Fact]
        public void CalculateTotalArea_WithListOfCorrectFigures_ReturnsCorrectResult()
        {
            // Arrange: create a list of figures containing a triangle and a circle
            var figures = new List<IFigure>
            {
                new Triangle(3, 4, 5),
                new Circle(2)
            };

            // Act: calculate the total area of the figures using the Aggregate method
            const double expectedArea = 6 + Math.PI * 2 * 2;
            var totalArea = figures.Aggregate(0.0, (acc, x) => acc + x.Area);

            // Assert: check that the expected total area is returned with the specified precision
            Assert.Equal(expectedArea, totalArea, precision: 10);
        }
    }
}