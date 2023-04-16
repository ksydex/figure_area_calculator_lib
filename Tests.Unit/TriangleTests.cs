using System;
using Ksydex.Figure.Figures;
using Xunit;

namespace Tests.Unit
{
    /// <summary>
    /// Unit tests for the <see cref="Triangle"/> class.
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// Tests the <see cref="Triangle.Area"/> property for triangles with valid side lengths, and checks that the expected area is returned.
        /// </summary>
        /// <param name="a">The length of side a of the triangle.</param>
        /// <param name="b">The length of side b of the triangle.</param>
        /// <param name="c">The length of side c of the triangle.</param>
        /// <param name="expectedArea">The expected area of the triangle.</param>
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(8, 15, 17, 60)]
        public void Area_WithValidSides_ReturnsCorrectResult(double a, double b, double c, double expectedArea)
        {
            // Arrange: create a new Triangle object with the specified side lengths
            var triangle = new Triangle(a, b, c);

            // Act: get the area of the Triangle object
            var area = triangle.Area;

            // Assert: check that the expected area is returned
            Assert.Equal(expectedArea, area);
        }

        /// <summary>
        /// Tests that an <see cref="ArgumentException"/> is thrown when a <see cref="Triangle"/> object is created with invalid side lengths.
        /// </summary>
        /// <param name="a">The length of side a of the triangle.</param>
        /// <param name="b">The length of side b of the triangle.</param>
        /// <param name="c">The length of side c of the triangle.</param>
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(10, 100, 1000)]
        [InlineData(-1, 2, -3)]
        public void InvalidSides_ThrowsArgumentException_OnInit(double a, double b, double c)
        {
            // Assert: check that an ArgumentException is thrown when creating a Triangle object with invalid side lengths
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}
