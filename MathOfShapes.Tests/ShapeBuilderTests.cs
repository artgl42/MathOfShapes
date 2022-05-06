using MathOfShapes.Shapes;
using Xunit;

namespace MathOfShapes.Tests
{
    public class ShapeBuilderTests
    {
        [Fact]
        public void NoSet_GetUnknown()
        {
            // Act
            var _actual = Shape.Builder().Build();

            // Assert
            Assert.IsType<Unknown>(_actual);
        }

        [Fact]
        public void SetTriangle_SetCircle_GetUnknown()
        {
            // Act
            var _actual = Shape.Builder()
                .SetRoundPrecision(Precision.Low)
                .SetTriangle(1, 2, 3)
                .SetCircle(4)
                .Build();

            // Assert
            Assert.IsType<Unknown>(_actual);
        }

        [Fact]
        public void SetTriangle_GetTriangle()
        {
            // Act
            var _actual = Shape.Builder()
                .SetRoundPrecision(Precision.Low)
                .SetTriangle(1, 2, 1.5)
                .Build();

            // Assert
            Assert.IsType<Triangle>(_actual);
        }

        [Fact]
        public void SetTriangleWrongSides_GetUnknown()
        {
            // Act
            var _actual = Shape.Builder()
                .SetRoundPrecision(Precision.Low)
                .SetTriangle(1, 1, 5)
                .Build();

            // Assert
            Assert.IsType<Unknown>(_actual);
        }

        [Fact]
        public void SetCircle_GetCircle()
        {
            // Act
            var _actual = Shape.Builder()
                .SetRoundPrecision(Precision.Low)
                .SetCircle(4)
                .Build();

            // Assert
            Assert.IsType<Circle>(_actual);
        }

        [Fact]
        public void SetCircleWrongRadius_GetUnknown()
        {
            // Act
            var _actual = Shape.Builder()
                .SetRoundPrecision(Precision.Low)
                .SetCircle(4)
                .Build();

            // Assert
            Assert.IsType<Circle>(_actual);
        }
    }
}
