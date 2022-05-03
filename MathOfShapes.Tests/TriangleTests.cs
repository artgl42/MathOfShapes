using Xunit;
using MathOfShapes.Shapes;

namespace MathOfShapes.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_IsSquareness()
        {
            // Arrange
            double _sideA = 1;
            double _sideB = 1.8;
            double _sideC = 1.5;
            Triangle _triangle = new Triangle(_sideA, _sideB, _sideC, Precision.Low);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.True(_isSquareness);
        }

        [Fact]
        public void Triangle_IsNotSquareness()
        {
            // Arrange
            double _sideA = 1;
            double _sideB = 2;
            double _sideC = 1.5;
            Triangle _triangle = new Triangle(_sideA, _sideB, _sideC, Precision.Low);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.False(_isSquareness);
        }

        [Fact]
        public void Triangle_GetArea_PrecisionLow()
        {
            // Arrange
            double _sideA = 1;
            double _sideB = 1.8;
            double _sideC = 1.5;
            Triangle _triangle = new Triangle(_sideA, _sideB, _sideC, Precision.Low);
            double _expected = 0.75;

            // Act
            double _actual = MathOfShape.GetArea(_triangle);

            // Assert           
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void Triangle_GetArea_PrecisionHigh()
        {
            // Arrange
            double _sideA = 1.5;
            double _sideB = 1.7;
            double _sideC = 1.9;
            Triangle _triangle = new Triangle(_sideA, _sideB, _sideC, Precision.High);
            double _expected = 1.2163;

            // Act
            double _actual = MathOfShape.GetArea(_triangle);

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}