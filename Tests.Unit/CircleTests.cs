using System;
using Core.Figures;
using Xunit;

namespace Tests.Unit
{
    /// <summary>
    /// Unit tests for the <see cref="Circle"/> class.
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Tests the <see cref="Circle.Area"/> property for different radii and checks that the expected area is returned with the specified precision.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <param name="expectedArea">The expected area of the circle.</param>
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        [InlineData(3, 9 * Math.PI)]
        public void Area_WithValidRadius_ReturnsCorrectResult(double radius, double expectedArea)
        {
            // Arrange: create a new Circle object with the specified radius
            var circle = new Circle(radius);

            // Act: get the area of the Circle object
            var area = circle.Area;

            // Assert: check that the expected area is returned with the specified precision
            Assert.Equal(expectedArea, area, precision: 10);
        }

        /// <summary>
        /// Tests that an <see cref="ArgumentException"/> is thrown when a <see cref="Circle"/> object is created with an invalid radius.
        /// </summary>
        /// <param name="radius">The invalid radius to use when creating the circle.</param>
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void InvalidRadius_ThrowsArgumentException_OnInit(double radius)
        {
            // Assert: check that an ArgumentException is thrown when creating a Circle object with an invalid radius
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}