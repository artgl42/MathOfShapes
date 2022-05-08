using Xunit;
using MathOfShapes.Shapes;

namespace MathOfShapes.Tests
{
    public class CircleMethodsTests
    {
        [Fact]
        public void SetCircle_GetArea_PrecisionMedium()
        {
            // Arrange
            double _radius = 5;
            var _circle = Shape.Builder()
                .SetRoundPrecision(Precision.Medium)
                .SetRadius(_radius)
                .Build();
            double _expected = 78.54;

            // Act
            double _actual = _circle.Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetCircle_GetArea_PrecisionHigh()
        {
            // Arrange
            double _radius = 12;
            var _circle = Shape.Builder()
                .SetRoundPrecision(Precision.High)
                .SetRadius(_radius)
                .Build();
            double _expected = 452.389;

            // Act
            double _actual = _circle.Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}
