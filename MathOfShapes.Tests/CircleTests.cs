using Xunit;

namespace MathOfShapes.Tests
{
    public class CircleTests
    {
        [Fact]
        public void SetCircle_GetArea_PrecisionMedium()
        {
            // Arrange
            var _circle = Shape.Builder()
                .SetCircle(RoundAccuracy.Medium, 5)
                .Build();
            double _expected = 78.54;

            // Act
            double _actual = _circle[0].Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetCircle_GetArea_PrecisionHigh()
        {
            // Arrange
            var _circle = Shape.Builder()
                .SetCircle(RoundAccuracy.High, 12)
                .Build();
            double _expected = 452.389;

            // Act
            double _actual = _circle[0].Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}
