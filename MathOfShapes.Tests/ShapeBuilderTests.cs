using MathOfShapes.Shapes;
using Xunit;

namespace MathOfShapes.Tests
{
    public class ShapeBuilderTests
    {
        [Fact]
        public void SetTriangle_GetTriangle()
        {
            // Act
            var _actual = Shape.Builder()
                .SetPrecision(Precision.Low)
                .SetSideA(1)
                .SetSideB(2)
                .SetSideC(1.5)
                .Build();

            // Assert
            Assert.IsType<Triangle>(_actual);
        }

        [Fact]
        public void SetCircle_GetCircle()
        {
            // Act
            var _actual = Shape.Builder()
                .SetPrecision(Precision.Low)
                .SetRadius(4)
                .Build();

            // Assert
            Assert.IsType<Circle>(_actual);
        }
    }
}
