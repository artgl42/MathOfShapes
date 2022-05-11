using MathOfShapes.Shapes;
using Xunit;

namespace MathOfShapes.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void SetTriangle_IsSquareness()
        {
            // Arrange
            var _triangle = new TriangleBySides(RoundAccuracy.Low, 1, 1.8, 1.5);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.True(_isSquareness);
        }

        [Fact]
        public void SetTriangle_IsNotSquareness()
        {
            // Arrange
            var _triangle = new TriangleBySides(RoundAccuracy.High, 1, 2, 1.5);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.False(_isSquareness);
        }

        [Fact]
        public void SetTriangleBySides_GetArea_RoundAccuracyMedium()
        {
            // Arrange
            var _triangle = Shape.Builder()
                .SetTriangle(RoundAccuracy.Medium, 1, 1.8, 1.5)
                .Build();
            double _expected = 0.75;

            // Act
            double _actual = _triangle[0].Area;

            // Assert           
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetTriangleBySides_GetArea_RoundAccuracyHigh()
        {
            // Arrange
            var _triangle = Shape.Builder()
                .SetTriangle(RoundAccuracy.High, 1.5, 1.7, 1.9)
                .Build();
            double _expected = 1.216;

            // Act
            double _actual = _triangle[0].Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetTriangleByHeight_GetArea_RoundAccuracyHigh()
        {
            // Arrange
            var _triangle = Shape.Builder()
                .SetTriangle(RoundAccuracy.High, 1.5, 1.7)
                .Build();
            double _expected = 1.275;

            // Act
            double _actual = _triangle[0].Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetTriangleByHeight_GetArea_RoundAccuracyMedium()
        {
            // Arrange
            var _triangle = Shape.Builder()
                .SetTriangle(RoundAccuracy.Medium, 1.5, 1.7)
                .Build();
            double _expected = 1.27;

            // Act
            double _actual = _triangle[0].Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}