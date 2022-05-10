using MathOfShapes.MethodsForArea;
using MathOfShapes.Shapes;
using Xunit;

namespace MathOfShapes.Tests
{
    public class TriangleMethodsTests
    {
        [Fact]
        public void SetTriangle_IsSquareness()
        {
            // Arrange
            var _triangle = new Triangle(new TriangleAreaByHeron(), Precision.Low, 1, 1.8, 1.5);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.True(_isSquareness);
        }

        [Fact]
        public void SetTriangle_IsNotSquareness()
        {
            // Arrange
            var _triangle = new Triangle(new TriangleAreaByHeron(), Precision.Low, 1, 2, 1.5);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.False(_isSquareness);
        }

        [Fact]
        public void SetTriangle_GetArea_PrecisionLow()
        {
            // Arrange
            var _triangle = Shape.Builder()
                .SetPrecision(Precision.Medium)
                .SetSideA(1)
                .SetSideB(1.8)
                .SetSideC(1.5)
                .Build();
            double _expected = 0.75;

            // Act
            double _actual = _triangle[0].Area;

            // Assert           
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void SetTriangle_GetArea_PrecisionHigh()
        {
            // Arrange
            var _triangle = Shape.Builder()
                .SetPrecision(Precision.High)
                .SetSideA(1.5)
                .SetSideB(1.7)
                .SetSideC(1.9)
                .Build();
            double _expected = 1.216;

            // Act
            double _actual = _triangle[0].Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}