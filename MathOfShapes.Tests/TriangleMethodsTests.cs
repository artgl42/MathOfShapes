using Xunit;
using MathOfShapes.Shapes;

namespace MathOfShapes.Tests
{
    public class TriangleMethodsTests
    {
        [Fact]
        public void SetTriangle_IsSquareness()
        {
            // Arrange
            double _sideA = 1;
            double _sideB = 1.8;
            double _sideC = 1.5;
            var _triangle = new Triangle(_sideA, _sideB, _sideC, Precision.Low);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.True(_isSquareness);
        }

        [Fact]
        public void SetTriangle_IsNotSquareness()
        {
            // Arrange
            double _sideA = 1;
            double _sideB = 2;
            double _sideC = 1.5;
            var _triangle = new Triangle(_sideA, _sideB, _sideC, Precision.Low);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.False(_isSquareness);
        }

        [Fact]
        public void SetTriangle_GetArea_PrecisionLow()
        {
            // Arrange
            double _sideA = 1;
            double _sideB = 1.8;
            double _sideC = 1.5;
            var _triangle = Shape.Builder()
                .SetRoundPrecision(Precision.Medium)
                .SetTriangle(_sideA, _sideB, _sideC)
                .Build();
            double _expected = 0.75;

            // Act
            double _actual = _triangle.Area;

            // Assert           
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetTriangle_GetArea_PrecisionHigh()
        {
            // Arrange
            double _sideA = 1.5;
            double _sideB = 1.7;
            double _sideC = 1.9;
            var _triangle = Shape.Builder()
                .SetRoundPrecision(Precision.High)
                .SetTriangle(_sideA, _sideB, _sideC)
                .Build();
            double _expected = 1.216;

            // Act
            double _actual = _triangle.Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}