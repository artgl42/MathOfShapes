using Xunit;
using MathOfShapes.Shapes;
using System.Collections.Generic;

namespace MathOfShapes.Tests
{
    public class TriangleMethodsTests
    {
        [Fact]
        public void SetTriangle_IsSquareness()
        {
            // Arrange
            var _shapeParams = new Dictionary<ShapeParam, double>()
                {
                    [ShapeParam.SideA] = 1,
                    [ShapeParam.SideB] =  1.8,
                    [ShapeParam.SideC] = 1.5
                };
            var _triangle = new Triangle(Precision.Low, _shapeParams, null);

            // Act
            bool _isSquareness = _triangle.IsSquareness;

            // Assert
            Assert.True(_isSquareness);
        }

        [Fact]
        public void SetTriangle_IsNotSquareness()
        {
            // Arrange
            var _shapeParams = new Dictionary<ShapeParam, double>()
            {
                [ShapeParam.SideA] = 1,
                [ShapeParam.SideB] = 2,
                [ShapeParam.SideC] = 1.5
            };
            var _triangle = new Triangle(Precision.Low, _shapeParams, null);

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
                .SetRoundPrecision(Precision.Medium)
                .SetSideA(1)
                .SetSideB(1.8)
                .SetSideC(1.5)
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
            var _triangle = Shape.Builder()
                .SetRoundPrecision(Precision.High)
                .SetSideA(1.5)
                .SetSideB(1.7)
                .SetSideC(1.9)
                .Build();
            double _expected = 1.216;

            // Act
            double _actual = _triangle.Area;

            // Assert
            Assert.Equal(_expected, _actual);
        }
    }
}