using Xunit;
using MathOfShapes.Shapes;

namespace MathOfShapes.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_GetArea_PrecisionHigh()
        {
            // Arrange
            double _radius = 5;
            Circle _circle = new Circle(_radius, Precision.High);
            double _expected = 78.5398;

            // Act
            double _actual = MathOfShape.GetArea(_circle);

            // Assert
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void Circle_GetArea_PrecisionLow()
        {
            // Arrange
            double _radius = 12;
            Circle _circle = new Circle(_radius, Precision.Low);
            double _expected = 452.39;

            // Act
            double _actual = MathOfShape.GetArea(_circle);

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}
